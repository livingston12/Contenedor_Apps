namespace Presentacion.Consultas
{
    partial class CXP
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
            this.gvDatos = new System.Windows.Forms.DataGridView();
            this.idcxpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplidorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipocompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPagarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcompraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cXPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_escolarDataSet2 = new Presentacion.sistema_escolarDataSet2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescR = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVerTodos = new System.Windows.Forms.PictureBox();
            this.btnAceptar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cXPTableAdapter = new Presentacion.sistema_escolarDataSet2TableAdapters.CXPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cXPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_escolarDataSet2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerTodos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvDatos
            // 
            this.gvDatos.AutoGenerateColumns = false;
            this.gvDatos.BackgroundColor = System.Drawing.Color.White;
            this.gvDatos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcxpDataGridViewTextBoxColumn,
            this.suplidorDataGridViewTextBoxColumn,
            this.tipocompraDataGridViewTextBoxColumn,
            this.totalPagarDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.idcompraDataGridViewTextBoxColumn});
            this.gvDatos.DataSource = this.cXPBindingSource;
            this.gvDatos.Location = new System.Drawing.Point(2, 153);
            this.gvDatos.Name = "gvDatos";
            this.gvDatos.Size = new System.Drawing.Size(582, 163);
            this.gvDatos.TabIndex = 62;
            // 
            // idcxpDataGridViewTextBoxColumn
            // 
            this.idcxpDataGridViewTextBoxColumn.DataPropertyName = "id_cxp";
            this.idcxpDataGridViewTextBoxColumn.HeaderText = "id_cxp";
            this.idcxpDataGridViewTextBoxColumn.Name = "idcxpDataGridViewTextBoxColumn";
            this.idcxpDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // suplidorDataGridViewTextBoxColumn
            // 
            this.suplidorDataGridViewTextBoxColumn.DataPropertyName = "suplidor";
            this.suplidorDataGridViewTextBoxColumn.HeaderText = "suplidor";
            this.suplidorDataGridViewTextBoxColumn.Name = "suplidorDataGridViewTextBoxColumn";
            // 
            // tipocompraDataGridViewTextBoxColumn
            // 
            this.tipocompraDataGridViewTextBoxColumn.DataPropertyName = "tipo_compra";
            this.tipocompraDataGridViewTextBoxColumn.HeaderText = "tipo_compra";
            this.tipocompraDataGridViewTextBoxColumn.Name = "tipocompraDataGridViewTextBoxColumn";
            // 
            // totalPagarDataGridViewTextBoxColumn
            // 
            this.totalPagarDataGridViewTextBoxColumn.DataPropertyName = "total_Pagar";
            this.totalPagarDataGridViewTextBoxColumn.HeaderText = "total_Pagar";
            this.totalPagarDataGridViewTextBoxColumn.Name = "totalPagarDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // idcompraDataGridViewTextBoxColumn
            // 
            this.idcompraDataGridViewTextBoxColumn.DataPropertyName = "id_compra";
            this.idcompraDataGridViewTextBoxColumn.HeaderText = "id_compra";
            this.idcompraDataGridViewTextBoxColumn.MaxInputLength = 5;
            this.idcompraDataGridViewTextBoxColumn.Name = "idcompraDataGridViewTextBoxColumn";
            this.idcompraDataGridViewTextBoxColumn.Width = 40;
            // 
            // cXPBindingSource
            // 
            this.cXPBindingSource.DataMember = "CXP";
            this.cXPBindingSource.DataSource = this.sistema_escolarDataSet2;
            // 
            // sistema_escolarDataSet2
            // 
            this.sistema_escolarDataSet2.DataSetName = "sistema_escolarDataSet2";
            this.sistema_escolarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescR);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(5, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 55);
            this.panel1.TabIndex = 60;
            // 
            // txtDescR
            // 
            this.txtDescR.Location = new System.Drawing.Point(136, 13);
            this.txtDescR.Name = "txtDescR";
            this.txtDescR.Size = new System.Drawing.Size(163, 20);
            this.txtDescR.TabIndex = 19;
            this.txtDescR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDescR_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Presentacion.Properties.Resources.images;
            this.btnBuscar.Location = new System.Drawing.Point(305, 3);
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
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOMBRE SUPLIDOR";
            // 
            // BtnVerTodos
            // 
            this.BtnVerTodos.Image = global::Presentacion.Properties.Resources.icon_find_sort;
            this.BtnVerTodos.Location = new System.Drawing.Point(5, 331);
            this.BtnVerTodos.Name = "BtnVerTodos";
            this.BtnVerTodos.Size = new System.Drawing.Size(63, 43);
            this.BtnVerTodos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnVerTodos.TabIndex = 61;
            this.BtnVerTodos.TabStop = false;
            this.BtnVerTodos.Click += new System.EventHandler(this.BtnVerTodos_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Presentacion.Properties.Resources._39646570_icono_salir_boton_cuadrado_azul;
            this.btnAceptar.Location = new System.Drawing.Point(478, 323);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(101, 52);
            this.btnAceptar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAceptar.TabIndex = 59;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label8.Font = new System.Drawing.Font("Forte", 25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Pixel, ((byte)(0)), true);
            this.label8.Location = new System.Drawing.Point(174, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 27);
            this.label8.TabIndex = 58;
            this.label8.Text = "CONSULTA DE CXP";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentacion.Properties.Resources.descarga;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(588, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // cXPTableAdapter
            // 
            this.cXPTableAdapter.ClearBeforeFill = true;
            // 
            // CXP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.gvDatos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnVerTodos);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CXP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CXP";
            this.Load += new System.EventHandler(this.CXP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvDatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cXPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_escolarDataSet2)).EndInit();
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
        private System.Windows.Forms.TextBox txtDescR;
        private System.Windows.Forms.PictureBox btnBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BtnVerTodos;
        private System.Windows.Forms.PictureBox btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private sistema_escolarDataSet2 sistema_escolarDataSet2;
        private System.Windows.Forms.BindingSource cXPBindingSource;
        private sistema_escolarDataSet2TableAdapters.CXPTableAdapter cXPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcxpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplidorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipocompraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPagarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcompraDataGridViewTextBoxColumn;
    }
}