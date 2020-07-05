using System;
namespace ABC173.Problems
{
    class B
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            int[] cnt = new int[] {0, 0, 0, 0};
            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                switch (str)
                {
                    case "AC":
                        cnt[0]++;
                        break;
                    case "WA":
                        cnt[1]++;
                        break;
                    case "TLE":
                        cnt[2]++;
                        break;
                    case "RE":
                        cnt[3]++;
                        break;
                }
            }
            Console.WriteLine("AC x " + cnt[0]);
            Console.WriteLine("WA x " + cnt[1]);
            Console.WriteLine("TLE x " + cnt[2]);
            Console.WriteLine("RE x " + cnt[3]);
        }
    }
}
