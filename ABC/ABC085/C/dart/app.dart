import 'dart:io';

void main(List<String> args) {
  var tmp = stdin.readLineSync()?.split(' ') ?? [];
  var n = int.parse(tmp[0]);
  var y = int.parse(tmp[1]) ~/ 1000;

  var ai = -1;
  var aj = -1;
  var ak = -1;
  for (var i = 0; i <= n; i++) {
    for (var j = 0; j <= n - i; j++) {
      var k = y - 10 * i - 5 * j;
      if (k >= 0 && i + j + k == n) {
        ai = i;
        aj = j;
        ak = k;
      }
    }
  }
  print('$ai $aj $ak');
}
