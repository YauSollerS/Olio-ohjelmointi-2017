using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Lompakko
    {
        public int Raha { get; set; }

        private List<Card> cards;

        public List<Card> Cardlista
        {
            get { return cards; }
        }
        public Lompakko( int raha)
        {
            Raha = raha;
            cards = new List<Card>();
        }

        public void LisaaKortti(Card ca)
        {
            cards.Add(ca);
        }

        public override string ToString()
        {
            return  + Raha + "euro"  ;
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
