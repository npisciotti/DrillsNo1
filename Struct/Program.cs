using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    struct Car
    {
        public string engine;
        public string type;
        public string weight;
    };
    class Program
    {

        static void Main(string[] args)
        {
            Car LandCruiser;
            Car Huarya;

            LandCruiser.engine = "4.0 V8";
            LandCruiser.type = "SUV";
            LandCruiser.weight = "2500kg";

            Huarya.engine = "6.2 V12";
            Huarya.type = "Hypercar";
            Huarya.weight = "1500kg";

            Console.WriteLine("LandCruiser- Engine: {0}, Type: {1}, Weight: {2}", LandCruiser.engine, LandCruiser.type, LandCruiser.weight);
            Console.WriteLine("Huarya- Engine: {0}, Type: {1}, Weight: {2}", Huarya.engine, Huarya.type, Huarya.weight);
        }
    }
}
