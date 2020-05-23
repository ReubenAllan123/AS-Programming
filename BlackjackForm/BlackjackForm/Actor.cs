using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackForm
{
    class Actor
    {

        public int NumberOfCards
        {
            get
            {
                return cards.Count;
            }
        }
        private List<Card> cards = new List<Card>();
        public int Total;
        private int mostRecentCard = -1;

        public double bank = 200;
        public int bet;

        public int CalculateTotal()
        {
            Total = 0;
            for (int i = 0; i < NumberOfCards; i++)
            {
                Total = Total + cards[i].GetValue();
            }
            return Total;
        }

        public void AddCard(Card card)
        {
            cards.Add(card);
            mostRecentCard++;
        }
        public void ResetHand()
        {
            mostRecentCard = -1;
            cards.Clear();
        }

        public Card CheckAce(Card card)
        {
            if (card.GetValue() == 1)
            {
                string caption = "You got an Ace!";
                string message = "If you want it to have value 11, select YES. Otherwise, choose NO.";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;

                DialogResult result;

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    card.SetValue(11);
                    return card;
                }
                else return card;
            }
            else return card;
        }

        public string ReturnCard()
        {
            return cards[mostRecentCard].GetDescription();
        }

    }
}

