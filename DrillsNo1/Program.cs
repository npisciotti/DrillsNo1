using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingVsOverriding
{
    // Function Overloading
    class Overloading
    {
        int addSomething(int a, int b)
        {
            return a + b;
        }
        int addSomething(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {
            Overloading total = new Overloading();
            Console.WriteLine("I will add 2 + 4");
            Console.WriteLine("The total is " + total.addSomething(2, 4));
            Console.WriteLine("I will add 2 + 4 + 6");
            Console.WriteLine("The total is " + total.addSomething(2, 4, 6));

            OverridingParent parent = new OverridingParent();
            parent.ex1();
            OverridingChild child = new OverridingChild();
            child.ex1();  
        }
    }
    //Class Overriding
    public class OverridingParent  
    {
        public virtual void ex1()
        {
            Console.WriteLine("This is a sentence from the Parent");
        }
    }
    public class OverridingChild : OverridingParent
    {
        public override void ex1()
        {
            Console.WriteLine("This is a sentence from the Child");
        }
    }
}
