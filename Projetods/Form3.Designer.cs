namespace Projetods
{
    partial class frmenquanto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblcod1 = new System.Windows.Forms.Label();
            this.lbllitros1 = new System.Windows.Forms.Label();
            this.lblpreco1 = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(157, 185);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(90, 27);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(319, 185);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(77, 27);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(483, 185);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(81, 27);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.button6_Click);
            // 
            // lblcod1
            // 
            this.lblcod1.AutoSize = true;
            this.lblcod1.Location = new System.Drawing.Point(157, 47);
            this.lblcod1.Name = "lblcod1";
            this.lblcod1.Size = new System.Drawing.Size(78, 13);
            this.lblcod1.TabIndex = 3;
            this.lblcod1.Text = "Digite o código";
            // 
            // lbllitros1
            // 
            this.lbllitros1.AutoSize = true;
            this.lbllitros1.Location = new System.Drawing.Point(159, 92);
            this.lbllitros1.Name = "lbllitros1";
            this.lbllitros1.Size = new System.Drawing.Size(138, 13);
            this.lbllitros1.TabIndex = 4;
            this.lbllitros1.Text = "Digite a quantidade de litros";
            // 
            // lblpreco1
            // 
            this.lblpreco1.AutoSize = true;
            this.lblpreco1.Location = new System.Drawing.Point(159, 142);
            this.lblpreco1.Name = "lblpreco1";
            this.lblpreco1.Size = new System.Drawing.Size(35, 13);
            this.lblpreco1.TabIndex = 5;
            this.lblpreco1.Text = "Preço";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(311, 54);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 6;
            // 
            // txtlitros
            // 
            this.txtlitros.Location = new System.Drawing.Point(311, 92);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(100, 20);
            this.txtlitros.TabIndex = 7;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(311, 142);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 8;
            // 
            // frmenquanto
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(704, 261);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lblpreco1);
            this.Controls.Add(this.lbllitros1);
            this.Controls.Add(this.lblcod1);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "frmenquanto";
            this.Text = "Enquanto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lbllitros;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblcod1;
        private System.Windows.Forms.Label lbllitros1;
        private System.Windows.Forms.Label lblpreco1;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtpreco;
    }
}