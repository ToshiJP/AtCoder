import 'dart:io';

void main(List<String> args) {
  var s = stdin.readLineSync() ?? "0";
  var abc = int.parse(s[0] + s[1] + s[2]);
  var bca = int.parse(s[1] + s[2] + s[0]);
  var cab = int.parse(s[2] + s[0] + s[1]);
  print(abc + bca + cab);
}
