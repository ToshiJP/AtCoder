using System;
namespace MSOLUTIONS.Problems
{
    class A
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int rating = 0;
            if (x >= 400 && x < 600)
            {
                rating = 8;
            }
            else if (x >= 600 && x < 800)
            {
                rating = 7;
            }
            else if (x >= 800 && x < 1000)
            {
                rating = 6;
            }
            else if (x >= 800 && x < 1000)
            {
                rating = 6;
            }
            else if (x >= 1000 && x < 1200)
            {
                rating = 5;
            }
            else if (x >= 1200 && x < 1400)
            {
                rating = 4;
            }
            else if (x >= 1400 && x < 1600)
            {
                rating = 3;
            }
            else if (x >= 1600 && x < 1800)
            {
                rating = 2;
            }
            else if (x >= 1800 && x < 2000)
            {
                rating = 1;
            }
            else
            {
                // Nothing
                ;
            }
            Console.WriteLine(rating);
        }
    }
}
