using System;

class Program
{
    static void Main(string[] args)
    {
        var s = Console.ReadLine();
        var a = s[0] - '0';
        var b = s[1] - '0';
        var c = s[2] - '0';
        // abc + bca + cab
        // = 100a + 10b + c + 100b + 10c + a + 100c + 10a + b
        // = 100(a + b + c) + 10(a + b + c) + (a + b + c)
        // = (a + b + c) * (100 + 10 + 1)
        Console.WriteLine((a + b + c) * 111);
    }
}
