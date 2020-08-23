using System;

namespace ABC174.Problems
{
    class D
    {
        static void Main()
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var n = int.Parse(Console.ReadLine());
            char[] cs = Console.ReadLine().ToCharArray();

            int res = 0;
            int i = 0;
            int j = n - 1;
            while (true)
            {
                while (i < n  && cs[i] == 'R') i++;
                while (j >= 0 && cs[j] == 'W') j--;
                if (i < j)
                {
                    char temp = cs[i];
                    cs[i] = cs[j];
                    cs[j] = temp;
                    res++;
                } else {
                    break;
                }
            }
            Console.WriteLine(res);

            Console.Out.Flush();
        }
    }
}
