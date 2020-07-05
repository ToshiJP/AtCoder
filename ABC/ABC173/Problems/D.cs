using System;
namespace ABC173.Problems
{
    class D
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split(' ');
            long[] a = new long[n];
            for (long j = 0; j < n; j++) {
                a[j] = long.Parse(s[j]);
            }
            Array.Sort(a);
            long res = a[n-1];
            long i = n - 2;
            int two = 0;
            for (long cnt = 0; cnt < n - 2; cnt++) {
                res += a[i];
                two++;
                if (two == 2) {
                    two = 0;
                    i--;
                }
            }
            Console.WriteLine(res);
        }
    }
}
