using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackForm
{
    public partial class Form1 : Form
    {
        public bool hit = false;

        //Create deck
        CardDeck pack = new CardDeck();

        //Create actors
        Actor player = new Actor();
        Actor dealer = new Actor();
        GamePlay game = new GamePlay();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_playersBank.Text = player.bank.ToString();
            lbl_dealersBank.Text = dealer.bank.ToString();

            btn_hit.Enabled = false;

            game.PlayGame(pack, player, dealer, game, lbx_playersCards, lbx_dealersCards, lbl_pTotal, lbl_dTotal, lbl_GameMessage, lbl_playersBank, lbl_dealersBank, lbl_playersBet, btn_DoubleDown, btn_PlaceBet, btn_hit, btn_stay, btn_PlayAgain);
        }


        private void btn_hit_Click(object sender, EventArgs e)
        {
            btn_DoubleDown.Enabled = false;

            player.AddCard(player.CheckAce(pack.DealCard()));
            lbx_playersCards.Items.Add(player.ReturnCard());
            lbl_pTotal.Text = (player.CalculateTotal().ToString());
            if (player.CalculateTotal() > 21)
            {
                lbl_GameMessage.Text = ("Player is BUST!");
                while (dealer.CalculateTotal() < 17)
                {
                    lbl_GameMessage.Text = ("Dealer has hit!");
                    dealer.AddCard(pack.DealCard());
                    lbx_dealersCards.Items.Add(dealer.ReturnCard());
                    lbl_dTotal.Text = (dealer.CalculateTotal().ToString());
                }

                game.EndGame(btn_hit, btn_stay, player, dealer, game, lbl_playersBank, lbl_dealersBank, lbl_playersBet, btn_DoubleDown, btn_PlaceBet, btn_PlayAgain);
            }
        }

        private void btn_stay_Click(object sender, EventArgs e)
        {
            lbl_GameMessage.Text = ("Player has STUCK!");
            while (dealer.CalculateTotal() < 17)
            {
                lbl_GameMessage.Text = ("Dealer has hit!");
                dealer.AddCard(pack.DealCard());
                lbx_dealersCards.Items.Add(dealer.ReturnCard());
                lbl_dTotal.Text = (dealer.CalculateTotal().ToString());
            }
            lbl_GameMessage.Text = ("Dealer has STUCK!");

            game.EndGame(btn_hit, btn_stay, player, dealer, game, lbl_playersBank, lbl_dealersBank, lbl_playersBet, btn_DoubleDown, btn_PlaceBet, btn_PlayAgain);
        }

        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            //Reset deck
            pack.ResetDeck();
            //Reset players
            player.ResetHand();
            dealer.ResetHand();
            //Update displays
            game.StartGame(btn_hit, btn_stay, btn_PlaceBet, btn_DoubleDown, player, dealer);

            lbl_pTotal.Text = (player.CalculateTotal().ToString());
            lbl_dTotal.Text = (dealer.CalculateTotal().ToString());
            lbx_playersCards.Items.Clear();
            lbx_dealersCards.Items.Clear();

            game.PlayGame(pack, player, dealer, game, lbx_playersCards, lbx_dealersCards, lbl_pTotal, lbl_dTotal, lbl_GameMessage, lbl_playersBank, lbl_dealersBank, lbl_playersBet, btn_DoubleDown, btn_PlaceBet, btn_hit, btn_stay, btn_PlayAgain);
        }

        private void btn_PlaceBet_Click(object sender, EventArgs e)
        {
            player.bet = Convert.ToInt32(Math.Round(nud_PlayerBet.Value, 0));
            lbl_playersBet.Text = player.bet.ToString();
            player.bank = player.bank - player.bet;
            lbl_playersBank.Text = player.bank.ToString();

            btn_hit.Enabled = true;
        }

        private void btn_DoubleDown_Click(object sender, EventArgs e)
        {
            player.bank = player.bank - player.bet;
            player.bet = player.bet * 2;
            lbl_playersBet.Text = player.bet.ToString();
            lbl_playersBank.Text = player.bank.ToString();
            btn_DoubleDown.Enabled = false;
            btn_hit.Enabled = false;
        }
    }
}