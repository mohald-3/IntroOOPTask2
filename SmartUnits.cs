using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
     public abstract class SmartUnits
    {
        public abstract int unitID;
        public abstract string unitName;
        public abstract string unitType;
        public abstract List<string> pairedDevices;
        public abstract List<string> unitShedule;

        public void Switch() 
        { 
                
        }
        public void PairUnit()
        {

        }
        public void FactoryReset()
        {

        }

}
}
