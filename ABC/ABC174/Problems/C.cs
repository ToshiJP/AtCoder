using System;
using System.Numerics;

namespace ABC174.Problems
{
    class C
    {
        static void Main(string[] args)
        {
            //var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            //Console.SetOut(sw);

            //int k = int.Parse(Console.ReadLine());

            for (int k = 16; k < 100; k++) {
            if (k % 2 == 0)
            {
                Console.WriteLine("-1");
            }
            else
            {
                long i = 1;
                var x = new BigInteger(7);
                while (true)
                {
                    if (x % k == 0)
                    {
                        Console.WriteLine(i);
                        break;
                    }
                    x = x * 10 + 7;
                    i++;
                }
            }
            }
            //Console.Out.Flush();
        }
    }
}
