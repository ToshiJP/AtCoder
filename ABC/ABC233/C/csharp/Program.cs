using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var ss = Console.ReadLine().Split(" ");
        var n = int.Parse(ss[0]);
        var x = long.Parse(ss[1]);
        var list = new List<long>();
        list.Add(x);
        for (int i = 0; i < n; i++)
        {
            var a = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            var nextList = new List<long>();
            foreach (long y in list)
            {
                for (int j = 1; j < a.Length; j++)
                {
                    if (y % a[j] == 0)
                    {
                        nextList.Add(y / a[j]);
                    }
                }
            }
            list = nextList;
        }
        Console.WriteLine(list.Where((y) => y == 1).Count());
    }
}
