namespace Projetods
{
    partial class frmprincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.postoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enquantoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.postoToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(681, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // postoToolStripMenuItem
            // 
            this.postoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enquantoToolStripMenuItem,
            this.repitaToolStripMenuItem,
            this.paraToolStripMenuItem});
            this.postoToolStripMenuItem.Name = "postoToolStripMenuItem";
            this.postoToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.postoToolStripMenuItem.Text = "Posto";
            this.postoToolStripMenuItem.Click += new System.EventHandler(this.postoToolStripMenuItem_Click);
            // 
            // enquantoToolStripMenuItem
            // 
            this.enquantoToolStripMenuItem.Name = "enquantoToolStripMenuItem";
            this.enquantoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.enquantoToolStripMenuItem.Text = "Enquanto";
            this.enquantoToolStripMenuItem.Click += new System.EventHandler(this.enquantoToolStripMenuItem_Click);
            // 
            // repitaToolStripMenuItem
            // 
            this.repitaToolStripMenuItem.Name = "repitaToolStripMenuItem";
            this.repitaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repitaToolStripMenuItem.Text = "Repita";
            this.repitaToolStripMenuItem.Click += new System.EventHandler(this.repitaToolStripMenuItem_Click);
            // 
            // paraToolStripMenuItem
            // 
            this.paraToolStripMenuItem.Name = "paraToolStripMenuItem";
            this.paraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.paraToolStripMenuItem.Text = "Para";
            this.paraToolStripMenuItem.Click += new System.EventHandler(this.paraToolStripMenuItem_Click);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(681, 211);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmprincipal";
            this.Text = "Principal";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem postoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enquantoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraToolStripMenuItem;
    }
}

