using System;

namespace ABC174.Problems
{
    class A
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n >= 30 ? "Yes" : "No");

            Console.Out.Flush();
        }
    }
}
