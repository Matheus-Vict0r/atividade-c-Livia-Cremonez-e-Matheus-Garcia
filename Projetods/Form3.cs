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
    public partial class frmenquanto : Form
    {
        public frmenquanto()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmprincipal fm = new frmprincipal();
            fm.Show();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, x, fat, num;
            num = Convert.ToInt32(txtpreco.Text);
            i = 1; 
            fat = 1;
            while (i <= num)
            {
                fat = fat * i;
                i++;
                txtpreco.Text = string.Concat(txtpreco.Text, "r/n", fat.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtlitros.Clear();
            txtpreco.Clear();

            txtcod.Focus();
        }
    }
}
