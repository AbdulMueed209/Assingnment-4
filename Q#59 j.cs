using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q#59 (j)");
          int n =3, a=6, b=2;
          n*=a+b;
          a--;
          n%=a;
            Console.WriteLine(n);
        }
    }
}
