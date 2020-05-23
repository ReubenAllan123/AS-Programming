namespace BlackjackForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_hit = new System.Windows.Forms.Button();
            this.btn_stay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_pTotal = new System.Windows.Forms.Label();
            this.lbl_dTotal = new System.Windows.Forms.Label();
            this.lbx_playersCards = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_GameMessage = new System.Windows.Forms.Label();
            this.btn_PlayAgain = new System.Windows.Forms.Button();
            this.btn_DoubleDown = new System.Windows.Forms.Button();
            this.btn_PlaceBet = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbx_dealersCards = new System.Windows.Forms.ListBox();
            this.lbl_playersBank = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_dealersBank = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nud_PlayerBet = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_playersBet = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlayerBet)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_hit
            // 
            this.btn_hit.Location = new System.Drawing.Point(12, 305);
            this.btn_hit.Name = "btn_hit";
            this.btn_hit.Size = new System.Drawing.Size(100, 50);
            this.btn_hit.TabIndex = 0;
            this.btn_hit.Text = "Hit";
            this.btn_hit.UseVisualStyleBackColor = true;
            this.btn_hit.Click += new System.EventHandler(this.btn_hit_Click);
            // 
            // btn_stay
            // 
            this.btn_stay.Location = new System.Drawing.Point(123, 306);
            this.btn_stay.Name = "btn_stay";
            this.btn_stay.Size = new System.Drawing.Size(100, 50);
            this.btn_stay.TabIndex = 1;
            this.btn_stay.Text = "Stay";
            this.btn_stay.UseVisualStyleBackColor = true;
            this.btn_stay.Click += new System.EventHandler(this.btn_stay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player\'s Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dealer\'s Total:";
            // 
            // lbl_pTotal
            // 
            this.lbl_pTotal.AutoSize = true;
            this.lbl_pTotal.Location = new System.Drawing.Point(118, 54);
            this.lbl_pTotal.Name = "lbl_pTotal";
            this.lbl_pTotal.Size = new System.Drawing.Size(13, 13);
            this.lbl_pTotal.TabIndex = 4;
            this.lbl_pTotal.Text = "0";
            // 
            // lbl_dTotal
            // 
            this.lbl_dTotal.AutoSize = true;
            this.lbl_dTotal.Location = new System.Drawing.Point(328, 54);
            this.lbl_dTotal.Name = "lbl_dTotal";
            this.lbl_dTotal.Size = new System.Drawing.Size(13, 13);
            this.lbl_dTotal.TabIndex = 5;
            this.lbl_dTotal.Text = "0";
            // 
            // lbx_playersCards
            // 
            this.lbx_playersCards.FormattingEnabled = true;
            this.lbx_playersCards.Location = new System.Drawing.Point(103, 81);
            this.lbx_playersCards.Name = "lbx_playersCards";
            this.lbx_playersCards.Size = new System.Drawing.Size(110, 69);
            this.lbx_playersCards.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player\'s Cards:";
            // 
            // lbl_GameMessage
            // 
            this.lbl_GameMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GameMessage.AutoSize = true;
            this.lbl_GameMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GameMessage.Location = new System.Drawing.Point(195, 12);
            this.lbl_GameMessage.Name = "lbl_GameMessage";
            this.lbl_GameMessage.Size = new System.Drawing.Size(51, 16);
            this.lbl_GameMessage.TabIndex = 8;
            this.lbl_GameMessage.Text = "label4";
            this.lbl_GameMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_PlayAgain
            // 
            this.btn_PlayAgain.Location = new System.Drawing.Point(347, 306);
            this.btn_PlayAgain.Name = "btn_PlayAgain";
            this.btn_PlayAgain.Size = new System.Drawing.Size(100, 50);
            this.btn_PlayAgain.TabIndex = 9;
            this.btn_PlayAgain.Text = "Play Again";
            this.btn_PlayAgain.UseVisualStyleBackColor = true;
            this.btn_PlayAgain.Click += new System.EventHandler(this.btn_PlayAgain_Click);
            // 
            // btn_DoubleDown
            // 
            this.btn_DoubleDown.Location = new System.Drawing.Point(235, 306);
            this.btn_DoubleDown.Name = "btn_DoubleDown";
            this.btn_DoubleDown.Size = new System.Drawing.Size(100, 50);
            this.btn_DoubleDown.TabIndex = 10;
            this.btn_DoubleDown.Text = "Double Down";
            this.btn_DoubleDown.UseVisualStyleBackColor = true;
            this.btn_DoubleDown.Click += new System.EventHandler(this.btn_DoubleDown_Click);
            // 
            // btn_PlaceBet
            // 
            this.btn_PlaceBet.Location = new System.Drawing.Point(67, 244);
            this.btn_PlaceBet.Name = "btn_PlaceBet";
            this.btn_PlaceBet.Size = new System.Drawing.Size(85, 24);
            this.btn_PlaceBet.TabIndex = 11;
            this.btn_PlaceBet.Text = "Place Bet $";
            this.btn_PlaceBet.UseVisualStyleBackColor = true;
            this.btn_PlaceBet.Click += new System.EventHandler(this.btn_PlaceBet_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dealer\'s Cards:";
            // 
            // lbx_dealersCards
            // 
            this.lbx_dealersCards.FormattingEnabled = true;
            this.lbx_dealersCards.Location = new System.Drawing.Point(313, 81);
            this.lbx_dealersCards.Name = "lbx_dealersCards";
            this.lbx_dealersCards.Size = new System.Drawing.Size(110, 56);
            this.lbx_dealersCards.TabIndex = 12;
            // 
            // lbl_playersBank
            // 
            this.lbl_playersBank.AutoSize = true;
            this.lbl_playersBank.Location = new System.Drawing.Point(118, 172);
            this.lbl_playersBank.Name = "lbl_playersBank";
            this.lbl_playersBank.Size = new System.Drawing.Size(13, 13);
            this.lbl_playersBank.TabIndex = 15;
            this.lbl_playersBank.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Player\'s Bank: $";
            // 
            // lbl_dealersBank
            // 
            this.lbl_dealersBank.AutoSize = true;
            this.lbl_dealersBank.Location = new System.Drawing.Point(327, 172);
            this.lbl_dealersBank.Name = "lbl_dealersBank";
            this.lbl_dealersBank.Size = new System.Drawing.Size(13, 13);
            this.lbl_dealersBank.TabIndex = 17;
            this.lbl_dealersBank.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(236, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Dealer\'s Bank: $";
            // 
            // nud_PlayerBet
            // 
            this.nud_PlayerBet.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nud_PlayerBet.Location = new System.Drawing.Point(67, 227);
            this.nud_PlayerBet.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nud_PlayerBet.Name = "nud_PlayerBet";
            this.nud_PlayerBet.Size = new System.Drawing.Size(85, 20);
            this.nud_PlayerBet.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(224, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 250);
            this.label5.TabIndex = 19;
            // 
            // lbl_playersBet
            // 
            this.lbl_playersBet.AutoSize = true;
            this.lbl_playersBet.Location = new System.Drawing.Point(120, 194);
            this.lbl_playersBet.Name = "lbl_playersBet";
            this.lbl_playersBet.Size = new System.Drawing.Size(13, 13);
            this.lbl_playersBet.TabIndex = 21;
            this.lbl_playersBet.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Player\'s Bet:   $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "...and one hidden!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 367);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_playersBet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_PlayerBet);
            this.Controls.Add(this.lbl_dealersBank);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_playersBank);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbx_dealersCards);
            this.Controls.Add(this.btn_PlaceBet);
            this.Controls.Add(this.btn_DoubleDown);
            this.Controls.Add(this.btn_PlayAgain);
            this.Controls.Add(this.lbl_GameMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbx_playersCards);
            this.Controls.Add(this.lbl_dTotal);
            this.Controls.Add(this.lbl_pTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stay);
            this.Controls.Add(this.btn_hit);
            this.Name = "Form1";
            this.Text = "Blackjack Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_PlayerBet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hit;
        private System.Windows.Forms.Button btn_stay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_pTotal;
        private System.Windows.Forms.Label lbl_dTotal;
        private System.Windows.Forms.ListBox lbx_playersCards;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_GameMessage;
        private System.Windows.Forms.Button btn_PlayAgain;
        private System.Windows.Forms.Button btn_DoubleDown;
        private System.Windows.Forms.Button btn_PlaceBet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbx_dealersCards;
        private System.Windows.Forms.Label lbl_playersBank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_dealersBank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nud_PlayerBet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_playersBet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

