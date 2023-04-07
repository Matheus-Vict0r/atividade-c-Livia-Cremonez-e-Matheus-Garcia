namespace Projetods
{
    partial class frmpara
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
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtlitros = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.lbllitros = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(155, 189);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 0;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(322, 191);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 1;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(461, 193);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 2;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(409, 38);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 3;
            // 
            // txtlitros
            // 
            this.txtlitros.Location = new System.Drawing.Point(409, 82);
            this.txtlitros.Name = "txtlitros";
            this.txtlitros.Size = new System.Drawing.Size(100, 20);
            this.txtlitros.TabIndex = 4;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(409, 130);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 5;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(181, 55);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(78, 13);
            this.lblcod.TabIndex = 6;
            this.lblcod.Text = "Digite o código";
            // 
            // lbllitros
            // 
            this.lbllitros.AutoSize = true;
            this.lbllitros.Location = new System.Drawing.Point(178, 96);
            this.lbllitros.Name = "lbllitros";
            this.lbllitros.Size = new System.Drawing.Size(138, 13);
            this.lbllitros.TabIndex = 7;
            this.lbllitros.Text = "Digite a quantidade de litros";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(181, 144);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(35, 13);
            this.lblpreco.TabIndex = 8;
            this.lblpreco.Text = "Preço";
            // 
            // frmpara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(739, 250);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbllitros);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtlitros);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Name = "frmpara";
            this.Text = "Para";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lbllitros;
        private System.Windows.Forms.Label lblpreco;
    }
}