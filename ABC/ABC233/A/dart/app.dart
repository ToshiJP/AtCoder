import 'dart:io';

void main() {
  var list = stdin.readLineSync()?.split(' ') ?? [];
  var x = int.parse(list[0]);
  var y = int.parse(list[1]);
  print(x >= y ? 0 : ((y - x) + 9) ~/ 10);
}
