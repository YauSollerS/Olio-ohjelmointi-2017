using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3
{
    class Card
    {
        public string Suit { get; set; }
        public int Number { get; set; }

        public Card(string suit, int nbr)
        {
            Suit = suit;
            Number = nbr;
        }

        public override string ToString()
        {
            return Suit + "#" + Number;
        }
    }

    class Deck
    {
        private List<Card> cards;

        public List<Card> ShuffleCards;

        public List<Card> CardsList
        {
            get { return cards; }
        }

        public Deck()
        {
            cards = new List<Card>();
            ShuffleCards = new List<Card>();
        }

        public void AddCard(Card kortti)
        {
            cards.Add(kortti);
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            ShuffleCards = CardsList.OrderBy(item => rnd.Next()).ToList();
        }
    }

    
}
