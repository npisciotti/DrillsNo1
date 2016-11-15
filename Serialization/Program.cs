using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Serialize sdata = new Serialize("testBinaryFile.txt");
            HomeObject ho = new HomeObject();
            ho.setHomeType(HomeObject.TYPE.CONDO);
            ho.setYear(2016);
            ComputerObject co = new ComputerObject();
            co.setType(ComputerObject.PC_TYPE.LINUX);
            co.setCost(0.1);
            ComputerObject col = new ComputerObject();
            col.setType(ComputerObject.PC_TYPE.MAC);
            col.setCost(99.99);

            sdata.SerializeObject(ho);
            sdata.SerializeObject(co);
            sdata.SerializeObject(col);

            sdata.closeStream();

            sdata.DeserializeObjects();
            sdata.closeStream();
        }
    }
}
