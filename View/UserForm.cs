using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglıkOcagıRandevuSistemi.View
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show(this.Text);
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (this.txtTcGiris.Text.Length >= 15)
                {
                    txtTcGiris.Text = "";
                }
                this.txtTcGiris.Text += clickedButton.Text;
            }
        }

        private void txtTcGiris_Click(object sender, EventArgs e)
        {
            if (txtTcGiris.Text.Length > 11)
            {
                txtTcGiris.Text = string.Empty;
            }
        }
    }
}
