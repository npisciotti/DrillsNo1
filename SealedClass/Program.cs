using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClass
{
    sealed class X
    {
        public int num1 = 10;
        public int num2 = 100;
    }
    //Class M cannot inherit from class X because class X is sealed.
    //class M : X
    //{
    //}

    class Program
    {
        static void Main(string[] args)
        {
            X newx = new X();
            newx.num1 = 100;
            newx.num2 = 1000;
            Console.WriteLine("num1 = {0}, num2 = {1}", newx.num1, newx.num2);
        }
    }
}
