using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceShakerForm
{
    class DiceBoardDrawer
    {
        Random rnd = new Random(Guid.NewGuid().GetHashCode());
        private Image felt = Properties.Resources.felt;
        private Image[] dotImages =
        {
            Properties.Resources.die1,
            Properties.Resources.die2,
            Properties.Resources.die3,
            Properties.Resources.die4,
            Properties.Resources.die5, 
            Properties.Resources.die6,
        };

        private Bitmap board;
        public DiceBoardDrawer()
        {
            board = new Bitmap(140, 140);

        }
        public Bitmap DrawBoard()
        {
            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);
            }
            return board;
        }

        public Bitmap DrawBoard(int die1)
        {
            int dieWidth = board.Width / 3;
            int dieHeight = board.Height / 3;

            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);
                g.DrawImage(dotImages[die1 - 1], dieWidth, dieHeight, dieWidth, dieHeight);
            }
            return board;
        }

        public Bitmap DrawBoard(int die1, int die2)
        {
            int dieWidth = board.Width / 3;
            int dieHeight = board.Height / 3;

            int[] diceValues = { die1, die2 };

            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < diceValues.Length; i++)
                {
                    g.DrawImage(dotImages[diceValues[i]-1], dieWidth * i, dieHeight * i, dieWidth, dieHeight);
                }
            }
            return board;
        }
        public Bitmap DrawRandomBoard(int die1, int die2)
        {
            int dieWidth = board.Width / 3;
            int dieHeight = board.Height / 3;

            int[] diceValues = { die1, die2 };

            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < diceValues.Length; i++)
                {
                    g.DrawImage(dotImages[diceValues[i] - 1], rnd.Next(0, 100), rnd.Next(0, 100), dieWidth, dieHeight);
                }
            }
            return board;
        }

        public Bitmap DrawBoard(int die1, int die2, int die3)
        {
            int dieWidth = board.Width / 3;
            int dieHeight = board.Height / 3;

            int[] diceValues = { die1, die2, die3 };

            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < diceValues.Length; i++)
                {
                    g.DrawImage(dotImages[diceValues[i] - 1], dieWidth * i, dieHeight * i, dieWidth, dieHeight);
                }
            }
            return board;
        }
        public Bitmap DrawRandomBoard(int die1, int die2, int die3)
        {
            int dieWidth = board.Width / 3;
            int dieHeight = board.Height / 3;

            int[] diceValues = { die1, die2, die3 };

            using (Graphics g = Graphics.FromImage(board))
            {
                g.DrawImage(felt, 0, 0, board.Width, board.Height);

                for (int i = 0; i < diceValues.Length; i++)
                {
                    g.DrawImage(dotImages[diceValues[i] - 1], rnd.Next(0, 100), rnd.Next(0, 100), dieWidth, dieHeight);
                }
            }
            return board;
        }

    }
}
