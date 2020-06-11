using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceShakerForm
{
    class Shaker
    {
        public int Total
        {
            get
            {
                int tempTotal = die1.Face + die2.Face;
                if (IsADouble())
                {
                    tempTotal = tempTotal + die3.Face;
                }
                return tempTotal;
            }
        }

        //turn this into an array
        public readonly Die die1 = new Die();
        public readonly Die die2 = new Die();
        public readonly Die die3 = new Die();

        public void RollDice()
        {
            //turn into an array
            die1.Roll();
            die2.Roll();
            die3.Roll();
        }

        public bool IsADouble()
        {
            return die1.Face == die2.Face;
        }
    }

    class Die
    {
        private Random rnd = new Random(Guid.NewGuid().GetHashCode());
        public int Face { get; private set; }
        private byte Sides = 6;
        public Die()
        {
            Roll();
        }
        public Die(byte sides)
        {
            if (sides > 1)
            {
                Sides = sides;
                Roll();
            }
            else
            {
                throw new ArgumentOutOfRangeException("sides");
            }
        }
        public void Roll()
        {
            Face = rnd.Next(1, Sides + 1);
        }
    }
}
