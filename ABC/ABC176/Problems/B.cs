using System;

namespace ABC176.Problems
{
    class B
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            string str = Console.ReadLine();

            long sum = 0;
            foreach (var c in str)
            {
                sum += c - '0';
            }

            Console.WriteLine(sum % 9 == 0 ? "Yes" : "No");

            Console.Out.Flush();
        }
    }
}
