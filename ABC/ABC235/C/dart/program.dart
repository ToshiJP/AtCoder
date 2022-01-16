import 'dart:convert';
import 'dart:io';
import 'dart:async';

Future<void> main(List<String> args) async {
  var line1 = stdin.readLineSync()?.split(" ") ?? [];

  var m = Map<int, List<int>>();
  var n = int.parse(line1[0]);
  var q = int.parse(line1[1]);

  var isFirst = true;
  List<int> a;

  var lines = stdin.transform(utf8.decoder).transform(const LineSplitter());
  await for (var line in lines) {
    if (isFirst) {
      a = line.split(" ").map(int.parse).toList();
      isFirst = false;
      for (var i = 0; i < n; i++) {
        if (!m.containsKey(a[i])) {
          m[a[i]] = [];
        }
        m[a[i]]?.add(i + 1);
      }
    } else {
      var s = line.split(" ");
      var x = int.parse(s[0]);
      var k = int.parse(s[1]);
      var l = m[x];
      if (l == null || l.length < k) {
        print(-1);
      } else {
        print(l[k - 1]);
      }
    }
  }
}
