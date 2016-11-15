using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

delegate int TestingDelegate(int test1);
namespace DelegateAndMulticastDelegate
{
    class TestThatDelegate
    {
        static int num = 50;
        public static int mult(int x)
        {
            num *= x;
            return num;
        }
        public static int add(int y)
        {
            num *= y;
            return num;
        }
        public static int getNum()
        {
            return num;
        }


        static void Main(string[] args)
        {
            TestingDelegate td;
            TestingDelegate td1 = new TestingDelegate(mult);
            TestingDelegate td2 = new TestingDelegate(add);


            td1(10);
            Console.WriteLine("Value of Num at td1: {0}", getNum());
            td2(10);
            Console.WriteLine("Value of Num at td2: {0}", getNum());

            td = td1;
            td += td2;

            Console.WriteLine("Value of Num at td: {0}", getNum());
            
        }
    }
}
