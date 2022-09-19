using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Arrays
{
    internal class Arrays
    {
        public void JaggedArray()
        {
            int[][] jagged = new int[][]
            {
                new int[] {1, 2, 3, 4},
                new int[] {13, 31, 69},
                new int[] {255,666,333,1000 }
                
            };

            Console.WriteLine("Jagged Array");
            for (int i=0; i < jagged.Length; i++)
            {
                for (int j = 0; j < jagged[i].Length; j++)
                {
                    Console.Write(jagged[i][j]);
                    Console.Write("\t");
                }
                Console.WriteLine("\n");
            }
            
        }
        public void OneDArray()
        {
            int[] arrayNumber = { 1,4,6,9,13,24 };
            string[] week = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

            arrayNumber[2] = 2;

            Console.WriteLine(arrayNumber);
            Console.WriteLine(week);
        }

        public void MultiDArray()
        {
            int[,] numbers = { { 13, 76 }, { 69, 42} };

            Console.WriteLine("Before at index [1,1] : " + numbers[1,1]);


            Console.WriteLine("Enter a number:");
            int newNumber = Convert.ToInt32(Console.ReadLine());
            numbers[1, 1] = newNumber; 

            // new element
            Console.WriteLine("After at index [1,1] : " + numbers[1,1]);
        }

        public void ImplicitArray()
        {
            var names = new[] { "Tony","Achilles","Vanguard","Tree" };

            
           names[3] = "Eklavya";

            Console.WriteLine($"List of names is: {names[3]}");
        }

    }
}

