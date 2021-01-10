import 'dart:io';

void main(List<String> args) {
  int a = int.parse(stdin.readLineSync() ?? "0"); // 10 yen
  int b = int.parse(stdin.readLineSync() ?? "0"); // 2 yen
  int c = int.parse(stdin.readLineSync() ?? "0"); // 1
  int x = int.parse(stdin.readLineSync() ?? "0") ~/ 50;

  var ans = 0;
  for (var i = 0; i <= a; i++) {
    for (var j = 0; j <= b; j++) {
      var k = x - 10 * i - 2 * j;
      if (k >= 0 && k <= c) ans++;
    }
  }
  print(ans);
}
