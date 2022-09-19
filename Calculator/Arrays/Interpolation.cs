using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Arrays
{
    internal class Interpolation
    {
        public void StringInterpolation()
        {
            Console.WriteLine("Insert group name :");
            string? groupName = Console.ReadLine();

            Console.WriteLine("Insert first name :");
            string? firstName = Console.ReadLine();

            Console.WriteLine("Insert last name :");
            string? lastName = Console.ReadLine();

            Console.WriteLine($"Hello {groupName}, My name is {firstName} {lastName}.");
        }
    }
}
