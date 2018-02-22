namespace FrmLogin
{
    partial class FrmGestionClientes
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAApyn = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvGrillaHistorialCliente = new System.Windows.Forms.DataGridView();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOperaciones = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rbComercio = new System.Windows.Forms.RadioButton();
            this.rbPrestamo = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrigen = new System.Windows.Forms.ComboBox();
            this.cbRelacOrigen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPlazo = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtSiisa = new System.Windows.Forms.TextBox();
            this.cbComentario2 = new System.Windows.Forms.ComboBox();
            this.cbComentario1 = new System.Windows.Forms.ComboBox();
            this.cbComentario = new System.Windows.Forms.ComboBox();
            this.lblComentario2 = new System.Windows.Forms.Label();
            this.lblComentario1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtScoreVeraz = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.cbComercioAdheridos = new System.Windows.Forms.ComboBox();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.lblComercio = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaHistorialCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 23);
            this.label1.TabIndex = 137;
            this.label1.Text = "Asistente para gestionar clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(570, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 138;
            this.label2.Text = "Operacion:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAApyn);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dgvGrillaHistorialCliente);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtOperaciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(811, 184);
            this.groupBox1.TabIndex = 139;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nueva Gestion";
            // 
            // txtAApyn
            // 
            this.txtAApyn.BackColor = System.Drawing.SystemColors.Window;
            this.txtAApyn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.txtAApyn.Enabled = false;
            this.txtAApyn.FormattingEnabled = true;
            this.txtAApyn.Location = new System.Drawing.Point(376, 19);
            this.txtAApyn.Name = "txtAApyn";
            this.txtAApyn.Size = new System.Drawing.Size(156, 20);
            this.txtAApyn.TabIndex = 151;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(223, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(21, 23);
            this.btnBuscar.TabIndex = 147;
            this.btnBuscar.Text = "Ir";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 144;
            this.label5.Text = "Apellido y Nombre";
            // 
            // dgvGrillaHistorialCliente
            // 
            this.dgvGrillaHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaHistorialCliente.Location = new System.Drawing.Point(9, 69);
            this.dgvGrillaHistorialCliente.Name = "dgvGrillaHistorialCliente";
            this.dgvGrillaHistorialCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrillaHistorialCliente.Size = new System.Drawing.Size(796, 104);
            this.dgvGrillaHistorialCliente.TabIndex = 143;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(96, 20);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(121, 20);
            this.txtDni.TabIndex = 142;
            this.txtDni.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDni_KeyDown);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
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
            this.txtOperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtOperaciones.FormattingEnabled = true;
            this.txtOperaciones.Items.AddRange(new object[] {
            "Consulta",
            "Nuevo Prestamo",
            "Renovacion",
            "Paralelo"});
            this.txtOperaciones.Location = new System.Drawing.Point(635, 20);
            this.txtOperaciones.Name = "txtOperaciones";
            this.txtOperaciones.Size = new System.Drawing.Size(150, 21);
            this.txtOperaciones.TabIndex = 139;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 150;
            this.label10.Text = "Asignado a:";
            // 
            // rbComercio
            // 
            this.rbComercio.AutoSize = true;
            this.rbComercio.Location = new System.Drawing.Point(203, 62);
            this.rbComercio.Name = "rbComercio";
            this.rbComercio.Size = new System.Drawing.Size(69, 17);
            this.rbComercio.TabIndex = 149;
            this.rbComercio.Text = "Comercio";
            this.rbComercio.UseVisualStyleBackColor = true;
            this.rbComercio.Click += new System.EventHandler(this.rbComercio_Click);
            // 
            // rbPrestamo
            // 
            this.rbPrestamo.AutoSize = true;
            this.rbPrestamo.Checked = true;
            this.rbPrestamo.Location = new System.Drawing.Point(96, 62);
            this.rbPrestamo.Name = "rbPrestamo";
            this.rbPrestamo.Size = new System.Drawing.Size(69, 17);
            this.rbPrestamo.TabIndex = 148;
            this.rbPrestamo.TabStop = true;
            this.rbPrestamo.Text = "Prestamo";
            this.rbPrestamo.UseVisualStyleBackColor = true;
            this.rbPrestamo.Click += new System.EventHandler(this.rbPrestamo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 147;
            this.label6.Text = "Origen";
            // 
            // cbOrigen
            // 
            this.cbOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrigen.FormattingEnabled = true;
            this.cbOrigen.Location = new System.Drawing.Point(73, 27);
            this.cbOrigen.Name = "cbOrigen";
            this.cbOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbOrigen.TabIndex = 148;
            this.cbOrigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbOrigen_MouseDown);
            // 
            // cbRelacOrigen
            // 
            this.cbRelacOrigen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRelacOrigen.FormattingEnabled = true;
            this.cbRelacOrigen.Location = new System.Drawing.Point(259, 27);
            this.cbRelacOrigen.Name = "cbRelacOrigen";
            this.cbRelacOrigen.Size = new System.Drawing.Size(121, 21);
            this.cbRelacOrigen.TabIndex = 149;
            this.cbRelacOrigen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbRelacOrigen_MouseDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 150;
            this.label7.Text = "Importe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 151;
            this.label8.Text = "Plazo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 152;
            this.label9.Text = "Estado";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(73, 23);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(121, 20);
            this.txtImporte.TabIndex = 153;
            this.txtImporte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtImporte_KeyPress);
            // 
            // txtPlazo
            // 
            this.txtPlazo.Location = new System.Drawing.Point(73, 52);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(121, 20);
            this.txtPlazo.TabIndex = 154;
            this.txtPlazo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPlazo_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblProducto);
            this.groupBox2.Controls.Add(this.lblComercio);
            this.groupBox2.Controls.Add(this.cbComercioAdheridos);
            this.groupBox2.Controls.Add(this.cbProductos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.rbComercio);
            this.groupBox2.Controls.Add(this.cbOrigen);
            this.groupBox2.Controls.Add(this.rbPrestamo);
            this.groupBox2.Controls.Add(this.cbRelacOrigen);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 121);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Como se entero";
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
            this.groupBox3.Location = new System.Drawing.Point(406, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 121);
            this.groupBox3.TabIndex = 141;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles de Gestion";
            // 
            // cbPlazo
            // 
            this.cbPlazo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlazo.FormattingEnabled = true;
            this.cbPlazo.Items.AddRange(new object[] {
            "dia",
            "mes",
            "año"});
            this.cbPlazo.Location = new System.Drawing.Point(219, 51);
            this.cbPlazo.Name = "cbPlazo";
            this.cbPlazo.Size = new System.Drawing.Size(98, 21);
            this.cbPlazo.TabIndex = 156;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Concretado",
            "Pendiente",
            "Rechazado"});
            this.cbEstado.Location = new System.Drawing.Point(73, 80);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(121, 21);
            this.cbEstado.TabIndex = 155;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(330, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 142;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(230, 153);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 143;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSiisa);
            this.groupBox4.Controls.Add(this.cbComentario2);
            this.groupBox4.Controls.Add(this.cbComentario1);
            this.groupBox4.Controls.Add(this.cbComentario);
            this.groupBox4.Controls.Add(this.lblComentario2);
            this.groupBox4.Controls.Add(this.lblComentario1);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.txtScoreVeraz);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Location = new System.Drawing.Point(12, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(388, 188);
            this.groupBox4.TabIndex = 144;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informes";
            // 
            // txtSiisa
            // 
            this.txtSiisa.Location = new System.Drawing.Point(100, 56);
            this.txtSiisa.MaxLength = 5;
            this.txtSiisa.Name = "txtSiisa";
            this.txtSiisa.Size = new System.Drawing.Size(184, 20);
            this.txtSiisa.TabIndex = 57;
            // 
            // cbComentario2
            // 
            this.cbComentario2.FormattingEnabled = true;
            this.cbComentario2.Items.AddRange(new object[] {
            "",
            "Se solicita garante",
            "Sin trabajo",
            "Monotributista",
            "No llega MVM",
            "Mayor 75 años",
            "Informado por otra empresa",
            "Informado por otro banco",
            "Dni incorrecto",
            "Sin antiguedad laboral",
            "Ya posee credito",
            "Percibe asignacion universal por hijo"});
            this.cbComentario2.Location = new System.Drawing.Point(100, 143);
            this.cbComentario2.Name = "cbComentario2";
            this.cbComentario2.Size = new System.Drawing.Size(184, 21);
            this.cbComentario2.TabIndex = 54;
            // 
            // cbComentario1
            // 
            this.cbComentario1.FormattingEnabled = true;
            this.cbComentario1.Items.AddRange(new object[] {
            "",
            "Se solicita garante",
            "Sin trabajo",
            "Monotributista",
            "No llega MVM",
            "Mayor 75 años",
            "Informado por otra empresa",
            "Informado por otro banco",
            "Dni incorrecto",
            "Sin antiguedad laboral",
            "Ya posee credito",
            "Percibe asignacion universal por hijo"});
            this.cbComentario1.Location = new System.Drawing.Point(100, 113);
            this.cbComentario1.Name = "cbComentario1";
            this.cbComentario1.Size = new System.Drawing.Size(184, 21);
            this.cbComentario1.TabIndex = 53;
            // 
            // cbComentario
            // 
            this.cbComentario.FormattingEnabled = true;
            this.cbComentario.Items.AddRange(new object[] {
            "",
            "Se solicita garante",
            "Sin trabajo",
            "Monotributista",
            "No llega MVM",
            "Mayor 75 años",
            "Informado por otra empresa",
            "Informado por otro banco",
            "Dni incorrecto",
            "Sin antiguedad laboral",
            "Ya posee credito",
            "Percibe asignacion universal por hijo"});
            this.cbComentario.Location = new System.Drawing.Point(100, 83);
            this.cbComentario.Name = "cbComentario";
            this.cbComentario.Size = new System.Drawing.Size(184, 21);
            this.cbComentario.TabIndex = 52;
            // 
            // lblComentario2
            // 
            this.lblComentario2.AutoSize = true;
            this.lblComentario2.Location = new System.Drawing.Point(6, 146);
            this.lblComentario2.Name = "lblComentario2";
            this.lblComentario2.Size = new System.Drawing.Size(77, 13);
            this.lblComentario2.TabIndex = 51;
            this.lblComentario2.Text = "Comentarios 3:";
            this.lblComentario2.Visible = false;
            // 
            // lblComentario1
            // 
            this.lblComentario1.AutoSize = true;
            this.lblComentario1.Location = new System.Drawing.Point(6, 116);
            this.lblComentario1.Name = "lblComentario1";
            this.lblComentario1.Size = new System.Drawing.Size(77, 13);
            this.lblComentario1.TabIndex = 50;
            this.lblComentario1.Text = "Comentarios 2:";
            this.lblComentario1.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(226, -35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 24);
            this.label11.TabIndex = 49;
            this.label11.Text = "Informe Local";
            // 
            // txtScoreVeraz
            // 
            this.txtScoreVeraz.Location = new System.Drawing.Point(100, 30);
            this.txtScoreVeraz.MaxLength = 5;
            this.txtScoreVeraz.Name = "txtScoreVeraz";
            this.txtScoreVeraz.Size = new System.Drawing.Size(184, 20);
            this.txtScoreVeraz.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Comentarios 1:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Score Siisa:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Score Veraz:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtObservaciones);
            this.groupBox5.Controls.Add(this.btnVolver);
            this.groupBox5.Controls.Add(this.btnGuardar);
            this.groupBox5.Location = new System.Drawing.Point(406, 380);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(417, 188);
            this.groupBox5.TabIndex = 145;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Observaciones";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(9, 24);
            this.txtObservaciones.MaxLength = 200;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(402, 123);
            this.txtObservaciones.TabIndex = 145;
            // 
            // cbComercioAdheridos
            // 
            this.cbComercioAdheridos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbComercioAdheridos.FormattingEnabled = true;
            this.cbComercioAdheridos.Location = new System.Drawing.Point(73, 90);
            this.cbComercioAdheridos.Name = "cbComercioAdheridos";
            this.cbComercioAdheridos.Size = new System.Drawing.Size(121, 21);
            this.cbComercioAdheridos.TabIndex = 151;
            this.cbComercioAdheridos.Visible = false;
            // 
            // cbProductos
            // 
            this.cbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(259, 89);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(121, 21);
            this.cbProductos.TabIndex = 152;
            this.cbProductos.Visible = false;
            // 
            // lblComercio
            // 
            this.lblComercio.AutoSize = true;
            this.lblComercio.Location = new System.Drawing.Point(6, 92);
            this.lblComercio.Name = "lblComercio";
            this.lblComercio.Size = new System.Drawing.Size(54, 13);
            this.lblComercio.TabIndex = 153;
            this.lblComercio.Text = "Comercio:";
            this.lblComercio.Visible = false;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(200, 93);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(53, 13);
            this.lblProducto.TabIndex = 154;
            this.lblProducto.Text = "Producto:";
            this.lblProducto.Visible = false;
            // 
            // FrmGestionClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 576);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmGestionClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de clientes";
            this.Load += new System.EventHandler(this.FrmGestionClientes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaHistorialCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvGrillaHistorialCliente;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtOperaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbOrigen;
        private System.Windows.Forms.ComboBox cbRelacOrigen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton rbComercio;
        private System.Windows.Forms.RadioButton rbPrestamo;
        private System.Windows.Forms.ComboBox cbEstado;
        public System.Windows.Forms.ComboBox txtAApyn;
        private System.Windows.Forms.ComboBox cbPlazo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtSiisa;
        private System.Windows.Forms.ComboBox cbComentario2;
        private System.Windows.Forms.ComboBox cbComentario1;
        private System.Windows.Forms.ComboBox cbComentario;
        private System.Windows.Forms.Label lblComentario2;
        private System.Windows.Forms.Label lblComentario1;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtScoreVeraz;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ComboBox cbComercioAdheridos;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblComercio;
    }
}