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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void postoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmposto fm = new frmposto();
            fm.Show();
        }

        private void enquantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmenquanto fm = new frmenquanto();
            fm.Show();  
        }

        private void repitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmrepita fm = new frmrepita();
            fm.Show();
        }

        private void paraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmpara fm = new frmpara();
            fm.Show();
        }
    }
}
