using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Week4
{
    internal class Polymorphism
    {
        public void Wake(int w) //Method overloading
        {
            Console.WriteLine("Wake up Kid");
        }

        public void Wake(int w, string dream) //method overloading
        {
            Console.WriteLine(dream);
        }

        public void Wake(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Wake(string a, string b)
        {
            Console.WriteLine(a + b);
        }


        // Base Class
        public virtual void Poly() //method overriding
        {
            Console.WriteLine("This is base class.");
        }

    
        // Derived Class
        public class DerivedClass : Polymorphism
        {
            public override void Poly() //method overriding
            {
                Console.WriteLine("This is derived class.");
            }
        }
        
        public class PolyClass
        {
            public static void PolynMethod()
            {
                DerivedClass d = new DerivedClass();
                d.Poly();
                Polymorphism polymorphism = new Polymorphism();
                polymorphism.Poly();
                
                polymorphism.Wake(4);
                polymorphism.Wake(5,"Wake me up when september ends");
                polymorphism.Wake(10, 3);
                polymorphism.Wake("Wake", "up");
            }
        }
    }
}


