using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var _ = Console.ReadLine();
        var h = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        var ans = h[0];
        for (int i = 1; i < h.Length; i++)
        {
            if (ans >= h[i]) break;
            ans = h[i];
        }
        Console.WriteLine(ans);
    }
}

