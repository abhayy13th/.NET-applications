using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week2
{
    internal class ControlStatements
    {
        public void CS()
        {
            Console.WriteLine("Enter 2 numbers");

            Console.WriteLine("Insert a number 1:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert a number 2:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"{a} > {b}");
            }
            else
            {
                Console.WriteLine($"{a} < {b}");
            }
        }
        public void switchcase()
        {
            Console.WriteLine("Choose from 1 - 4");
            var s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    Console.WriteLine("Apple");
                    break;
                case "2":
                    Console.WriteLine("Orange");
                    break;
                case "3":
                    Console.WriteLine("Pineapple");
                    break;
                case "4":
                    Console.WriteLine("Grape");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;

            }
        }
        public void whileloop()
        {
            Console.WriteLine("Number of repeattations:");
            int w = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i < w)
            {
                i++;
                Console.WriteLine(i);
                
            }
        }
        public string doLoop()
        {
            string? password;
            string secretPassword = "1234";
            do
            {
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
            }
            while (password != secretPassword);
            return password;
        }
        public void forExample()
        {
            string[] names = { "Billy","Jean","Georgia" };
            
            for (int i = 0; i < names.Length; i++)
                {
                Console.WriteLine(names[i]);
                }
        }
        public void forEachExample()
        {
            string[] names = { "Laney","Haley","Marshall" };

            foreach (string s in names)
            {
                Console.WriteLine(s);
            }
        }
    }
}
