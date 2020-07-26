using System;
using System.Numerics;
namespace MSOLUTIONS.Problems
{
    class C
    {
        static void Main()
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var inputs1 = Console.ReadLine().Split(" ");
            var inputs2 = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs1[0]);
            var k = int.Parse(inputs1[1]);
            var a = new int[n+1];
            for (var i = 1; i <= n; i++)
            {
                a[i] = int.Parse(inputs2[i-1]);
            }
            for (var i = k + 1; i <= n; i++)
            {
                if (a[i] > a[i-k])
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
            Console.Out.Flush();
        }
    }
}
