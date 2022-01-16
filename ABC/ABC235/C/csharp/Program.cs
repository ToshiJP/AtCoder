using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        var m = new Dictionary<int, List<int>>();
        var line1 = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        var n = line1[0];
        var q = line1[1];
        var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        for (var i = 0; i < n; i++) {
            if (!m.ContainsKey(a[i]))
            {
                m.Add(a[i], new List<int>());
                m[a[i]].Add(i + 1);
            }
            else
            {
                m[a[i]].Add(i + 1);
            }
        }
        for (var j = 0; j < q; j++)
        {
            var line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var x = line[0];
            var k = line[1];
            if (!m.ContainsKey(x) || m[x].Count < k) {
                Console.WriteLine(-1);
            } else {
                Console.WriteLine(m[x][k - 1]);
            }
        }
    }
}
