import 'dart:io';
import 'dart:convert';

Future<void> main() async {
  var lines = stdin.transform(utf8.decoder).transform(const LineSplitter());
  await for (final line in lines) {
    final a = int.parse(line[0]);
    final b = int.parse(line[2]);
    print(a * b);
  }
}
