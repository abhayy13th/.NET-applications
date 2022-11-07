using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week3
{
    internal class Search
    {
        public void search()
        {
            int[] arr = new int[100];
            int i, num, n, c = 0, pos = -1;
            Console.WriteLine("Enter the number of elements in array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array");
            for (i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter the element to be searched");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i < n; i++)
            {
                if (arr[i] == num)
                {
                    c = 1;
                    pos = i + 1;
                    break;
                }
            }
            if (c == 0)
                Console.WriteLine("{0} is not present in the array", num);
            else
                Console.WriteLine("{0} is present at position {1}", num, pos);
        }
        public void stringSearch()
        {
            string[] arr = new string[100];
            int i, n, c = 0, pos = -1;
            string str;
            Console.WriteLine("Enter the number of elements in array");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the elements of the array");
            for (i = 0; i < n; i++)
            {
                arr[i] = Console.ReadLine();
            }
            Console.WriteLine("Enter the element to be searched");
            str = Console.ReadLine();
            for (i = 0; i < n; i++)
            {
                if (arr[i] == str)
                {
                    c = 1;
                    pos = i + 1;
                    break;
                }
            }
            if (c == 0)
                Console.WriteLine("{0} is not present in the array", str);
            else
                Console.WriteLine("{0} is present at position {1}", str, pos);
        }
    }
}
