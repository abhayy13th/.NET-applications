using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week3
{
    internal class OddEven
    {
        public void odd_even()
        {
            int num;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine("{0} is an even number", num);
            else
                Console.WriteLine("{0} is an odd number", num);
        }
    }
}
