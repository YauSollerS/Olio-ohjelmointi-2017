using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra04.T1

{
    class Hissi
    {
        private const int minFloor = 1;
        private const int maxFloor = 5;
        private int floor = 1;
        private bool isFloorValid;
        
        public int Floor
        {
            get { return floor; }
            set {
                
                if (value<minFloor)
                {
                    isFloorValid = false;
                }
                else if (value>maxFloor)
                {
                    isFloorValid = false;
                }
                else
                {
                    floor = value;
                    isFloorValid = true;
                }
            }
        }
        

        

        public string FloorMessage
        {
            get
            {
                if (isFloorValid==true)
                {
                    return "Valittu kerros " + floor;
                }
                else
                    return "Valittu kerros ei ole käytettävissä";
            }
        }
        
    }
}
