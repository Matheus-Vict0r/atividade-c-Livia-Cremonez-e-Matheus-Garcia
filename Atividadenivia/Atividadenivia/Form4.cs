using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadenivia
{
    public partial class frmrepita : Form
    {
        public frmrepita()
        {
            InitializeComponent();
        }
        private void btncalcular1_Click(object sender, EventArgs e)
        {
            int i, fat, num;
            num = Convert.ToInt32(txtnum1.Text); 
            
            i = 1;
            fat = 1;
            do
            {
                i++;
            } while (i<=num);
            {
                fat = fat * 1;
                i++;
                txtresultado1.Text = string.Concat(txtresultado1.Text, "r/n", fat.ToString());
            }
        }

        private void btnlimpar1_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtresultado1.Clear();

            txtnum1.Focus();
        }

        private void btnvoltar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmprincipal fm = new frmprincipal();
            fm.Show();
        }
    }
}
