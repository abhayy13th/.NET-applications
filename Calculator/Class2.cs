using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Class2
    {
        public void addition()
        {


            Console.WriteLine("Insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var substract = number1 - number2;
            Console.WriteLine("Result: " + substract);

        }
    }
}
