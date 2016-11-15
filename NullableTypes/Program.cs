using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;

            if(num1.HasValue)
            {
                Console.WriteLine("The value of num1 is {0}", num1.Value);
            }
            else
            {
                Console.WriteLine("num1 is Null!");
            }

        }
    }
}
