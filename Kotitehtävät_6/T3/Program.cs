using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Toteuta ohjelma, joka tallentaa kaikki korttipelin kortit (hertta, ruutu, risti ja pata. Numerot 1-52.) valitsemaasi 
/// tietorakenteeseen ja tulostaa tietorakenteen sisällön. Bonustehtävä: kuinka voisit toteuttaa korttipakan sekoittamisen?
/// </summary>
/// 

namespace T3
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck kortit = new Deck();

            for (int i=0; i<13; i++)
            {
                kortit.AddCard(new Card("Club", i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                kortit.AddCard(new Card("Diamond", i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                kortit.AddCard(new Card("Heart", i + 1));
            }
            for (int i = 0; i < 13; i++)
            {
                kortit.AddCard(new Card("Spade", i + 1));
            }
            for (int i=0; i< kortit.CardsList.Count;i++)
            {
                Console.WriteLine((i+1)+" kortti on "+kortit.CardsList[i]);
                         
            }

            Console.WriteLine("Korttipakkasi on sekoitettu: ");
            kortit.Shuffle();
            for (int i = 0; i < kortit.ShuffleCards.Count; i++)
            {
                Console.WriteLine((i + 1) + " kortti on " + kortit.ShuffleCards[i]);

            }
        }
    }
}
