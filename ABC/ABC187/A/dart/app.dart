import 'dart:io';

void main(List<String> args) {
  var list = stdin.readLineSync()?.split(' ') ?? [];
  var sa =
      list[0].runes.map((e) => e - '0'.codeUnitAt(0)).reduce((a, b) => a + b);
  var sb =
      list[1].runes.map((e) => e - '0'.codeUnitAt(0)).reduce((a, b) => a + b);
  print(sa > sb ? sa : sb);
}
