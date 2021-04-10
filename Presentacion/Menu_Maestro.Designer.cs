namespace Presentacion
{
    partial class Menu_Maestro
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
            this.components = new System.ComponentModel.Container();
            this.mainMenu3 = new System.Windows.Forms.MainMenu(this.components);
            this.mainMenu2 = new System.Windows.Forms.MainMenu(this.components);
            this.pUBLICARNOTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGAREXAMENESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOBROSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mISDATOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pUBLICARNOTASToolStripMenuItem
            // 
            this.pUBLICARNOTASToolStripMenuItem.Name = "pUBLICARNOTASToolStripMenuItem";
            this.pUBLICARNOTASToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.pUBLICARNOTASToolStripMenuItem.Text = "PUBLICAR NOTAS";
            this.pUBLICARNOTASToolStripMenuItem.Click += new System.EventHandler(this.pUBLICARNOTASToolStripMenuItem_Click);
            // 
            // aGREGAREXAMENESToolStripMenuItem
            // 
            this.aGREGAREXAMENESToolStripMenuItem.Name = "aGREGAREXAMENESToolStripMenuItem";
            this.aGREGAREXAMENESToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.aGREGAREXAMENESToolStripMenuItem.Text = "AGREGAR EXAMENES";
            // 
            // cOBROSToolStripMenuItem
            // 
            this.cOBROSToolStripMenuItem.Name = "cOBROSToolStripMenuItem";
            this.cOBROSToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.cOBROSToolStripMenuItem.Text = "COBROS";
            // 
            // mISDATOSToolStripMenuItem
            // 
            this.mISDATOSToolStripMenuItem.Name = "mISDATOSToolStripMenuItem";
            this.mISDATOSToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.mISDATOSToolStripMenuItem.Text = "MIS DATOS";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pUBLICARNOTASToolStripMenuItem,
            this.aGREGAREXAMENESToolStripMenuItem,
            this.cOBROSToolStripMenuItem,
            this.mISDATOSToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Maestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 465);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Menu = this.mainMenu3;
            this.Name = "Menu_Maestro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Maestro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MainMenu mainMenu3;
        private System.Windows.Forms.MainMenu mainMenu2;
        private System.Windows.Forms.ToolStripMenuItem pUBLICARNOTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGREGAREXAMENESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOBROSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mISDATOSToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}