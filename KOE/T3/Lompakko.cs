using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Lompakko
    {
        private int raha = 0;
        
        
        
                    
        
        public int Raha
        {
            get { return raha; }
            set
            {

                if (value>=0)
                {
                    
                    
                    raha = value;

                    
                }
                                
            }
        }


        
        private List<Card> cards;

        public List<Card> Cardlista
        {
            get { return cards; }
        }
        public Lompakko( )
        {
            Raha = raha;
            cards = new List<Card>();
        }

        public void LisaaKortti(Card ca)
        {
            cards.Add(ca);
            
        }

        public void PoistaKortti (Card ka)
        {
            cards.Remove(ka);
        }
        public void LisaaRaha(int lisa)
        {
            raha = raha + lisa;
            Console.WriteLine("Lompakkoon lisätty rahaa: " + lisa + " euroa");
        }

        public void OttaaRaha(int otto)
        {
            
            if (raha >= otto)
            {
                raha = raha - otto;
                Console.WriteLine("Lompakosta otettu rahaa: " + otto + " euroa");
            }
            else
            {
                Console.WriteLine("Lompakosta yritetty ottaa rahaa: " + otto + " euroa" + "\nLompakossa on vain " + Raha + " euroa. Otto ei onnistu!");
            }
        }

        public void Alustettu()
        {
            raha = 0;
            Cardlista.Clear();

            Console.WriteLine("Lompakko alustettu.");

        }


        public override string ToString()
        {
            string lause = "\nLompakon sisältö: \n- rahaa:"+Raha + " euroa"+"\n- kortit:";

            foreach (Card k in Cardlista)
            {
                lause += "\n" + k.ToString();
            }

            return  lause;
        }

        

        
    }

    

    class Card
    {
        public string Nimi { get; set; }
        public string Numero { get; set; }
        public string Owner { get; set; }

        public Card (string nimi, string num, string own)
        {
            Nimi = nimi;
            Numero = num;
            Owner = own;

        }

        
        public override string ToString()
        {
            return Nimi + " " + Numero +" " + Owner;
        }
    }
}
