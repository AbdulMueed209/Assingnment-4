using System;

namespace Q_53
{
    class Program
    {
        static void Main(string[] args)
        {Console.WriteLine("Q#53 (a) ");
        int x =20 , y =35;
        x=y++ + x++;
        y = ++y + ++x;
            Console.WriteLine(x);
             Console.WriteLine(y);
        }
    }
}
