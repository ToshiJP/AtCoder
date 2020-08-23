using System;
using System.Collections.Generic;

namespace ABC176.Problems
{
    class D
    {
        static void Main()
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            const int INF = 1000000000;

            string[] ss1 = Console.ReadLine().Split(" ");
            string[] ss2 = Console.ReadLine().Split(" ");
            string[] ss3 = Console.ReadLine().Split(" ");
            int h = int.Parse(ss1[0]);
            int w = int.Parse(ss1[1]);
            int srcH = int.Parse(ss2[0]) - 1;
            int srcW = int.Parse(ss2[1]) - 1;
            int dstH = int.Parse(ss3[0]) - 1;
            int dstW = int.Parse(ss3[1]) - 1;
            char[][] maze = new char[h][];
            for (int i = 0; i < h; i++)
            {
                maze[i] = Console.ReadLine().ToCharArray();
            }
            int[,] dist = new int [h,w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    dist[i,j] = INF;
                }
            }
            int[] dy = {-1, 0, 0, 1};
            int[] dx = {0, -1, 1, 0};

            Queue<(int, int)> queue  = new Queue<(int, int)>();
            Queue<(int, int)> queue2 = new Queue<(int, int)>();
            int num = 0;

            queue.Enqueue((srcH, srcW));
            dist[srcH,srcW] = num;
            while (queue.Count != 0)
            {
                while (queue.Count != 0)
                {
                    (int y, int x) = queue.Dequeue();
                    queue2.Enqueue((y, x));
                    for (int i = 0; i < 4; i++)
                    {
                        (int ny, int nx) = (y + dy[i], x + dx[i]);
                        if (ny >= 0 && ny < h && nx >= 0 && nx < w && maze[ny][nx] != '#' && dist[ny,nx] == INF)
                        {
                            queue.Enqueue((ny, nx));
                            dist[ny,nx] = num;
                        }
                    }
                }
                num++;
                while (queue2.Count != 0)
                {
                    (int i, int j) = queue2.Dequeue();
                    for (int ii = -2; ii <= 2; ii++)
                    {
                        for (int jj = -2; jj <= 2; jj++)
                        {
                            (int ny, int nx) = (i + ii, j + jj);
                            if (ny >= 0 && ny < h && nx >= 0 && nx < w && maze[ny][nx] != '#' && dist[ny,nx] == INF)
                            {
                                queue.Enqueue((ny, nx));
                                dist[ny,nx] = num;
                            }
                        }
                    }
                }
            }

            // for (int i = 0; i < h; i++)
            // {
            //     for (int j = 0; j < w; j++)
            //     {
            //         Console.Write(dist[i,j] == INF ? "#" : $"{dist[i,j]}");
            //     }
            //     Console.WriteLine();
            // }

            Console.WriteLine(dist[dstH,dstW] == INF ? -1 : dist[dstH,dstW]);
            Console.Out.Flush();
        }
    }
}
