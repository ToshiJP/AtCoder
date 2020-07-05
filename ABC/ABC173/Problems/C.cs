using System;
namespace ABC173.Problems
{
    class C
    {
        static void Main()
        {
            string[] ss = Console.ReadLine().Split(' ');
            int h = int.Parse(ss[0]);
            int w = int.Parse(ss[1]);
            int k = int.Parse(ss[2]);
            char[][] field = new char[h][];
            for (int i = 0; i < h; i++)
            {
                field[i] = Console.ReadLine().ToCharArray();
            }
            int res = 0;
            for (int i = 0; i < 1 << h; i++) {
                for (int j = 0; j < 1 << w; j++) {
                    int cnt = 0;
                    for (int y = 0; y < h; y++) {
                        if ((i & (1 << y)) == 0) continue;
                        for (int x = 0; x < w; x++) {
                            if ((j & (1 << x)) == 0) continue;
                            if (field[y][x] == '#') cnt++;
                        }
                    }
                    if (cnt == k) res++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
