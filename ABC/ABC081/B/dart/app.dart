import 'dart:io';

void main(List<String> args) {
  stdin.readLineSync();
  var list = stdin.readLineSync()?.split(' ').map((e) => int.parse(e)) ?? [];
  var ans = 1000000000;
  for (var i in list) {
    var tmp = 0;
    while (i % 2 == 0) {
      i ~/= 2;
      tmp++;
    }
    if (ans > tmp) ans = tmp;
  }
  print(ans);
}
