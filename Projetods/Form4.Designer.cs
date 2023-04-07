namespace Projetods
{
    partial class frmrepita
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
            this.txtlistros = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.txtpreco = new System.Windows.Forms.TextBox();
            this.lblcod = new System.Windows.Forms.Label();
            this.lbllistros = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtlistros
            // 
            this.txtlistros.Location = new System.Drawing.Point(333, 72);
            this.txtlistros.Name = "txtlistros";
            this.txtlistros.Size = new System.Drawing.Size(100, 20);
            this.txtlistros.TabIndex = 0;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(333, 28);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(100, 20);
            this.txtcod.TabIndex = 1;
            // 
            // txtpreco
            // 
            this.txtpreco.Location = new System.Drawing.Point(333, 116);
            this.txtpreco.Name = "txtpreco";
            this.txtpreco.Size = new System.Drawing.Size(100, 20);
            this.txtpreco.TabIndex = 2;
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(149, 35);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(78, 13);
            this.lblcod.TabIndex = 3;
            this.lblcod.Text = "Digite o código";
            // 
            // lbllistros
            // 
            this.lbllistros.AutoSize = true;
            this.lbllistros.Location = new System.Drawing.Point(149, 79);
            this.lbllistros.Name = "lbllistros";
            this.lbllistros.Size = new System.Drawing.Size(138, 13);
            this.lbllistros.TabIndex = 4;
            this.lbllistros.Text = "Digite a quantidade de litros";
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(149, 135);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(35, 13);
            this.lblpreco.TabIndex = 5;
            this.lblpreco.Text = "Preço";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(157, 192);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 6;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(336, 188);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(478, 188);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmrepita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(717, 252);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lbllistros);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.txtpreco);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.txtlistros);
            this.Name = "frmrepita";
            this.Text = "Repita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtlistros;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lbllistros;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}