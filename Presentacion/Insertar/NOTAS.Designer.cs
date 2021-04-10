namespace Presentacion.Insertar
{
    partial class NOTAS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dvAlumn = new System.Windows.Forms.DataGridView();
            this.txtAlum = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtProm = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.ComboBox();
            this.materiasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_escolarDataSet2 = new Presentacion.sistema_escolarDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materiasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materiasTableAdapter = new Presentacion.sistema_escolarDataSet3TableAdapters.materiasTableAdapter();
            this.materiasTableAdapter1 = new Presentacion.sistema_escolarDataSet2TableAdapters.materiasTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlumn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_escolarDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.dvAlumn);
            this.groupBox1.Controls.Add(this.txtAlum);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 302);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "BUSCAR ALUMNOS";
            // 
            // dvAlumn
            // 
            this.dvAlumn.AllowUserToAddRows = false;
            this.dvAlumn.AllowUserToDeleteRows = false;
            this.dvAlumn.BackgroundColor = System.Drawing.Color.White;
            this.dvAlumn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dvAlumn.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dvAlumn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvAlumn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dvAlumn.Location = new System.Drawing.Point(6, 46);
            this.dvAlumn.Name = "dvAlumn";
            this.dvAlumn.ReadOnly = true;
            this.dvAlumn.Size = new System.Drawing.Size(234, 250);
            this.dvAlumn.TabIndex = 1;
            // 
            // txtAlum
            // 
            this.txtAlum.Location = new System.Drawing.Point(6, 20);
            this.txtAlum.Name = "txtAlum";
            this.txtAlum.Size = new System.Drawing.Size(234, 20);
            this.txtAlum.TabIndex = 0;
            this.txtAlum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtAlum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlum_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Blue;
            this.groupBox2.Controls.Add(this.txtProm);
            this.groupBox2.Controls.Add(this.txtNota4);
            this.groupBox2.Controls.Add(this.txtNota3);
            this.groupBox2.Controls.Add(this.txtNota2);
            this.groupBox2.Controls.Add(this.txtNota1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtMat);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtcurso);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(280, 37);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 302);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CALIFICACIONES";
            // 
            // txtProm
            // 
            this.txtProm.Enabled = false;
            this.txtProm.Location = new System.Drawing.Point(69, 245);
            this.txtProm.Name = "txtProm";
            this.txtProm.Size = new System.Drawing.Size(232, 20);
            this.txtProm.TabIndex = 7;
            this.txtProm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtNota4
            // 
            this.txtNota4.Enabled = false;
            this.txtNota4.Location = new System.Drawing.Point(69, 203);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(232, 20);
            this.txtNota4.TabIndex = 6;
            this.txtNota4.TextChanged += new System.EventHandler(this.txtNota4_TextChanged);
            this.txtNota4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // txtNota3
            // 
            this.txtNota3.Enabled = false;
            this.txtNota3.Location = new System.Drawing.Point(69, 165);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(232, 20);
            this.txtNota3.TabIndex = 5;
            this.txtNota3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota3_KeyPress);
            // 
            // txtNota2
            // 
            this.txtNota2.Enabled = false;
            this.txtNota2.Location = new System.Drawing.Point(69, 126);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(232, 20);
            this.txtNota2.TabIndex = 4;
            this.txtNota2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNota2_KeyPress);
            // 
            // txtNota1
            // 
            this.txtNota1.Enabled = false;
            this.txtNota1.Location = new System.Drawing.Point(69, 90);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(232, 20);
            this.txtNota1.TabIndex = 3;
            this.txtNota1.TextChanged += new System.EventHandler(this.txtNota1_TextChanged);
            this.txtNota1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "PROMEDIO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "NOTA4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "NOTA3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "NOTA2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "NOTA1";
            // 
            // txtMat
            // 
            this.txtMat.DataSource = this.materiasBindingSource1;
            this.txtMat.DisplayMember = "nombre";
            this.txtMat.FormattingEnabled = true;
            this.txtMat.Location = new System.Drawing.Point(69, 53);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(232, 21);
            this.txtMat.TabIndex = 2;
            this.txtMat.ValueMember = "nombre";
            // 
            // materiasBindingSource1
            // 
            this.materiasBindingSource1.DataMember = "materias";
            this.materiasBindingSource1.DataSource = this.sistema_escolarDataSet2;
            // 
            // sistema_escolarDataSet2
            // 
            this.sistema_escolarDataSet2.DataSetName = "sistema_escolarDataSet2";
            this.sistema_escolarDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "MATERIA";
            // 
            // txtcurso
            // 
            this.txtcurso.Enabled = false;
            this.txtcurso.FormattingEnabled = true;
            this.txtcurso.Location = new System.Drawing.Point(69, 20);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(232, 21);
            this.txtcurso.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CURSO";
            // 
            // materiasTableAdapter
            // 
            this.materiasTableAdapter.ClearBeforeFill = true;
            // 
            // materiasTableAdapter1
            // 
            this.materiasTableAdapter1.ClearBeforeFill = true;
            // 
            // NOTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(619, 398);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NOTAS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTAS";
            this.Load += new System.EventHandler(this.NOTAS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvAlumn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_escolarDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dvAlumn;
        private System.Windows.Forms.TextBox txtAlum;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox txtcurso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProm;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource materiasBindingSource;
        private sistema_escolarDataSet3TableAdapters.materiasTableAdapter materiasTableAdapter;
        private sistema_escolarDataSet2 sistema_escolarDataSet2;
        private System.Windows.Forms.BindingSource materiasBindingSource1;
        private sistema_escolarDataSet2TableAdapters.materiasTableAdapter materiasTableAdapter1;
    }
}