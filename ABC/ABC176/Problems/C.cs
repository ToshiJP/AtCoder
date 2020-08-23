using System;
using System.Numerics;

namespace ABC176.Problems
{
    class C
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            int n = int.Parse(Console.ReadLine());
            string[] ss = Console.ReadLine().Split(" ");
            int[] a = new int[n+1];
            for (int i = 0; i < n; i++) {
                a[i] = int.Parse(ss[i]);
            }

            long sum = 0;
            for (int i = 1; i < n; i++) {
                if (a[i-1] > a[i]) {
                    sum += a[i-1] - a[i];
                    a[i] = a[i-1];
                }
            }
            Console.WriteLine(sum);

            Console.Out.Flush();
        }
    }
}
