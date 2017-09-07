namespace FrmLogin
{
    partial class FrmModificarGestionCliente
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPlazo = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.rbComercio = new System.Windows.Forms.RadioButton();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.rbPrestamo = new System.Windows.Forms.RadioButton();
            this.cbRelacOrigen = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvGrillaHistorialCliente = new System.Windows.Forms.DataGridView();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOperaciones = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaHistorialCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(648, 451);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 149;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(748, 451);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 148;
            this.btnGuardar.Text = "Modificar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPlazo);
            this.groupBox3.Controls.Add(this.cbEstado);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtPlazo);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtImporte);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(811, 78);
            this.groupBox3.TabIndex = 147;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles de Gestion";
            // 
            // cbPlazo
            // 
            this.cbPlazo.FormattingEnabled = true;
            this.cbPlazo.Items.AddRange(new object[] {
            "dia",
            "mes",
            "año"});
            this.cbPlazo.Location = new System.Drawing.Point(407, 30);
            this.cbPlazo.Name = "cbPlazo";
            this.cbPlazo.Size = new System.Drawing.Size(79, 21);
            this.cbPlazo.TabIndex = 156;
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Concretado",
            "Pendiente",
            "Rechazado"});
            this.cbEstado.Location = new System.Drawing.Point(654, 31);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 155;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 150;
            this.label7.Text = "Importe";
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(326, 31);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(74, 20);
            this.txtPlazo.TabIndex = 154;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 151;
            this.label8.Text = "Plazo";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(116, 31);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 153;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(556, 38);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 152;
            this.label9.Text = "Estado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.rbComercio);
            this.groupBox2.Controls.Add(this.cbOrigen);
            this.groupBox2.Controls.Add(this.rbPrestamo);
            this.groupBox2.Controls.Add(this.cbRelacOrigen);
            this.groupBox2.Controls.Add(this.txtOperaciones);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(811, 69);
            this.groupBox2.TabIndex = 146;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Como se entero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 147;
            this.label6.Text = "Origen";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(570, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 150;
            this.label10.Text = "Asignado a:";
            // 
            // rbComercio
            // 
            this.rbComercio.AutoSize = true;
            this.rbComercio.Location = new System.Drawing.Point(736, 30);
            this.rbComercio.Name = "rbComercio";
            this.rbComercio.Size = new System.Drawing.Size(69, 17);
            this.rbComercio.TabIndex = 149;
            this.rbComercio.TabStop = true;
            this.rbComercio.Text = "Comercio";
            this.rbComercio.UseVisualStyleBackColor = true;
            // 
            // cbOrigen
            // 
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(73, 26);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbOrigen.TabIndex = 148;
            // 
            // rbPrestamo
            // 
            this.rbPrestamo.AutoSize = true;
            this.rbPrestamo.Location = new System.Drawing.Point(654, 30);
            this.rbPrestamo.Name = "rbPrestamo";
            this.rbPrestamo.Size = new System.Drawing.Size(69, 17);
            this.rbPrestamo.TabIndex = 148;
            this.rbPrestamo.TabStop = true;
            this.rbPrestamo.Text = "Prestamo";
            this.rbPrestamo.UseVisualStyleBackColor = true;
            // 
            // cbRelacOrigen
            // 
            this.cbRelacOrigen.FormattingEnabled = true;
            this.cbRelacOrigen.Location = new System.Drawing.Point(200, 26);
            this.cbRelacOrigen.Name = "cbRelacOrigen";
            this.cbRelacOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbRelacOrigen.TabIndex = 149;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dgvGrillaHistorialCliente);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 236);
            this.groupBox1.TabIndex = 145;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Gestion";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(300, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(21, 23);
            this.btnBuscar.TabIndex = 147;
            this.btnBuscar.Text = "Ir";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvGrillaHistorialCliente
            // 
            this.dgvGrillaHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaHistorialCliente.Location = new System.Drawing.Point(9, 69);
            this.dgvGrillaHistorialCliente.Name = "dgvGrillaHistorialCliente";
            this.dgvGrillaHistorialCliente.ReadOnly = true;
            this.dgvGrillaHistorialCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrillaHistorialCliente.Size = new System.Drawing.Size(796, 161);
            this.dgvGrillaHistorialCliente.TabIndex = 143;
            this.dgvGrillaHistorialCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrillaHistorialCliente_CellContentClick);
            this.dgvGrillaHistorialCliente.SelectionChanged += new System.EventHandler(this.dgvGrillaHistorialCliente_SelectionChanged);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(96, 20);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(198, 20);
            this.txtDni.TabIndex = 142;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 141;
            this.label4.Text = "DNI:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 140;
            this.label3.Text = "Historial de operaciones del cliente";
            // 
            // txtOperaciones
            // 
            this.txtOperaciones.FormattingEnabled = true;
            this.txtOperaciones.Items.AddRange(new object[] {
            "Consulta",
            "Nuevo Prestamo",
            "Renovacion",
            "Paralelo"});
            this.txtOperaciones.Location = new System.Drawing.Point(396, 26);
            this.txtOperaciones.Name = "txtOperaciones";
            this.txtOperaciones.Size = new System.Drawing.Size(150, 21);
            this.txtOperaciones.TabIndex = 139;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(331, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Operacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 144;
            this.label1.Text = "Asistente para gestionar clientes";
            // 
            // FrmModificarGestionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 488);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmModificarGestionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario modificar Gestion del Cliente";
            this.Load += new System.EventHandler(this.FrmModificarGestionCliente_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaHistorialCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPlazo;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbComercio;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.RadioButton rbPrestamo;
        private System.Windows.Forms.ComboBox cbRelacOrigen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvGrillaHistorialCliente;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtOperaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}