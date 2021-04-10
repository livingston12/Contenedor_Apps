namespace Presentacion.Consultas
{
    partial class Profesores
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
            this.gvDatos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCedula = new System.Windows.Forms.MaskedTextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerTodos = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDatos
            // 
            this.gvDatos.BackgroundColor = System.Drawing.Color.White;
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gvDatos.Location = new System.Drawing.Point(8, 160);
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.Size = new System.Drawing.Size(579, 168);
            this.gvDatos.TabIndex = 38;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCedula);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 55);
            this.panel1.TabIndex = 37;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(77, 13);
            this.txtCedula.Mask = "000-0000000-0";
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(154, 20);
            this.txtCedula.TabIndex = 19;
            this.txtCedula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCedula_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.images;
            this.btnBuscar.Location = new System.Drawing.Point(246, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(50, 33);
            this.btnBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CEDULA";
            // 
            // BtnVerTodos
            // 
            this.BtnVerTodos.Image = global::Presentacion.Properties.Resources.icon_find_sort;
            this.BtnVerTodos.Location = new System.Drawing.Point(8, 334);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(63, 43);
            this.BtnVerTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnVerTodos.TabIndex = 39;
            this.BtnVerTodos.TabStop = false;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Presentacion.Properties.Resources._39646570_icono_salir_boton_cuadrado_azul;
            this.btnAceptar.Location = new System.Drawing.Point(493, 334);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 43);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 36;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(140, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(326, 27);
            this.label8.TabIndex = 35;
            this.label8.Text = "CONSULTA DE PROFESORES";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.nuestro_azul_de_los_clientes_ajusta_el_fondo_44152303;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // Profesores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(580, 381);
            this.Controls.Add(this.gvDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnVerTodos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Profesores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerTodos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gvDatos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnVerTodos;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MaskedTextBox txtCedula;
    }
}