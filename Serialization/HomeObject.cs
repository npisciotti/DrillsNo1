using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class HomeObject
    {
        int yearBuilt = 0;
        public enum TYPE { SINGLE_FAMILY, TOWNHOME, CONDO };
        TYPE htype;
        public HomeObject()
        {
        }
        public void setYear(int year)
        {
            yearBuilt = year;
        }
        public int getYear()
        {
            return yearBuilt;
        }
        public TYPE getHomeType()
        {
            return htype;
        }
        public void setHomeType(TYPE type_)
        {
            htype = type_;
        }
        public String printContent()
        {
            String message = "Hometype: " + htype + " Year Built: " + yearBuilt;
            return message; 
             
        }
    }
}
