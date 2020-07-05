using System;
namespace ABC173.Problems
{
    class A
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(1000 * ((n - 1) / 1000 + 1) - n) ;
        }
    }
}
