using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadenivia
{
    public partial class frmenquanto : Form
    {
        public frmenquanto()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, fat, num;
            num = Convert.ToInt32(txtnum.Text);

            i = 1;
            fat = 1;
            while (i<=num)
            {
                fat = fat * i;
                i++;
                txtresultado.Text = string.Concat(txtresultado.Text, "r/n", fat.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresultado.Clear();

            txtnum.Focus();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal fm = new frmprincipal();
            fm.Show();
        }
    }
}
