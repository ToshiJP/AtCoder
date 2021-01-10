import 'dart:io';

void main(List<String> args) {
  var s = stdin.readLineSync()?.split('').toList().reversed.join() ?? '';
  var ans = 'YES';
  while (s != '') {
    if (s.startsWith('maerd')) {
      s = s.substring(5);
    } else if (s.startsWith('remaerd')) {
      s = s.substring(7);
    } else if (s.startsWith('esare')) {
      s = s.substring(5);
    } else if (s.startsWith('resare')) {
      s = s.substring(6);
    } else {
      ans = 'NO';
      break;
    }
  }
  print(ans);
}
