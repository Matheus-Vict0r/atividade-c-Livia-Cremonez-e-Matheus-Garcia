namespace Atividadenivia
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
            this.btncalcular1 = new System.Windows.Forms.Button();
            this.btnlimpar1 = new System.Windows.Forms.Button();
            this.btnvoltar1 = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtresultado1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.lblresultado1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btncalcular1
            // 
            this.btncalcular1.Location = new System.Drawing.Point(232, 244);
            this.btncalcular1.Name = "btncalcular1";
            this.btncalcular1.Size = new System.Drawing.Size(124, 48);
            this.btncalcular1.TabIndex = 0;
            this.btncalcular1.Text = "Calcular";
            this.btncalcular1.UseVisualStyleBackColor = true;
            // 
            // btnlimpar1
            // 
            this.btnlimpar1.Location = new System.Drawing.Point(486, 244);
            this.btnlimpar1.Name = "btnlimpar1";
            this.btnlimpar1.Size = new System.Drawing.Size(134, 48);
            this.btnlimpar1.TabIndex = 1;
            this.btnlimpar1.Text = "Limpar";
            this.btnlimpar1.UseVisualStyleBackColor = true;
            this.btnlimpar1.Click += new System.EventHandler(this.btnlimpar1_Click);
            // 
            // btnvoltar1
            // 
            this.btnvoltar1.Location = new System.Drawing.Point(747, 244);
            this.btnvoltar1.Name = "btnvoltar1";
            this.btnvoltar1.Size = new System.Drawing.Size(147, 48);
            this.btnvoltar1.TabIndex = 2;
            this.btnvoltar1.Text = "Voltar";
            this.btnvoltar1.UseVisualStyleBackColor = true;
            this.btnvoltar1.Click += new System.EventHandler(this.btnvoltar1_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(638, 86);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(206, 26);
            this.txtnum1.TabIndex = 3;
            // 
            // txtresultado1
            // 
            this.txtresultado1.Location = new System.Drawing.Point(639, 148);
            this.txtresultado1.Name = "txtresultado1";
            this.txtresultado1.Size = new System.Drawing.Size(205, 26);
            this.txtresultado1.TabIndex = 4;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(290, 92);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(204, 20);
            this.lblnum1.TabIndex = 5;
            this.lblnum1.Text = "Digite um número de 0 a 10";
            // 
            // lblresultado1
            // 
            this.lblresultado1.AutoSize = true;
            this.lblresultado1.Location = new System.Drawing.Point(290, 154);
            this.lblresultado1.Name = "lblresultado1";
            this.lblresultado1.Size = new System.Drawing.Size(82, 20);
            this.lblresultado1.TabIndex = 6;
            this.lblresultado1.Text = "Resultado";
            // 
            // frmrepita
            // 
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1118, 393);
            this.Controls.Add(this.lblresultado1);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtresultado1);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnvoltar1);
            this.Controls.Add(this.btnlimpar1);
            this.Controls.Add(this.btncalcular1);
            this.Name = "frmrepita";
            this.Text = "Repita";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Button btncalcular1;
        private System.Windows.Forms.Button btnlimpar1;
        private System.Windows.Forms.Button btnvoltar1;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtresultado1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.Label lblresultado1;
    }
}