using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceShakerForm
{
    class BoardDrawer
    {
        private Image board = Properties.Resources.board;

        private Bitmap boardSL;

        public BoardDrawer()
        {
            boardSL = new Bitmap(550, 550);
        }

        public Bitmap DrawBoard()
        {
            using (Graphics g = Graphics.FromImage(boardSL))
            {
                g.DrawImage(board, 0, 0, boardSL.Width, boardSL.Height);
            }
            return boardSL;
        }
    }
}