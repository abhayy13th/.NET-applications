using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week4
{

    public class Bird
    {

        public string? name;

        public void display()
        {
            Console.WriteLine("I am a Bird");
        }
    }
    public class Eagle : Bird
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }

    public class Testing
    {
        public static void Test()
        {

            Eagle eagle = new Eagle();
            eagle.display();

            eagle.getName();
        }
    }


}
