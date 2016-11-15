﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    class ComputerObject
    {
        public enum PC_TYPE { WINDOWS, MAC, LINUX};
        PC_TYPE ptype;

        double cost = 0;
        public ComputerObject()
        {
        }
        public void setCost(double cost)
        {
            this.cost = cost;
        }
        public double getCost()
        {
            return cost;
        }
        public void setType(PC_TYPE type)
        {
            ptype = type;
        }
        public PC_TYPE getType()
        {
            return ptype;
        }
        public String printContent()
        {
            String message = "PC Type: " + ptype + " Cost: " + cost;
            return message;
        }
    }
}
