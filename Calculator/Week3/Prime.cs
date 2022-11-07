using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week3
{
    internal class Prime
    {

        public void prime()
        {
            int num, i, count = 0;
            Console.WriteLine("Enter a number");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0 && num != 1)
                Console.WriteLine("{0} is a prime number", num);
            else
                Console.WriteLine("{0} is not a prime number", num);
        }
    }
}

