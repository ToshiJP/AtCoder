using System;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine();
        var t = Console.ReadLine();
        var k = (t[0] - s[0] + 26) % 26;
        for (int i = 1; i < s.Length; i++)
        {
            if (k != (t[i] - s[i] + 26) % 26)
            {
                Console.WriteLine("No");
                return;
            }
        }
        Console.WriteLine("Yes");
    }
}
