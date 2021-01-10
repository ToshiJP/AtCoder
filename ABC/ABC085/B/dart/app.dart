import 'dart:io';

void main(List<String> args) {
  int n = int.parse(stdin.readLineSync() ?? "0");
  Set<String> s = {};
  for (var i = 0; i < n; i++) {
    s.add(stdin.readLineSync() ?? "");
  }
  print(s.length);
}
