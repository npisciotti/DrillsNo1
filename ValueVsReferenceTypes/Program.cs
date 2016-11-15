using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueVsReferenceTypes
{
    //Reference types are called that because the variable assigned to them hold the memory location of the value. A pointer.
    class ReferenceType
    {
        string a = "Hello";
        int[] array1 = { 1, 2, 3, 4, 5 };
    }
    //Value types have the variable actually hold the value assigned to them in their memory location.
    class ValueType
    {
        int b = 10;
        bool c = true;
        char d = 'c';
        double e = 3.45623;

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
