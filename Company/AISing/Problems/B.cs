using System;
namespace AISing.Problems
{
    class B
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long res = 0;
            string[] inputs =  Console.ReadLine().Split(' ');
            for (int i = 1; i <= n; i++)
            {
                long a = long.Parse(inputs[i-1]);
                if (i % 2 == 1 & a % 2 == 1) res++;
            }
            Console.WriteLine(res);
        }
    }
}
