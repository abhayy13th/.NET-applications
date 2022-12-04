using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week4
{
    internal class Encapsulation
    {
        private string? StudentName;
        private int StudentPencil;


        public string Name //property
        {
            get { return StudentName; }
            set { StudentName = value; }
        }

        public int Pencil //property
        {
            get { return StudentPencil; }
            set { StudentPencil = value; }
        }
    }

    class EncapsulationClass
    {
        public static void CallEncapsulation()
        {
            Encapsulation encapsulation = new Encapsulation();
            encapsulation.Name = "Albin";
            encapsulation.Pencil = 25;

            Console.WriteLine($"Name = {encapsulation.Name}");
            Console.WriteLine($"Pencil = {encapsulation.Pencil}");
        }
    }
}

