namespace Presentacion.Insertar
{
    partial class Estudiantes
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbSi = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.cbSangre = new System.Windows.Forms.ComboBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.rbFeme = new System.Windows.Forms.RadioButton();
            this.rbMascu = new System.Windows.Forms.RadioButton();
            this.txtFecha = new System.Windows.Forms.MaskedTextBox();
            this.txtRNE = new System.Windows.Forms.TextBox();
            this.txtDire = new System.Windows.Forms.TextBox();
            this.txtApelli2 = new System.Windows.Forms.TextBox();
            this.txtApelli1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbCurso = new System.Windows.Forms.ComboBox();
            this.cursosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistema_escolarDataSet = new Presentacion.sistema_escolarDataSet();
            this.cbTanda = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.txtInstituto = new System.Windows.Forms.TextBox();
            this.rbInstitutoNo = new System.Windows.Forms.RadioButton();
            this.rbInstitutoSi = new System.Windows.Forms.RadioButton();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.cursosTableAdapter = new Presentacion.sistema_escolarDataSetTableAdapters.cursosTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.PictureBox();
            this.btnLimpiar = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_escolarDataSet)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.cbSangre);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtTel);
            this.groupBox1.Controls.Add(this.rbFeme);
            this.groupBox1.Controls.Add(this.rbMascu);
            this.groupBox1.Controls.Add(this.txtFecha);
            this.groupBox1.Controls.Add(this.txtRNE);
            this.groupBox1.Controls.Add(this.txtDire);
            this.groupBox1.Controls.Add(this.txtApelli2);
            this.groupBox1.Controls.Add(this.txtApelli1);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 354);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACION PERSONAL";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbNo);
            this.panel2.Controls.Add(this.rbSi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(0, 239);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 30);
            this.panel2.TabIndex = 23;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(235, 5);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(41, 17);
            this.rbNo.TabIndex = 11;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbSi
            // 
            this.rbSi.AutoSize = true;
            this.rbSi.Location = new System.Drawing.Point(154, 7);
            this.rbSi.Name = "rbSi";
            this.rbSi.Size = new System.Drawing.Size(35, 17);
            this.rbSi.TabIndex = 10;
            this.rbSi.TabStop = true;
            this.rbSi.Text = "SI";
            this.rbSi.UseVisualStyleBackColor = true;
            this.rbSi.CheckedChanged += new System.EventHandler(this.rbSi_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "PADECE ENFERMEDADES";
            // 
            // cbSangre
            // 
            this.cbSangre.FormattingEnabled = true;
            this.cbSangre.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "O+",
            "O-"});
            this.cbSangre.Location = new System.Drawing.Point(110, 321);
            this.cbSangre.Name = "cbSangre";
            this.cbSangre.Size = new System.Drawing.Size(121, 21);
            this.cbSangre.TabIndex = 12;
            // 
            // txtComentario
            // 
            this.txtComentario.Enabled = false;
            this.txtComentario.Location = new System.Drawing.Point(9, 274);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(325, 41);
            this.txtComentario.TabIndex = 12;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(76, 213);
            this.txtTel.Mask = "000-000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(126, 20);
            this.txtTel.TabIndex = 9;
            // 
            // rbFeme
            // 
            this.rbFeme.AutoSize = true;
            this.rbFeme.Location = new System.Drawing.Point(177, 143);
            this.rbFeme.Name = "rbFeme";
            this.rbFeme.Size = new System.Drawing.Size(81, 17);
            this.rbFeme.TabIndex = 7;
            this.rbFeme.Text = "FEMENINO";
            this.rbFeme.UseVisualStyleBackColor = true;
            // 
            // rbMascu
            // 
            this.rbMascu.AutoSize = true;
            this.rbMascu.Location = new System.Drawing.Point(76, 143);
            this.rbMascu.Name = "rbMascu";
            this.rbMascu.Size = new System.Drawing.Size(88, 17);
            this.rbMascu.TabIndex = 6;
            this.rbMascu.Text = "MASCULINO";
            this.rbMascu.UseVisualStyleBackColor = true;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(76, 115);
            this.txtFecha.Mask = "00/00/0000";
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(126, 20);
            this.txtFecha.TabIndex = 5;
            this.txtFecha.ValidatingType = typeof(System.DateTime);
            // 
            // txtRNE
            // 
            this.txtRNE.Location = new System.Drawing.Point(76, 80);
            this.txtRNE.MaxLength = 14;
            this.txtRNE.Name = "txtRNE";
            this.txtRNE.Size = new System.Drawing.Size(126, 20);
            this.txtRNE.TabIndex = 4;
            // 
            // txtDire
            // 
            this.txtDire.Location = new System.Drawing.Point(76, 166);
            this.txtDire.Multiline = true;
            this.txtDire.Name = "txtDire";
            this.txtDire.Size = new System.Drawing.Size(258, 41);
            this.txtDire.TabIndex = 8;
            // 
            // txtApelli2
            // 
            this.txtApelli2.Location = new System.Drawing.Point(208, 54);
            this.txtApelli2.Name = "txtApelli2";
            this.txtApelli2.Size = new System.Drawing.Size(126, 20);
            this.txtApelli2.TabIndex = 3;
            // 
            // txtApelli1
            // 
            this.txtApelli1.Location = new System.Drawing.Point(76, 54);
            this.txtApelli1.Name = "txtApelli1";
            this.txtApelli1.Size = new System.Drawing.Size(126, 20);
            this.txtApelli1.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 28);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(258, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 324);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "TIPO DE SANGRE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "TELEFONO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "DIRECCION";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "SEXO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = " FECHA NAC.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "R.N.E";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "APELLIDOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOMBRE";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbCurso);
            this.groupBox4.Controls.Add(this.cbTanda);
            this.groupBox4.Controls.Add(this.cbAno);
            this.groupBox4.Controls.Add(this.txtInstituto);
            this.groupBox4.Controls.Add(this.rbInstitutoNo);
            this.groupBox4.Controls.Add(this.rbInstitutoSi);
            this.groupBox4.Controls.Add(this.label27);
            this.groupBox4.Controls.Add(this.label26);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(365, 36);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(348, 183);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REGISTRO ACADEMICO";
            // 
            // cbCurso
            // 
            this.cbCurso.DataSource = this.cursosBindingSource;
            this.cbCurso.DisplayMember = "nombre";
            this.cbCurso.FormattingEnabled = true;
            this.cbCurso.Location = new System.Drawing.Point(89, 87);
            this.cbCurso.Name = "cbCurso";
            this.cbCurso.Size = new System.Drawing.Size(121, 21);
            this.cbCurso.TabIndex = 15;
            this.cbCurso.ValueMember = "nombre";
            // 
            // cursosBindingSource
            // 
            this.cursosBindingSource.DataMember = "cursos";
            this.cursosBindingSource.DataSource = this.sistema_escolarDataSet;
            // 
            // sistema_escolarDataSet
            // 
            this.sistema_escolarDataSet.DataSetName = "sistema_escolarDataSet";
            this.sistema_escolarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbTanda
            // 
            this.cbTanda.FormattingEnabled = true;
            this.cbTanda.Items.AddRange(new object[] {
            "MAÑANA",
            "TARDE"});
            this.cbTanda.Location = new System.Drawing.Point(89, 57);
            this.cbTanda.Name = "cbTanda";
            this.cbTanda.Size = new System.Drawing.Size(121, 21);
            this.cbTanda.TabIndex = 14;
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Location = new System.Drawing.Point(89, 29);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(121, 21);
            this.cbAno.TabIndex = 13;
            // 
            // txtInstituto
            // 
            this.txtInstituto.Enabled = false;
            this.txtInstituto.Location = new System.Drawing.Point(9, 147);
            this.txtInstituto.Name = "txtInstituto";
            this.txtInstituto.Size = new System.Drawing.Size(325, 20);
            this.txtInstituto.TabIndex = 18;
            // 
            // rbInstitutoNo
            // 
            this.rbInstitutoNo.AutoSize = true;
            this.rbInstitutoNo.Location = new System.Drawing.Point(223, 124);
            this.rbInstitutoNo.Name = "rbInstitutoNo";
            this.rbInstitutoNo.Size = new System.Drawing.Size(41, 17);
            this.rbInstitutoNo.TabIndex = 17;
            this.rbInstitutoNo.TabStop = true;
            this.rbInstitutoNo.Text = "NO";
            this.rbInstitutoNo.UseVisualStyleBackColor = true;
            // 
            // rbInstitutoSi
            // 
            this.rbInstitutoSi.AutoSize = true;
            this.rbInstitutoSi.Location = new System.Drawing.Point(175, 124);
            this.rbInstitutoSi.Name = "rbInstitutoSi";
            this.rbInstitutoSi.Size = new System.Drawing.Size(35, 17);
            this.rbInstitutoSi.TabIndex = 16;
            this.rbInstitutoSi.TabStop = true;
            this.rbInstitutoSi.Text = "SI";
            this.rbInstitutoSi.UseVisualStyleBackColor = true;
            this.rbInstitutoSi.CheckedChanged += new System.EventHandler(this.rbInstitutoSi_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 126);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(163, 13);
            this.label27.TabIndex = 26;
            this.label27.Text = "INSTITUTO DE PROCEDENCIA";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(5, 90);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(45, 13);
            this.label26.TabIndex = 25;
            this.label26.Text = "CURSO";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(44, 13);
            this.label25.TabIndex = 24;
            this.label25.Text = "TANDA";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 32);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(85, 13);
            this.label24.TabIndex = 23;
            this.label24.Text = "AÑO ELECTIVO";
            // 
            // cursosTableAdapter
            // 
            this.cursosTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnAgregar);
            this.panel3.Controls.Add(this.btnSalir);
            this.panel3.Controls.Add(this.btnLimpiar);
            this.panel3.Location = new System.Drawing.Point(408, 236);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(167, 137);
            this.panel3.TabIndex = 47;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Image = global::Presentacion.Properties.Resources.depositphotos_6538520_3D_Blue_Button___Add_a_contact1;
            this.btnAgregar.Location = new System.Drawing.Point(7, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(70, 50);
            this.btnAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.TabStop = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Image = global::Presentacion.Properties.Resources._39646570_icono_salir_boton_cuadrado_azul;
            this.btnSalir.Location = new System.Drawing.Point(95, 40);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(69, 59);
            this.btnSalir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSalir.TabIndex = 17;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Image = global::Presentacion.Properties.Resources.download__10_;
            this.btnLimpiar.Location = new System.Drawing.Point(7, 72);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(70, 50);
            this.btnLimpiar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.TabStop = false;
            // 
            // Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(721, 406);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Estudiantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudiantes";
            this.Load += new System.EventHandler(this.Estudiantes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cursosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistema_escolarDataSet)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAgregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLimpiar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSangre;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.RadioButton rbFeme;
        private System.Windows.Forms.RadioButton rbMascu;
        private System.Windows.Forms.MaskedTextBox txtFecha;
        private System.Windows.Forms.TextBox txtDire;
        private System.Windows.Forms.TextBox txtApelli2;
        private System.Windows.Forms.TextBox txtApelli1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbCurso;
        private System.Windows.Forms.ComboBox cbTanda;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.TextBox txtInstituto;
        private System.Windows.Forms.RadioButton rbInstitutoNo;
        private System.Windows.Forms.RadioButton rbInstitutoSi;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbSi;
        private System.Windows.Forms.Label label8;
        private sistema_escolarDataSet sistema_escolarDataSet;
        private System.Windows.Forms.BindingSource cursosBindingSource;
        private sistema_escolarDataSetTableAdapters.cursosTableAdapter cursosTableAdapter;
        private System.Windows.Forms.TextBox txtRNE;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox btnAgregar;
        private System.Windows.Forms.PictureBox btnSalir;
        private System.Windows.Forms.PictureBox btnLimpiar;
    }
}