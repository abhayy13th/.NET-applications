using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week3
{
    internal class Swap
    {
        public void swap()
        {
            int a, b, temp;
            Console.WriteLine("Enter the value of a and b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before swapping a= {0} and b= {1}", a, b);
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swapping a= {0} and b= {1}", a, b);
        }
    }
}
