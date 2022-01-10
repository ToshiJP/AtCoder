import 'dart:io';
import 'dart:math';

void main(List<String> args) {
  var n = int.parse(stdin.readLineSync() ?? "0");
  var x = <int>[];
  var y = <int>[];
  for (var i = 0; i < n; i++) {
    var list = stdin.readLineSync()?.split(' ') ?? [];
    x.add(int.parse(list[0]));
    y.add(int.parse(list[1]));
  }
  var d = 0.0;
  for (var i = 0; i < n; i++) {
    for (var j = i; j < n; j++) {
      var dx = x[i] - x[j];
      var dy = y[i] - y[j];
      d = max(d, sqrt(dx * dx + dy * dy));
    }
  }
  print(d);
}
