using System;
namespace AISing.Problems
{
    class C
    {
        static void Main()
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);
            long n = long.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                long res = 0;
                for (int x = 1; x*x <= i; x++)
                {
                    for (int y = x; y*y <= i; y++)
                    {
                        for (int z = y; z*z <= i; z++)
                        {
                            if (x*x + y*y + z*z + x*y + y*z + z*x == i)
                            {
                                if (x == y & y == z)
                                {
                                    res += 1;
                                }
                                else if (x == y | y == z)
                                {
                                    res += 3;
                                }
                                else
                                {
                                    res += 6;
                                }
                            }
                        }
                    }
                }
                Console.WriteLine(res);
            }
            Console.Out.Flush();
        }
    }
}
