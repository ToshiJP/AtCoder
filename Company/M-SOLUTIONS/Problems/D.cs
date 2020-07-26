using System;
namespace MSOLUTIONS.Problems
{
    class D
    {
        static void Main()
        {
            var sw = new System.IO.StreamWriter(Console.OpenStandardOutput()) { AutoFlush = false };
            Console.SetOut(sw);

            var n = int.Parse(Console.ReadLine());
            var inputs = Console.ReadLine().Split(" ");
            var a = new long[n];
            for (var i = 0; i < n; i++)
            {
                a[i] = long.Parse(inputs[i]);
            }

            var money = 1000L;
            var stock = 0L;
            var flag = true;
            for (var i = 0; i < n - 1; i++)
            {
                if (flag)
                {
                    // 極小値探索
                    if (a[i] < a[i+1])
                    {
                        // a[i]は極小値のため、株を購入
                        stock += money / a[i];
                        money -= a[i] * (money / a[i]);
                        flag = false;
                    }
                }
                else
                {
                    // 極大値探索
                    if (a[i] > a[i+1])
                    {
                        // a[i]は極大値のため、株を売却
                        money += a[i] * stock;
                        stock = 0;
                        flag = true;
                    }
                }
            }
            money += a[n-1] * stock;
            Console.WriteLine(money);
            Console.Out.Flush();
        }
    }
}
