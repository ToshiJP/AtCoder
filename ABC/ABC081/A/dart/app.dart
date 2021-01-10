import 'dart:io';

void main(List<String> args) {
  var s = stdin.readLineSync() ?? "";
  var ans = s.runes.fold(0, (int v, e) => v + e - '0'.codeUnitAt(0));
  print(ans);
}
