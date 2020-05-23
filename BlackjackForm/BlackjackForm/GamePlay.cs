using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackjackForm
{
    class GamePlay
    {
        public string FirstCheck(Button hit, Button stay, Actor player, Actor dealer, GamePlay game, Label lbl_playersBank, Label lbl_dealersBank, Label lbl_playersBet, Button dd, Button bet, Button playagain)
        {
            if (dealer.CalculateTotal() == player.CalculateTotal() && dealer.Total == 21)
            {
                EndGame(hit, stay, player, dealer, game, lbl_playersBank, lbl_dealersBank, lbl_playersBet, dd, bet, playagain);
                return "Draw!";
            }
            else if (player.CalculateTotal() == 21)
            {
                EndGame(hit, stay, player, dealer, game, lbl_playersBank, lbl_dealersBank, lbl_playersBet, dd, bet, playagain);
                return "Player wins! Dealer loses!";
            }
            else if (dealer.CalculateTotal() == 21)
            {
                EndGame(hit, stay, player, dealer, game, lbl_playersBank, lbl_dealersBank, lbl_playersBet, dd, bet, playagain);
                return "Dealer wins! Player loses!";
            }
            else
            {
                return "Lets play!";
            }
        }

        public string DecideWinner(Actor player, Actor dealer)
        {
            if (player.Total == dealer.Total && player.Total < 22)
            {
                return ("Draw!");
            }
            else if (player.Total < 22 && dealer.Total < 22)
            {
                if (player.Total > dealer.Total)
                {
                    return ("Player is the winner!");
                }
                else return ("Dealer is the winner!");
            }
            else if (player.Total == 21)
            {
                return ("Player is the winner!");
            }
            else if (dealer.Total == 21)
            {
                return ("Dealer is the winner!");
            }
            else if (player.Total > 21 && dealer.Total < 22)
            {
                return ("Dealer is the winner!");
            }
            else if (dealer.Total > 21 && player.Total < 22)
            {
                return ("Player is the winner!");
            }
            else
            {
                return ("No one wins!");
            }
        }

        public void StartGame(Button hit, Button stay, Button bet, Button dd, Actor player, Actor dealer)
        {
            hit.Enabled = true;
            stay.Enabled = true;
            bet.Enabled = true;
            dd.Enabled = true;

            player.Total = 0;
            dealer.Total = 0;
        }

        public void PlayGame(CardDeck pack, Actor player, Actor dealer, GamePlay game, ListBox lbx_playersCards, ListBox lbx_dealersCards, Label lbl_pTotal, Label lbl_dTotal, Label lbl_GameMessage, Label pBank, Label dBank, Label pBet, Button dd, Button bet, Button hit, Button stay, Button playagain)
        {
            //Create, assign and shuffle deck
            pack.Shuffle();

            //Deal to actors
            player.AddCard(player.CheckAce(pack.DealCard()));
            lbx_playersCards.Items.Add(player.ReturnCard());
            lbl_pTotal.Text = (player.CalculateTotal().ToString());

            player.AddCard(player.CheckAce(pack.DealCard()));
            lbx_playersCards.Items.Add(player.ReturnCard());
            lbl_pTotal.Text = (player.CalculateTotal().ToString());

            dealer.AddCard(pack.DealCard());
            dealer.AddCard(pack.DealCard());
            lbx_dealersCards.Items.Add(dealer.ReturnCard());
            lbl_dTotal.Text = (dealer.CalculateTotal().ToString());

            //Check totals
            lbl_GameMessage.Text = game.FirstCheck(hit, stay, player, dealer, game, pBank, dBank, pBet, dd, bet, playagain);
        }

        public void EndGame(Button hit, Button stay, Actor player, Actor dealer, GamePlay game, Label lbl_playersBank, Label lbl_dealersBank, Label lbl_playersBet, Button dd, Button bet, Button btn_playagain)
        {
            string message;
            string caption;

            hit.Enabled = false;
            stay.Enabled = false;
            bet.Enabled = false;
            dd.Enabled = false;

            if (DecideWinner(player, dealer) == "Player is the winner!")
            {
                player.bank = player.bank + (player.bet * 1.5);
                dealer.bank = dealer.bank - (player.bet * 0.5);
            }
            else if (DecideWinner(player, dealer) == "Dealer is the winner!")
            {
                dealer.bank = dealer.bank + player.bet;
            }
            else
            {
                player.bank = player.bank + player.bet;
            }


            UpdateMoney(player, dealer, lbl_playersBank, lbl_dealersBank, lbl_playersBet);


            if (player.bank <1 || dealer.bank <1)
            {
                caption = "Game Over!";

                if (player.bank > dealer.bank)
                {
                    message = $"Dealer is bankrupt. Player is the winner!";
                }
                else if (dealer.bank > player.bank)
                {
                    message = $"Player is bankrupt. Dealer is the winner!";
                }
                else
                {
                    message = $"You're both bankrupt.";
                }
                btn_playagain.Enabled = false;
            }
            else
            {
                caption = "Round Over!";
                message = $"{game.DecideWinner(player, dealer)}\n\nPlayer total = {player.Total}\nDealer total = {dealer.Total}";
            }
            MessageBox.Show(message, caption);

            
        }


        public void UpdateMoney(Actor player, Actor dealer, Label lbl_playersBank, Label lbl_dealersBank, Label lbl_playersBet)
        {
            player.bet = 0;
            lbl_playersBet.Text = player.bet.ToString();
            lbl_playersBank.Text = player.bank.ToString();
            lbl_dealersBank.Text = dealer.bank.ToString();
        }
    }
}