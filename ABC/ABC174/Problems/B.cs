using System;

namespace ABC174.Problems
{
    class B
    {
        static void Main(string[] args)
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            string[] ss1 = Console.ReadLine().Split(" ");
            int n = int.Parse(ss1[0]);
            long d = long.Parse(ss1[1]);

            int res = 0;
            for (int i = 0; i < n; i++)
            {
                string[] strs = Console.ReadLine().Split(" ");
                long x = long.Parse(strs[0]);
                long y = long.Parse(strs[1]);
                if (x * x + y * y <= d * d)
                {
                    res++;
                }
            }
            Console.WriteLine(res);

            Console.Out.Flush();
        }
    }
}
