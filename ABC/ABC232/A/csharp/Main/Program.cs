using System;

namespace ABC232
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            Console.WriteLine(int.Parse(s[0].ToString()) * int.Parse(s[2].ToString()));
        }
    }
}
