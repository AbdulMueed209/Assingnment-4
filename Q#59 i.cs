using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Q#59 (i)");
           int p=5;
           int q =9;
        int n = (q%2)*p +6*p*(q%3)+(q%4)*p*p*p;
            Console.WriteLine(n);
        }
    }
}
