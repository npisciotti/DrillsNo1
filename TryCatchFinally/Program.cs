using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            name:

            try
            {
                int num1, num2, result;
                
                Console.WriteLine("Enter two numbers. The first one will be divided by the second one.");
                num1 = Convert.ToInt32(Console.ReadLine());
                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 / num2;
                Console.WriteLine("The result in interger form is: {0}", result.ToString());
            }
            catch (DivideByZeroException zero)
            {
                Console.WriteLine("You cannot divide by Zero. Below are details. \n" + zero.ToString() + "\n\n");
                goto name;
            }
            catch (FormatException form)
            {
                Console.WriteLine("You have entered an invalid number. Below are details. \n" + form.ToString() + "\n\n");
                goto name;
            }
            finally
            {
                Console.WriteLine("To use again, press Enter. To exit, press Ctrl + C");
                Console.ReadLine();
            }
            
        }
    }
}
