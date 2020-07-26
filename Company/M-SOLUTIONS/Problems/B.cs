using System;
namespace MSOLUTIONS.Problems
{
    class B
    {
        static void Main()
        {
            string[] inputs = Console.ReadLine().Split(" ");
            int red   = int.Parse(inputs[0]); // read
            int green = int.Parse(inputs[1]); // green
            int blue  = int.Parse(inputs[2]); // blue
            int k = int.Parse(Console.ReadLine());
            // green > red && blue > green
            for (var i = 0; i < k; i++)
            {
                if (green <= red)
                {
                    green *= 2;
                }
                else if (blue <= green)
                {
                    blue *= 2;
                }
            }
            if (green > red && blue > green)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
