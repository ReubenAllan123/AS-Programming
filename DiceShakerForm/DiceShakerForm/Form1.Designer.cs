namespace DiceShakerForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_Roll = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.pbx_Board = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pbx_SLBoard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_SLBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Roll
            // 
            this.btn_Roll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Roll.Location = new System.Drawing.Point(594, 158);
            this.btn_Roll.Name = "btn_Roll";
            this.btn_Roll.Size = new System.Drawing.Size(140, 52);
            this.btn_Roll.TabIndex = 3;
            this.btn_Roll.Text = "Roll!";
            this.btn_Roll.UseVisualStyleBackColor = true;
            this.btn_Roll.Click += new System.EventHandler(this.btn_Roll_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total: ";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.Location = new System.Drawing.Point(653, 252);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(44, 48);
            this.lbl_Total.TabIndex = 7;
            this.lbl_Total.Text = "0";
            // 
            // pbx_Board
            // 
            this.pbx_Board.Location = new System.Drawing.Point(594, 12);
            this.pbx_Board.Name = "pbx_Board";
            this.pbx_Board.Size = new System.Drawing.Size(140, 140);
            this.pbx_Board.TabIndex = 8;
            this.pbx_Board.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 400;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(594, 216);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(140, 23);
            this.progressBar.TabIndex = 9;
            // 
            // pbx_SLBoard
            // 
            this.pbx_SLBoard.Location = new System.Drawing.Point(13, 13);
            this.pbx_SLBoard.Name = "pbx_SLBoard";
            this.pbx_SLBoard.Size = new System.Drawing.Size(550, 550);
            this.pbx_SLBoard.TabIndex = 10;
            this.pbx_SLBoard.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 577);
            this.Controls.Add(this.pbx_SLBoard);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pbx_Board);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Roll);
            this.Name = "Form1";
            this.Text = "Dice Shaker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Board)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_SLBoard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Roll;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.PictureBox pbx_Board;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.PictureBox pbx_SLBoard;
    }
}

