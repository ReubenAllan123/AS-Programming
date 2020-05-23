using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackForm
{
    class CardDeck
    {
        public int NumberOfCards
        {
            get
            {
                return cards.Count;
            }
        }
        public int count;
        private Card tempCard;
        private List<Card> cards = new List<Card>();

        public CardDeck()
        {
            PopulateDeck();
        }

        private void PopulateDeck()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            for (int i = 0; i < 52; i++)
            {
                cards.Add(new Card(values[i % 13], faces[i % 13], suits[i / 13]));
            }
        }

        public Card DealCard()
        {
            count++;
            tempCard = cards[count];
            cards.Remove(cards[count]);
            return cards[count];
        }

        public void ResetDeck()
        {
            cards.Clear();
            PopulateDeck();
            count = 0;
        }

        public void Shuffle()
        {
            Random rnd = new Random();
            //Using fisher-yates shuffle
            for (int i = 0; i < NumberOfCards; i++)
            {
                int newLocation = rnd.Next(i + 1);
                Card tempCard = cards[i];
                cards[i] = cards[newLocation];
                cards[newLocation] = tempCard;
            }
        }
    }
}
