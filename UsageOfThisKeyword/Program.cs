using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageOfThisKeyword
{
    class Test
    {
        private string name;
        private string words;
        public Test(string name, string words)
        {
            this.name = name;
            this.words = words;
        }
        public void printTest()
        {
            Console.WriteLine("This is the name variable: {0}, This is the words variable: {1}", name);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Test ptr = new Test("Hello", "These are words");
            ptr.printTest();
        }
    }
}
