using AccessModifierInternalTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{


    //Public: All objects in PublicTest are accessing through the main function.
    class PublicTest
    {
        public int test1 = 10;
        public int test2 = 5;
    }



    //Protected: The members of the Parent class are accessible only by going through the Child class.
    class Parent
    {
        protected int x = 10;
        protected int y = 20;
    }
    class Child : Parent
    {
        // Must make this method public so that is could be printed and compiled in Main()
        public static void Testing()
        {
        Child newest = new Child();
        int addIt1 = newest.x + newest.y;
        Console.WriteLine("Adding both protected integers: {0}", addIt1);
        }
    }


    //Private:
    class PrivateTest
    {
        //Private members cannot be used outside of the PrivateTest class. And, they can only be accessed using member methods in PrivateTest.
        private int money = 1000;
        private string person = "Jimbo";

        public int getMoney
        {
            get { return money; }
        }
        public string getPerson
        {
            get { return person; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Public
            PublicTest test = new PublicTest();
            int addIt = test.test1 + test.test2;
            int subtractIt = test.test1 - test.test2;
            Console.WriteLine("Addition: {0}", addIt);
            Console.WriteLine("Difference: {0}", subtractIt);

            //Protected
            Child.Testing();

            //Private
            PrivateTest priv = new PrivateTest();
            Console.WriteLine("This person named {0} has won {1} dollars!", priv.getPerson, priv.getMoney);

            //Internal 
            /* InternalTesting class inaccessible due to internal permissions,
            InternalTesting internal1 = new InternalTesting(); */


            // PublicTesting class is accessible because it is public.
            PublicTesting public1 = new PublicTesting();

            //PublicTesting.cantTouch cannot be accessed because it is an internal member. PublicTesting.canTouch can be accessed because it is public.
            //Console.WriteLine("We cannot access cantTouch: {0}", PublicTesting.cantTouch);
            Console.WriteLine("We can access canTouch: {0}", PublicTesting.canTouch);

            //Protected
            ProtectedInternal place = new ProtectedInternal();
            //Protected Internal member from another project cannot be accessed.
            //place.protectInternal;



        }
}
}
