namespace Presentacion
{
    partial class menu_almacen
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
            this.cOMPRAPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aGREGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNVENTARIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cXCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRAPRODUCTOSToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.iNVENTARIOSToolStripMenuItem,
            this.cXCToolStripMenuItem,
            this.cOMPRASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cOMPRAPRODUCTOSToolStripMenuItem
            // 
            this.cOMPRAPRODUCTOSToolStripMenuItem.Image = global::Presentacion.Properties.Resources.shop_cart_icon;
            this.cOMPRAPRODUCTOSToolStripMenuItem.Name = "cOMPRAPRODUCTOSToolStripMenuItem";
            this.cOMPRAPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(156, 20);
            this.cOMPRAPRODUCTOSToolStripMenuItem.Text = "COMPRA PRODUCTOS";
            this.cOMPRAPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.cOMPRAPRODUCTOSToolStripMenuItem_Click);
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aGREGARToolStripMenuItem,
            this.cONSULTARToolStripMenuItem});
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // aGREGARToolStripMenuItem
            // 
            this.aGREGARToolStripMenuItem.Name = "aGREGARToolStripMenuItem";
            this.aGREGARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aGREGARToolStripMenuItem.Text = "AGREGAR";
            this.aGREGARToolStripMenuItem.Click += new System.EventHandler(this.aGREGARToolStripMenuItem_Click);
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cONSULTARToolStripMenuItem.Text = "CONSULTAR";
            this.cONSULTARToolStripMenuItem.Click += new System.EventHandler(this.cONSULTARToolStripMenuItem_Click);
            // 
            // iNVENTARIOSToolStripMenuItem
            // 
            this.iNVENTARIOSToolStripMenuItem.Name = "iNVENTARIOSToolStripMenuItem";
            this.iNVENTARIOSToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.iNVENTARIOSToolStripMenuItem.Text = "INVENTARIOS";
            // 
            // cXCToolStripMenuItem
            // 
            this.cXCToolStripMenuItem.Name = "cXCToolStripMenuItem";
            this.cXCToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.cXCToolStripMenuItem.Text = "CXP";
            this.cXCToolStripMenuItem.Click += new System.EventHandler(this.cXCToolStripMenuItem_Click);
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.cOMPRASToolStripMenuItem.Text = "TODAS LAS COMPRAS ";
            this.cOMPRASToolStripMenuItem.Click += new System.EventHandler(this.cOMPRASToolStripMenuItem_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Presentacion.Properties.Resources.warehouse3color;
            this.pictureBox4.Location = new System.Drawing.Point(0, 33);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(996, 398);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // menu_almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 465);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "menu_almacen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "menu almacen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAPRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aGREGARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNVENTARIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cXCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}