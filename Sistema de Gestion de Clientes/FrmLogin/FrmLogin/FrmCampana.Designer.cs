﻿namespace FrmLogin
{
    partial class FrmCampana
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnImportar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resultadoImportacion = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImportacionCampana = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarSubCampana = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbCampañaOrigenMarketing = new System.Windows.Forms.ComboBox();
            this.cbRelacOrigen = new System.Windows.Forms.ComboBox();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rbComercio = new System.Windows.Forms.RadioButton();
            this.rbPrestamo = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbSucursales = new System.Windows.Forms.ComboBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.resultadoImportacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Importar CSV:";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(306, 34);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(75, 23);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(97, 36);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(202, 20);
            this.txtRuta.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resultadoImportacion
            // 
            this.resultadoImportacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultadoImportacion.Location = new System.Drawing.Point(12, 311);
            this.resultadoImportacion.Name = "resultadoImportacion";
            this.resultadoImportacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultadoImportacion.Size = new System.Drawing.Size(1104, 161);
            this.resultadoImportacion.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnImportar);
            this.groupBox1.Controls.Add(this.txtRuta);
            this.groupBox1.Location = new System.Drawing.Point(729, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(387, 168);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proceso de importacion de campaña";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(386, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 23);
            this.label2.TabIndex = 118;
            this.label2.Text = "Asistente para importar campaña";
            // 
            // lblImportacionCampana
            // 
            this.lblImportacionCampana.AutoSize = true;
            this.lblImportacionCampana.Location = new System.Drawing.Point(18, 295);
            this.lblImportacionCampana.Name = "lblImportacionCampana";
            this.lblImportacionCampana.Size = new System.Drawing.Size(159, 13);
            this.lblImportacionCampana.TabIndex = 119;
            this.lblImportacionCampana.Text = "Resultado importacion campaña";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarSubCampana);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbCampañaOrigenMarketing);
            this.groupBox2.Controls.Add(this.cbRelacOrigen);
            this.groupBox2.Controls.Add(this.cbOrigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 103);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 167);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Campaña";
            // 
            // btnAgregarSubCampana
            // 
            this.btnAgregarSubCampana.Location = new System.Drawing.Point(326, 116);
            this.btnAgregarSubCampana.Name = "btnAgregarSubCampana";
            this.btnAgregarSubCampana.Size = new System.Drawing.Size(31, 23);
            this.btnAgregarSubCampana.TabIndex = 6;
            this.btnAgregarSubCampana.Text = "+";
            this.btnAgregarSubCampana.UseVisualStyleBackColor = true;
            this.btnAgregarSubCampana.Click += new System.EventHandler(this.btnAgregarSubCampana_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "SubCampaña";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Campaña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Origen";
            // 
            // cbCampañaOrigenMarketing
            // 
            this.cbCampañaOrigenMarketing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampañaOrigenMarketing.FormattingEnabled = true;
            this.cbCampañaOrigenMarketing.Location = new System.Drawing.Point(116, 116);
            this.cbCampañaOrigenMarketing.Name = "cbCampañaOrigenMarketing";
            this.cbCampañaOrigenMarketing.Size = new System.Drawing.Size(204, 21);
            this.cbCampañaOrigenMarketing.TabIndex = 2;
            this.cbCampañaOrigenMarketing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbCampañaOrigenMarketing_MouseDown);
            // 
            // cbRelacOrigen
            // 
            this.cbRelacOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelacOrigen.FormattingEnabled = true;
            this.cbRelacOrigen.Location = new System.Drawing.Point(116, 76);
            this.cbRelacOrigen.Name = "cbRelacOrigen";
            this.cbRelacOrigen.Size = new System.Drawing.Size(204, 21);
            this.cbRelacOrigen.TabIndex = 1;
            this.cbRelacOrigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbRelacOrigen_MouseDown);
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(116, 35);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(204, 21);
            this.cbOrigen.TabIndex = 0;
            this.cbOrigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbOrigen_MouseDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.rbComercio);
            this.groupBox3.Controls.Add(this.rbPrestamo);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbSucursales);
            this.groupBox3.Controls.Add(this.cbUsuarios);
            this.groupBox3.Location = new System.Drawing.Point(387, 104);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(336, 167);
            this.groupBox3.TabIndex = 121;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Otras opciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 153;
            this.label8.Text = "Asignado a:";
            // 
            // rbComercio
            // 
            this.rbComercio.AutoSize = true;
            this.rbComercio.Location = new System.Drawing.Point(240, 122);
            this.rbComercio.Name = "rbComercio";
            this.rbComercio.Size = new System.Drawing.Size(69, 17);
            this.rbComercio.TabIndex = 152;
            this.rbComercio.TabStop = true;
            this.rbComercio.Text = "Comercio";
            this.rbComercio.UseVisualStyleBackColor = true;
            // 
            // rbPrestamo
            // 
            this.rbPrestamo.AutoSize = true;
            this.rbPrestamo.Location = new System.Drawing.Point(133, 122);
            this.rbPrestamo.Name = "rbPrestamo";
            this.rbPrestamo.Size = new System.Drawing.Size(69, 17);
            this.rbPrestamo.TabIndex = 151;
            this.rbPrestamo.TabStop = true;
            this.rbPrestamo.Text = "Prestamo";
            this.rbPrestamo.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Sucursal asignada";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Usuario asignado";
            // 
            // cbSucursales
            // 
            this.cbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSucursales.FormattingEnabled = true;
            this.cbSucursales.Location = new System.Drawing.Point(116, 75);
            this.cbSucursales.Name = "cbSucursales";
            this.cbSucursales.Size = new System.Drawing.Size(204, 21);
            this.cbSucursales.TabIndex = 1;
            this.cbSucursales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbSucursales_MouseDown);
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(116, 34);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(204, 21);
            this.cbUsuarios.TabIndex = 0;
            this.cbUsuarios.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbUsuarios_MouseDown);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(923, 504);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 122;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(1004, 504);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(105, 23);
            this.btnProcesar.TabIndex = 123;
            this.btnProcesar.Text = "Procesar Solicitud";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 84);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(373, 54);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Nota: El archivo que se adjunta en dicho modulo debe estar con extension csv. El " +
    "orden de las columnas son: fecha de operacion, dni cliente, email, nombre y apel" +
    "lido, localidad y telefono";
            // 
            // FrmCampana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 537);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblImportacionCampana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.resultadoImportacion);
            this.Name = "FrmCampana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Campaña";
            this.Load += new System.EventHandler(this.FrmCampaña_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultadoImportacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView resultadoImportacion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImportacionCampana;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbCampañaOrigenMarketing;
        private System.Windows.Forms.ComboBox cbRelacOrigen;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.Button btnAgregarSubCampana;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbSucursales;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbComercio;
        private System.Windows.Forms.RadioButton rbPrestamo;
        private System.Windows.Forms.TextBox textBox1;
    }
}