using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetods
{
    public partial class frmrepita : Form
    {
        public frmrepita()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, fat, x, num;
            num = Convert.ToInt32(txtpreco.Text);

            fat = 1;
            for (i = 1; i <= num; i++)
            {
                fat = fat * i;
                txtpreco.Text = string.Concat(txtpreco.Text, "/n/n", fat.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtlistros.Clear();
            txtpreco.Clear();

            txtcod.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmprincipal fm = new frmprincipal();   
            fm.Show();  
        }
    }
}
