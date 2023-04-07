using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetods
{
    public partial class frmposto : Form
    {
        public frmposto()
        {
            InitializeComponent();
        }

        private void btncalcular1_Click(object sender, EventArgs e)
        {
            double litros, preco;
            char cod;

            cod = (char)Convert.ToDouble (txtcod1.Text);
            litros = Convert.ToDouble(txtpreco.Text);

            if (cod.Equals("A")) 
            {
                if (litros <= 20)
                    preco = litros * (4.30 - (4.30 * 3 / 100));
                txtpreco1.Text = preco.ToString();
               

                else if (cod.Equals("G")) 
                if (litros <= 20)
                    preco = litros * (5.50 - (5.50 * 3 / 100));
                    txtpreco1.Text = preco. ToString(); 

            }
                    
                

        }

        private void btnlimpar1_Click(object sender, EventArgs e)
        {
            txtcod.Clear();
            txtlitros.Clear();
            txtpreco.Clear();   

            txtcod.Focus(); 
        }

        private void btnvoltar1_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmprincipal fm = new frmprincipal();
            fm.Show();
        }
    }
}
