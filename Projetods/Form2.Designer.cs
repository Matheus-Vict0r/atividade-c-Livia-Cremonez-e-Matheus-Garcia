namespace Projetods
{
    partial class frmposto
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
            this.btncalcular1 = new System.Windows.Forms.Button();
            this.btnlimpar1 = new System.Windows.Forms.Button();
            this.btnvoltar1 = new System.Windows.Forms.Button();
            this.txtcod1 = new System.Windows.Forms.TextBox();
            this.txtlitros1 = new System.Windows.Forms.TextBox();
            this.txtpreco1 = new System.Windows.Forms.TextBox();
            this.lblcod1 = new System.Windows.Forms.Label();
            this.lbllitros1 = new System.Windows.Forms.Label();
            this.lblpreco1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular1
            // 
            this.btncalcular1.Location = new System.Drawing.Point(123, 187);
            this.btncalcular1.Name = "btncalcular1";
            this.btncalcular1.Size = new System.Drawing.Size(83, 34);
            this.btncalcular1.TabIndex = 0;
            this.btncalcular1.Text = "Calcular";
            this.btncalcular1.UseVisualStyleBackColor = true;
            this.btncalcular1.Click += new System.EventHandler(this.btncalcular1_Click);
            // 
            // btnlimpar1
            // 
            this.btnlimpar1.Location = new System.Drawing.Point(259, 187);
            this.btnlimpar1.Name = "btnlimpar1";
            this.btnlimpar1.Size = new System.Drawing.Size(89, 34);
            this.btnlimpar1.TabIndex = 1;
            this.btnlimpar1.Text = "Limpar";
            this.btnlimpar1.UseVisualStyleBackColor = true;
            this.btnlimpar1.Click += new System.EventHandler(this.btnlimpar1_Click);
            // 
            // btnvoltar1
            // 
            this.btnvoltar1.Location = new System.Drawing.Point(389, 187);
            this.btnvoltar1.Name = "btnvoltar1";
            this.btnvoltar1.Size = new System.Drawing.Size(86, 34);
            this.btnvoltar1.TabIndex = 2;
            this.btnvoltar1.Text = "Voltar";
            this.btnvoltar1.UseVisualStyleBackColor = true;
            this.btnvoltar1.Click += new System.EventHandler(this.btnvoltar1_Click);
            // 
            // txtcod1
            // 
            this.txtcod1.Location = new System.Drawing.Point(375, 58);
            this.txtcod1.Name = "txtcod1";
            this.txtcod1.Size = new System.Drawing.Size(100, 20);
            this.txtcod1.TabIndex = 3;
            // 
            // txtlitros1
            // 
            this.txtlitros1.Location = new System.Drawing.Point(375, 98);
            this.txtlitros1.Name = "txtlitros1";
            this.txtlitros1.Size = new System.Drawing.Size(100, 20);
            this.txtlitros1.TabIndex = 4;
            // 
            // txtpreco1
            // 
            this.txtpreco1.Location = new System.Drawing.Point(375, 144);
            this.txtpreco1.Name = "txtpreco1";
            this.txtpreco1.Size = new System.Drawing.Size(100, 20);
            this.txtpreco1.TabIndex = 5;
            // 
            // lblcod1
            // 
            this.lblcod1.AutoSize = true;
            this.lblcod1.Location = new System.Drawing.Point(120, 58);
            this.lblcod1.Name = "lblcod1";
            this.lblcod1.Size = new System.Drawing.Size(78, 13);
            this.lblcod1.TabIndex = 6;
            this.lblcod1.Text = "Digite o código";
            // 
            // lbllitros1
            // 
            this.lbllitros1.AutoSize = true;
            this.lbllitros1.Location = new System.Drawing.Point(120, 98);
            this.lbllitros1.Name = "lbllitros1";
            this.lbllitros1.Size = new System.Drawing.Size(138, 13);
            this.lbllitros1.TabIndex = 7;
            this.lbllitros1.Text = "Digite a quantidade de litros";
            // 
            // lblpreco1
            // 
            this.lblpreco1.AutoSize = true;
            this.lblpreco1.Location = new System.Drawing.Point(120, 144);
            this.lblpreco1.Name = "lblpreco1";
            this.lblpreco1.Size = new System.Drawing.Size(35, 13);
            this.lblpreco1.TabIndex = 8;
            this.lblpreco1.Text = "Preço";
            // 
            // frmposto
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(626, 261);
            this.Controls.Add(this.lblpreco1);
            this.Controls.Add(this.lbllitros1);
            this.Controls.Add(this.lblcod1);
            this.Controls.Add(this.txtpreco1);
            this.Controls.Add(this.txtlitros1);
            this.Controls.Add(this.txtcod1);
            this.Controls.Add(this.btnvoltar1);
            this.Controls.Add(this.btnlimpar1);
            this.Controls.Add(this.btncalcular1);
            this.Name = "frmposto";
            this.Text = "Posto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.Label lbllitros;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.TextBox txtlitros;
        private System.Windows.Forms.TextBox txtpreco;
        private System.Windows.Forms.Button btncalcular1;
        private System.Windows.Forms.Button btnlimpar1;
        private System.Windows.Forms.Button btnvoltar1;
        private System.Windows.Forms.TextBox txtcod1;
        private System.Windows.Forms.TextBox txtlitros1;
        private System.Windows.Forms.TextBox txtpreco1;
        private System.Windows.Forms.Label lblcod1;
        private System.Windows.Forms.Label lbllitros1;
        private System.Windows.Forms.Label lblpreco1;
    }
}