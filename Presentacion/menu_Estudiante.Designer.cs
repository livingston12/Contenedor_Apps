namespace Presentacion
{
    partial class menu_Estudiante
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
            this.nOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXAMENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pAGOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOTASToolStripMenuItem,
            this.eXAMENESToolStripMenuItem,
            this.pAGOSToolStripMenuItem,
            this.dATOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nOTASToolStripMenuItem
            // 
            this.nOTASToolStripMenuItem.Name = "nOTASToolStripMenuItem";
            this.nOTASToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.nOTASToolStripMenuItem.Text = "VER NOTAS";
            // 
            // eXAMENESToolStripMenuItem
            // 
            this.eXAMENESToolStripMenuItem.Name = "eXAMENESToolStripMenuItem";
            this.eXAMENESToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.eXAMENESToolStripMenuItem.Text = "TOMAR EXAMENES";
            // 
            // dATOSToolStripMenuItem
            // 
            this.dATOSToolStripMenuItem.Name = "dATOSToolStripMenuItem";
            this.dATOSToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.dATOSToolStripMenuItem.Text = "MIS DATOS";
            // 
            // pAGOSToolStripMenuItem
            // 
            this.pAGOSToolStripMenuItem.Name = "pAGOSToolStripMenuItem";
            this.pAGOSToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.pAGOSToolStripMenuItem.Text = "PAGOS REALIZADOS";
            // 
            // menu_Estudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 465);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "menu_Estudiante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu_Estudiante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXAMENESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dATOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pAGOSToolStripMenuItem;
    }
}