using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calc
    {
        public void addition()
        {
            

            Console.WriteLine("Insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var addition = number1 + number2;
            Console.WriteLine("Result: " + addition);

        }

        public void substraction()
        {


            Console.WriteLine("Insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var substract = number1 - number2;
            Console.WriteLine($"Result:  {substract}");

        }

        public void multiplication()
        {


            Console.WriteLine("Insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var multiply = number1 * number2;
            Console.WriteLine($"Result:  {multiply}");

        }
        public void division()
        {


            Console.WriteLine("Insert a number 1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number 2:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var divide = number1 / number2;
            Console.WriteLine($"Result:  {divide}");

        }
    }

}
    