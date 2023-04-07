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
    public partial class frmpara : Form
    {
        public frmpara()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int i, fat, num;
            num = Convert.ToInt32(txtnum.Text);

            i = 1;
            fat = 1;
            for (i = 1; i<=num; i++)
            {
                fat  = fat * i;
                i++;
                txtresultado1.Text = string.Concat (txtresultado1.Text, "r/n", fat.ToString());
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnum.Clear();
            txtresultado1.Clear();

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
