using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q#58 (i)");
            int a = 2, b=3, c=5;
            b=a++ + b++ ;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
