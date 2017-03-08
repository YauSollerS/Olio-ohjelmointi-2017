using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Kosti
    {
        public bool OnkoPaalla { get; set; }

        private bool AlkuTila = true;

        public bool Nollattu { get; set; }

        public int maxkosteus = 0;
        public int minkosteus = 0;
        private int kosteus = 0;

        public int Kosteus
        {
            get { return kosteus; }
            set
            {
                if (OnkoPaalla == true)
                {
                    if (Nollattu == true)
                    {
                        kosteus = 0;
                        maxkosteus = 0;
                        minkosteus = 0;
                        AlkuTila = true;
                    }
                    if (value > maxkosteus || maxkosteus == 0)
                    {
                        kosteus = value;
                        maxkosteus = value;
                    }
                    if (value < minkosteus || minkosteus == 0)
                    {
                        kosteus = value;
                        minkosteus = value;
                    }
                }


            }
             }
        public string AlkuMessage
        {
            get
            {
                if (AlkuTila==true)
                {
                    return "Kosti on alkutilassa, ei arvoja.";
                }
                else
                {
                    return "Kosti ei ole alkutilassa";
                }
            }
        }

        public string ToimiMessage
        {
            get
            {
                if (OnkoPaalla == true)
                {
                    return "Kosti on toiminnassa.";
                }
                else
                {
                    return "Kosti ei ole toiminnassa.";
                }
            }
        }
    
    }
}
