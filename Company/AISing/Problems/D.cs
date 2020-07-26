using System;
using System.Linq;
namespace AISing.Problems
{
    class D
    {
        static void Main()
        {
            int[] pc = new int[300000];
            for (int d = 0; d < pc.Length; d++)
            {
                int cnt = 0;
                int m = d;
                while (m != 0)
                {
                    if (m % 2 == 1) cnt++;
                    m /= 2;
                }
                pc[d] = cnt;
            }

            int n = int.Parse(Console.ReadLine());
            char[] cs = Console.ReadLine().ToCharArray();

            int pcX = cs.Count(c => c == '1');

            if (pcX == 1)
            {
                if (cs[n-1] == '1')
                {
                    for (int i = 0; i < n-1; i++)
                    {
                        Console.WriteLine(2);
                    }
                    Console.WriteLine(0);
                }
                else
                {
                    for (int i = 0; i < n-1; i++)
                    {
                        if (cs[i] == '1') Console.WriteLine(0);
                        else Console.WriteLine(1);
                    }
                    Console.WriteLine(2);
                }
            }
            else
            {
                int xModPcXp1 = 0;
                int xModPcXm1 = 0;
                foreach (var c in cs)
                {
                    xModPcXp1 = (xModPcXp1 * 2) % (pcX + 1);
                    xModPcXp1 = c == '1' ? (xModPcXp1 + 1) % (pcX + 1) : xModPcXp1;

                    xModPcXm1 = (xModPcXm1 * 2) % (pcX - 1);
                    xModPcXm1 = c == '1' ? (xModPcXm1 + 1) % (pcX - 1) : xModPcXm1;
                }
                int[] exp2ModPcXp1 = new int[n];
                int[] exp2ModPcXm1 = new int[n];
                exp2ModPcXp1[0] = 1 % (pcX + 1);
                exp2ModPcXm1[0] = 1 % (pcX - 1);
                for (int i = 1; i < n; i++)
                {
                    exp2ModPcXp1[i] = exp2ModPcXp1[i-1] * 2 % (pcX + 1);
                    exp2ModPcXm1[i] = exp2ModPcXm1[i-1] * 2 % (pcX - 1);
                }

                for (int i = 0; i < n; i++)
                {
                    int res = 1;
                    if (cs[i] == '0')
                    {
                        int y = (xModPcXp1 + exp2ModPcXp1[n-i-1]) % (pcX + 1) ;
                        while (y != 0)
                        {
                            res++;
                            y %= pc[y];
                        }
                    }
                    else
                    {
                        int y = (xModPcXm1 - exp2ModPcXm1[n-i-1]) % (pcX - 1);
                        y = (y + (pcX - 1)) % (pcX - 1);
                        while (y != 0)
                        {
                            res++;
                            y %= pc[y];
                        }
                    }
                    Console.WriteLine(res);
                }
            }
            Console.Out.Flush();
        }
    }
}
