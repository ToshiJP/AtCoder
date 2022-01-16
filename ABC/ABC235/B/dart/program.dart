import 'dart:io';

void main(List<String> args) {
  var n = int.parse(stdin.readLineSync() ?? "0");
  var h = stdin.readLineSync()?.split(" ").map(int.parse).toList() ?? [];
  var ans = h[0];
  for (var i = 1; i < n; i++) {
    if (ans < h[i]) {
      ans = h[i];
    } else {
      break;
    }
  }
  print(ans);
}
