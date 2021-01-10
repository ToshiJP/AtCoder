import 'dart:io';

void main(List<String> args) {
  stdin.readLineSync();
  var list =
      stdin.readLineSync()?.split(' ').map((e) => int.parse(e)).toList() ?? [];
  list.sort((a, b) => b - a);
  print(list);
  var ans = 0;
  var flg = true;
  for (var ai in list) {
    if (flg) {
      ans += ai;
    } else {
      ans -= ai;
    }
    flg = !flg;
  }
  print(ans);
}
