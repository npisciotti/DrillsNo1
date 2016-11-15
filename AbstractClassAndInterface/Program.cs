using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAndInterface
{
    // Abstract classes can contain code bodies and definitions.
    abstract class test1
    {
        public int add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
    class Child : test1
    {
        public int mul(int num1, int num2)
        {
            return num1 * num2;
        }
    }
    // Interfaces cannot contain code bodies and definitions.
    public interface Transactions
    {
        void getPerson();
        double getAmount();
    }
    public class Data : Transactions
    {
        public double getAmount()
        {
            return 10;
        }
        public void getPerson()
        {
            Console.WriteLine("Daisy bought a meal worth {0}", getAmount());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Abstract
            Child cd = new Child();
            int sum = cd.add(10, 100);
            int product = cd.mul(10, 100);
            Console.WriteLine("Add: {0}, Multiply: {1}", sum, product);

            // Interface
            Data foo = new Data();
            foo.getPerson();

        }
    }
}
