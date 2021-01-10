import 'dart:io';

void main(List<String> args) {
  List<int> list =
      stdin.readLineSync()?.split(' ').map((e) => int.parse(e)).toList() ?? [];
  var ans = 0;
  for (var i = 1; i <= list[0]; i++) {
    var sum = 0;
    var j = i;
    while (j != 0) {
      sum += j % 10;
      j ~/= 10;
    }
    if (sum >= list[1] && sum <= list[2]) ans += i;
  }
  print(ans);
}
