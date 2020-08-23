using System;

namespace ABC176.Problems
{
    class A
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            string[] ss1 = Console.ReadLine().Split(" ");
            int n = int.Parse(ss1[0]);
            int x = int.Parse(ss1[1]);
            int t = int.Parse(ss1[2]);

            Console.WriteLine((n + x - 1) / x * t);

            Console.Out.Flush();
        }
    }
}
