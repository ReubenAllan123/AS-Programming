using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackForm
{
    class Card
    {
        private string Suit;
        private string Face;
        private int Value;

        public Card(int cardValue, string cardFace, string cardSuit)
        {
            Value = cardValue;
            Face = cardFace;
            Suit = cardSuit;
        }

        public string GetDescription()
        {
            return $"{Face} of {Suit}";
        }

        public int GetValue()
        {
            return Value;
        }

        public void SetValue(int value)
        {
            Value = value;
        }
    }
}
