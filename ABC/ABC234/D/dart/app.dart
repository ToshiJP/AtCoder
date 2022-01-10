import 'dart:convert';
import 'dart:io';
import 'dart:math';

void main(List<String> args) async {
  var list = stdin.readLineSync()?.split(' ') ?? [];
  var n = int.parse(list[0]);
  var k = int.parse(list[1]);
  var line =
      await stdin.transform(utf8.decoder).transform(LineSplitter()).first;
  var p = line.split(' ').map((x) => int.parse(x)).toList();
  var flags = List.filled(n + 1, false);
  var index = n;
  var sb = StringBuffer();
  for (var i = 0; i < k; i++) {
    flags[p[i]] = true;
    index = min(index, p[i]);
  }
  sb.write(index);
  for (var i = k; i < n; i++) {
    flags[p[i]] = true;
    if (index < p[i]) {
      do {
        index++;
      } while (!flags[index]);
    }
    sb
      ..write("\n")
      ..write(index);
  }
  print(sb);
}
