using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass
{
    class Size
    {

        public void setHeight(int h)
        {
            height = h;
        }
        public void setWidth(int w)
        {
            width = w;
        }
        protected int height;
        protected int width;
    }
    // Shape class derives all items from the Size class. The variables and functions are inherited.
    class Shape : Size
    {
        public int getAreaOfRect()
        {
            return (width * height);
        }
        public double getAreaOfTri()
        {
            return ((width * height) * .5);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Shape Object = new Shape();
            Object.setHeight(10);
            Object.setWidth(20);

            Console.WriteLine("Total Area of Rectangle : {0}", Object.getAreaOfRect());
            Console.WriteLine("Total Area of Triangle : {0}", Object.getAreaOfTri());
        }
    }
}
