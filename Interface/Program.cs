using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Transactions
    {
        void getPerson();
        double getAmount();
    }
    public class Data : Transactions
    {
        public double getAmount()
        {
            return 10.00;
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
            Data foo = new Data();
            foo.getPerson();
        }

    }

}
