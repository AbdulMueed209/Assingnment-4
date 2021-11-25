using System;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q#53 (b)");
            int x = 10 , y = 15;
            x= x++;
            y=++y;
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
