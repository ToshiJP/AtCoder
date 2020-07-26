using System;
namespace AISing.Problems
{
    class A
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(' ');
            int l = int.Parse(inputs[0]);
            int r = int.Parse(inputs[1]);
            int d = int.Parse(inputs[2]);

            int ll = l / d;
            int rr = r / d;
            if (l % d == 0)
            {
                Console.WriteLine(rr - ll + 1);
            }
            else
            {
                Console.WriteLine(rr - ll);
            }
        }
    }
}
