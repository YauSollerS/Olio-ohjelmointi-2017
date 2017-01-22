using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Hissi
    {
        private int floor = 1;
        public int Floor
        {
            get { return floor; }
            set
            {
                if (value >=1 && value <=5)
                {
                    floor = value;
                }
                
               
            }
        }
    }
}
