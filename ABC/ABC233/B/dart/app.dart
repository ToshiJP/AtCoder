import 'dart:io';

void main(List<String> args) {
  var list = stdin.readLineSync()?.split(' ') ?? [];
  var l = int.parse(list[0]) - 1;
  var r = int.parse(list[1]) - 1;
  var str = stdin.readLineSync() ?? "";
  var s = "";
  for (var i = 0; i < l; i++) {
    s += str[i];
  }
  for (var i = r; i >= l; i--) {
    s += str[i];
  }
  for (var i = r + 1; i < str.length; i++) {
    s += str[i];
  }
  print(s);
}
