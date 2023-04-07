using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividadenivia
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void tabuadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmtabuada fm = new frmtabuada();
            fm.Show();
        }

        private void repitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmrepita fm = new frmrepita();
            fm.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmenquanto fm = new frmenquanto();
            fm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmpara fm = new frmpara();
            fm.Show();
        }
    }
}
