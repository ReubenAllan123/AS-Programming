using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo
{
    public partial class frmName : Form
    {
        public frmName()
        {
            InitializeComponent();
            progressBar1.Value = 0;
            picName.Visible = false;
        }

        private void cmdClick_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim().Length == 0)
                MessageBox.Show("You must enter a name");
            else
                MessageBox.Show($"Hi {txtName.Text}");

            frmName.BackColor = Color.Black;

            for (int i = 0; i < 100; i++)
            {
                progressBar1.Value = progressBar1.Value + 1;
                System.Threading.Thread.Sleep(50);
            }

            picName.Visible = true;
            progressBar1.Value = 0;
        }
    }
}
