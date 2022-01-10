import 'dart:io';

void main() {
  var t = int.parse(stdin.readLineSync() ?? "0");
  print(f(f(f(t) + t) + f(f(t))));
}

int f(int x) => x * x + 2 * x + 3;
