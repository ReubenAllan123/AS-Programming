using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceShakerForm
{
    public partial class Form1 : Form
    {
        DiceBoardDrawer diceBoard = new DiceBoardDrawer();
        BoardDrawer slBoard = new BoardDrawer();
        Shaker myShaker = new Shaker();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Roll_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbx_Board.Image = diceBoard.DrawBoard();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar.Increment(5);

            if (progressBar.Value == 100)
            {
                myShaker.RollDice();

                pbx_Board.Image = diceBoard.DrawBoard(myShaker.die1.Face, myShaker.die2.Face);
                if (myShaker.IsADouble())
                {
                    pbx_Board.Image = diceBoard.DrawBoard(myShaker.die1.Face, myShaker.die2.Face, myShaker.die3.Face);
                }
                lbl_Total.Text = myShaker.Total.ToString();

                progressBar.Value = 0;
                timer1.Enabled = false;
            }
            else
            {
                myShaker.RollDice();

                pbx_Board.Image = diceBoard.DrawRandomBoard(myShaker.die1.Face, myShaker.die2.Face);
                if (myShaker.IsADouble())
                {
                    pbx_Board.Image = diceBoard.DrawRandomBoard(myShaker.die1.Face, myShaker.die2.Face, myShaker.die3.Face);
                }
                lbl_Total.Text = myShaker.Total.ToString();
            }
        }
    }
}
