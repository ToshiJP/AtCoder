import 'dart:io';

void main(List<String> args) {
  var list = stdin.readLineSync()?.split(' ') ?? [];
  var prod = int.parse(list[0]) * int.parse((list[1]));
  if (prod % 2 == 1) {
    print("Odd");
  } else {
    print("Even");
  }
}
