using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Vahvistin
    {
        private const int minVolume = 0;
        private const int maxVolume = 100;
        private int volume;
        private int isVolumeValid;

        public int Volume
        {
            get { return volume; }
            set
            {

                if (value > maxVolume)
                {
                    isVolumeValid = 1;
                    volume = maxVolume;
                }
                else if (value < minVolume)
                {
                    isVolumeValid = 2;
                    volume = minVolume;
                }
                else
                {
                    isVolumeValid = 3;
                    volume = value;
                    
                }
            }
        }




        public string VolumeMessage
        {
            get
            {
                if (isVolumeValid == 1)
                {
                    return "Too much volume -  Amplifier volume is set to maximum : " + volume;
                }
                else if (isVolumeValid == 2)
                {
                    return "Too low volume - Amplifier volume is set to minimum : " + volume;
                }
                else
                {
                    return "Amplifier volume is set to :" + volume;
                }
            }
        }

    }
}
