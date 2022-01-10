import 'dart:io';

void main(List<String> args) {
  var k = int.parse(stdin.readLineSync() ?? "0");
  var s = k.toRadixString(2).replaceAll("1", "2");
  print(s);
}
