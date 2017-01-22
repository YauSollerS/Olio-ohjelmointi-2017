using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5
{
    class Radio
    {
        public bool OnkoPaalla { get; set; }
        private readonly int maxvolume = 9;
        private readonly int minvolume = 0;

        private readonly float maxherz = 26000.0F;
        private readonly float minherz = 2000.0F;

        private int volume;
        private float herz;
        
        public int Volume
        {
            get { return volume; }
            set
            {
                if (OnkoPaalla == true)
                {
                    if (value >= minvolume && value <= maxvolume)
                        volume = value;
                    else if (value > maxvolume)
                    {
                        volume = maxvolume;
                        

                    }
                    else
                    {
                        volume = minvolume;
                       
                    }
                }
                else
                    volume = 0;
            }
        } 

        public float Herz
        {
            get { return herz; }
            set
            {
                if (OnkoPaalla == true)
                {
                    if (value >= minherz && value <= maxherz)
                        herz = value;
                    else if (value > maxherz)
                    {
                        herz = maxherz;
                        

                    }
                    else
                    {
                        herz = minherz;
                        
                    }
                }
                else
                    herz = 0;
            }
        }
    }
}
