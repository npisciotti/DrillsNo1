using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierInternalTest
{
    //Internal class. You cannot access this class from the Program.cs in another project because the class is internal to this project.
    internal class InternalTesting
    {
        public static int internalTest = 100;
    }
    //Public class. This class can be accessed through another project, but the internal members of this class cannot be accessed.
    public class PublicTesting
    {
        internal static int cantTouch = 200;
        public static int canTouch = 201;
    }

    //Protected Internal
    public class ProtectedInternal
    {
        protected internal int protectInternal = 500;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Protected Internal
            ProtectedInternal interally = new ProtectedInternal();
            Console.WriteLine("We can print out the protected internal members in the same project: {0}", interally.protectInternal);

        }
    }
}
