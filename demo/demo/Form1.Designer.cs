namespace demo
{
    partial class frmName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmName));
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.picName = new System.Windows.Forms.PictureBox();
            this.cmdClick = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.picName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 26);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // picName
            // 
            this.picName.Image = ((System.Drawing.Image)(resources.GetObject("picName.Image")));
            this.picName.InitialImage = ((System.Drawing.Image)(resources.GetObject("picName.InitialImage")));
            this.picName.Location = new System.Drawing.Point(437, 54);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(237, 273);
            this.picName.TabIndex = 2;
            this.picName.TabStop = false;
            // 
            // cmdClick
            // 
            this.cmdClick.Location = new System.Drawing.Point(106, 141);
            this.cmdClick.Name = "cmdClick";
            this.cmdClick.Size = new System.Drawing.Size(202, 34);
            this.cmdClick.TabIndex = 3;
            this.cmdClick.Text = " Click Me";
            this.cmdClick.UseVisualStyleBackColor = true;
            this.cmdClick.Click += new System.EventHandler(this.cmdClick_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(78, 367);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(649, 42);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Value = 69;
            // 
            // frmName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.cmdClick);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "frmName";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmName_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox picName;
        private System.Windows.Forms.Button cmdClick;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

