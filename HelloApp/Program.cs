using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // go to https://www.youtube.com/watch?v=a_kh1JJCNMQ 
            Console.WriteLine("Another change hopes it gets pushed!");
            Console.WriteLine("Denne ændring kun på FirstBranch, håber at kunne merge i GitHub og slette denne branch...");
        }
    }

    public class A
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }
    }
}
