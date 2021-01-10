import 'dart:convert';
import 'dart:io';

void main(List<String> args) async {
  var n = int.parse(stdin.readLineSync() ?? "0");
  var lines = stdin.transform(utf8.decoder).transform(LineSplitter());
  var ans = 'Yes';
  var prevT = 0;
  var prevX = 0;
  var prevY = 0;
  var cnt = 0;
  await for (var line in lines) {
    if (cnt >= n) break;
    cnt++;
    var list = line.split(' ');
    var t = int.parse(list[0]);
    var x = int.parse(list[1]);
    var y = int.parse(list[2]);
    var dt = t - prevT;
    var dx = x - prevX;
    var dy = y - prevY;
    var d = dt - dx.abs() - dy.abs();
    if (d % 2 != 0 || d < 0) {
      ans = 'No';
    }
    prevT = t;
    prevX = x;
    prevY = y;
  }
  print(ans);
}
