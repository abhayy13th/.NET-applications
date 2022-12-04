using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week4
{
    abstract class Abstraction
    {
        public abstract string Student();
    }

    class PencilData : Abstraction 
    {
        private int pencil;

        public PencilData(int x = 0)
        {
            pencil = x;
        }

        public override string Student() //overriding 
        {
            Console.WriteLine("The number of pencils the student has is: ");
            return ($"{pencil}");
        }
    }

    class CallAbstraction
    {
        public static void AbstractionCall()
        {
            PencilData abstraction = new PencilData(37); 

            string result = abstraction.Student();
            Console.WriteLine(result);

        }
    }
}

