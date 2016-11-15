using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class Program
    {
        enum Chores { Clean, Laundry, Cook, Study };
        static void Main(string[] args)
        {

            int fun = (int)Chores.Study;
            int alsoFun = (int)Chores.Cook;
            Console.WriteLine("Study is at location: {0}", fun);
            Console.WriteLine("Cook is at location: {0}", alsoFun);


        }
    }
}
