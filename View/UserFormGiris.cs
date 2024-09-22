using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaglıkOcagıRandevuSistemi
{
    public partial class Frm_HastaGiris : Form
    {
        public Frm_HastaGiris()
        {
            InitializeComponent();
        }
       
        private void Frm_HastaGiris_Load(object sender, EventArgs e)
        {
            txtTcGiris.Focus();
            MessageBox.Show("Test");
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                if (txtTcGiris.Text.Length>=15)
                {
                    txtTcGiris.Text = "";
                }
                txtTcGiris.Text += clickedButton.Text;
            }
        }

        private void txtTcGiris_Click(object sender, EventArgs e)
        {
            if (txtTcGiris.Text.Length>11)
            {
                txtTcGiris.Text = string.Empty;
            }
        }
    }
}
