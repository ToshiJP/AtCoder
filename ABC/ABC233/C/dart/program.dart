import 'dart:convert';
import 'dart:io';

void main(List<String> args) async {
  var str = stdin.readLineSync()?.split(" ") ?? [];
  var _ = int.parse(str[0]);
  var x = int.parse(str[1]);
  var list = [x];
  var lines = stdin.transform(utf8.decoder).transform(const LineSplitter());
  await for (var line in lines) {
    var ary = line.split(" ").map(int.parse).toList();
    var nextList = <int>[];
    for (var y in list) {
      for (var i = 1; i < ary.length; i++) {
        if (y % ary[i] == 0) {
          nextList.add(y ~/ ary[i]);
        }
      }
    }
    list = nextList;
  }
  print(list.where((y) => y == 1).length);
}
