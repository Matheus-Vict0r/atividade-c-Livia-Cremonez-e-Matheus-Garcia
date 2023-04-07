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
    public partial class frmpara : Form
    {
        public frmpara()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, fat, x, num;
            num = Convert.ToInt32(txtpreco.Text);
            i = 1;
            fat = 1;
            do
            {
                fat = fat * 1;
                i++;
                txtpreco.Text = string.Concat(txtpreco, "/n/n", fat.ToString());
            } while (i <= num);
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtcod.Clear(); 
            txtlitros.Clear();
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
