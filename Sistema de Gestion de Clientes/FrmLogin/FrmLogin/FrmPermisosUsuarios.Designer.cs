namespace FrmLogin
{
    partial class FrmPermisosUsuarios
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.dvgUsuarios = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.checkConsultaCliente = new System.Windows.Forms.CheckBox();
            this.checkModificarCliente = new System.Windows.Forms.CheckBox();
            this.checkClientes = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.checkModificarGestion = new System.Windows.Forms.CheckBox();
            this.CheckGestiones = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.checkObjetivosUsuario = new System.Windows.Forms.CheckBox();
            this.checkObjetivosSucursales = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.checkImportarCampana = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkPermisoUsuario = new System.Windows.Forms.CheckBox();
            this.checkPermisoFuncionalidad = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkSucursalEstado = new System.Windows.Forms.CheckBox();
            this.checkSucursalConsulta = new System.Windows.Forms.CheckBox();
            this.checkSucursalBaja = new System.Windows.Forms.CheckBox();
            this.checkSucursalModificacion = new System.Windows.Forms.CheckBox();
            this.checkSucursalAlta = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkUsuarioConsulta = new System.Windows.Forms.CheckBox();
            this.checkUsuarioHistorico = new System.Windows.Forms.CheckBox();
            this.checkUsuarioBaja = new System.Windows.Forms.CheckBox();
            this.checkUsuarioModificacion = new System.Windows.Forms.CheckBox();
            this.checkUsuarioAlta = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkReportes = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 23);
            this.label1.TabIndex = 117;
            this.label1.Text = "Asistente para gestionar permisos de usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.cbFiltro);
            this.groupBox1.Controls.Add(this.dvgUsuarios);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(863, 182);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de usuarios";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(637, 25);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbFiltro
            // 
            this.cbFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Items.AddRange(new object[] {
            "Dni",
            "Apellido",
            "Nombre"});
            this.cbFiltro.Location = new System.Drawing.Point(149, 25);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cbFiltro.TabIndex = 6;
            // 
            // dvgUsuarios
            // 
            this.dvgUsuarios.AllowUserToAddRows = false;
            this.dvgUsuarios.AllowUserToOrderColumns = true;
            this.dvgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuarios.Location = new System.Drawing.Point(10, 54);
            this.dvgUsuarios.Name = "dvgUsuarios";
            this.dvgUsuarios.ReadOnly = true;
            this.dvgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUsuarios.Size = new System.Drawing.Size(841, 122);
            this.dvgUsuarios.TabIndex = 5;
            this.dvgUsuarios.SelectionChanged += new System.EventHandler(this.dvgUsuarios_SelectionChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(304, 26);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(316, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar Usuario";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVolver);
            this.groupBox2.Controls.Add(this.groupBox10);
            this.groupBox2.Controls.Add(this.groupBox9);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.groupBox6);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(13, 263);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(862, 248);
            this.groupBox2.TabIndex = 119;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos de usuario";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(780, 215);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 121;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.checkConsultaCliente);
            this.groupBox10.Controls.Add(this.checkModificarCliente);
            this.groupBox10.Controls.Add(this.checkClientes);
            this.groupBox10.Location = new System.Drawing.Point(15, 125);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(197, 113);
            this.groupBox10.TabIndex = 11;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Clientes";
            // 
            // checkConsultaCliente
            // 
            this.checkConsultaCliente.AutoSize = true;
            this.checkConsultaCliente.Location = new System.Drawing.Point(23, 75);
            this.checkConsultaCliente.Name = "checkConsultaCliente";
            this.checkConsultaCliente.Size = new System.Drawing.Size(117, 17);
            this.checkConsultaCliente.TabIndex = 2;
            this.checkConsultaCliente.Text = "Consulta de Cliente";
            this.checkConsultaCliente.UseVisualStyleBackColor = true;
            this.checkConsultaCliente.Click += new System.EventHandler(this.checkConsultaCliente_Click);
            // 
            // checkModificarCliente
            // 
            this.checkModificarCliente.AutoSize = true;
            this.checkModificarCliente.Location = new System.Drawing.Point(23, 48);
            this.checkModificarCliente.Name = "checkModificarCliente";
            this.checkModificarCliente.Size = new System.Drawing.Size(104, 17);
            this.checkModificarCliente.TabIndex = 1;
            this.checkModificarCliente.Text = "Modificar Cliente";
            this.checkModificarCliente.UseVisualStyleBackColor = true;
            this.checkModificarCliente.Click += new System.EventHandler(this.checkModificarCliente_Click);
            // 
            // checkClientes
            // 
            this.checkClientes.AutoSize = true;
            this.checkClientes.Location = new System.Drawing.Point(23, 24);
            this.checkClientes.Name = "checkClientes";
            this.checkClientes.Size = new System.Drawing.Size(93, 17);
            this.checkClientes.TabIndex = 0;
            this.checkClientes.Text = "Nuevo Cliente";
            this.checkClientes.UseVisualStyleBackColor = true;
            this.checkClientes.CheckedChanged += new System.EventHandler(this.checkClientes_CheckedChanged);
            this.checkClientes.Click += new System.EventHandler(this.checkClientes_Click);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.checkModificarGestion);
            this.groupBox9.Controls.Add(this.CheckGestiones);
            this.groupBox9.Location = new System.Drawing.Point(15, 20);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(197, 96);
            this.groupBox9.TabIndex = 10;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Gestion Clientes";
            // 
            // checkModificarGestion
            // 
            this.checkModificarGestion.AutoSize = true;
            this.checkModificarGestion.Location = new System.Drawing.Point(23, 55);
            this.checkModificarGestion.Name = "checkModificarGestion";
            this.checkModificarGestion.Size = new System.Drawing.Size(111, 17);
            this.checkModificarGestion.TabIndex = 2;
            this.checkModificarGestion.Text = "Modificar Gestion ";
            this.checkModificarGestion.UseVisualStyleBackColor = true;
            this.checkModificarGestion.Click += new System.EventHandler(this.checkModificarGestion_Click);
            // 
            // CheckGestiones
            // 
            this.CheckGestiones.AutoSize = true;
            this.CheckGestiones.Location = new System.Drawing.Point(23, 31);
            this.CheckGestiones.Name = "CheckGestiones";
            this.CheckGestiones.Size = new System.Drawing.Size(100, 17);
            this.CheckGestiones.TabIndex = 1;
            this.CheckGestiones.Text = "Nueva Gestion ";
            this.CheckGestiones.UseVisualStyleBackColor = true;
            this.CheckGestiones.Click += new System.EventHandler(this.CheckGestiones_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.checkObjetivosUsuario);
            this.groupBox8.Controls.Add(this.checkObjetivosSucursales);
            this.groupBox8.Location = new System.Drawing.Point(658, 113);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(197, 77);
            this.groupBox8.TabIndex = 9;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Objetivos";
            // 
            // checkObjetivosUsuario
            // 
            this.checkObjetivosUsuario.AutoSize = true;
            this.checkObjetivosUsuario.Location = new System.Drawing.Point(20, 44);
            this.checkObjetivosUsuario.Name = "checkObjetivosUsuario";
            this.checkObjetivosUsuario.Size = new System.Drawing.Size(125, 17);
            this.checkObjetivosUsuario.TabIndex = 2;
            this.checkObjetivosUsuario.Text = "Objetivos por usuario";
            this.checkObjetivosUsuario.UseVisualStyleBackColor = true;
            this.checkObjetivosUsuario.Click += new System.EventHandler(this.checkObjetivosUsuario_Click);
            // 
            // checkObjetivosSucursales
            // 
            this.checkObjetivosSucursales.AutoSize = true;
            this.checkObjetivosSucursales.Location = new System.Drawing.Point(21, 21);
            this.checkObjetivosSucursales.Name = "checkObjetivosSucursales";
            this.checkObjetivosSucursales.Size = new System.Drawing.Size(141, 17);
            this.checkObjetivosSucursales.TabIndex = 1;
            this.checkObjetivosSucursales.Text = "Objetivos por sucursales";
            this.checkObjetivosSucursales.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.checkImportarCampana);
            this.groupBox7.Location = new System.Drawing.Point(240, 185);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(182, 53);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Campaña";
            // 
            // checkImportarCampana
            // 
            this.checkImportarCampana.AutoSize = true;
            this.checkImportarCampana.Location = new System.Drawing.Point(21, 21);
            this.checkImportarCampana.Name = "checkImportarCampana";
            this.checkImportarCampana.Size = new System.Drawing.Size(112, 17);
            this.checkImportarCampana.TabIndex = 1;
            this.checkImportarCampana.Text = "Importar Campaña";
            this.checkImportarCampana.UseVisualStyleBackColor = true;
            this.checkImportarCampana.Click += new System.EventHandler(this.checkImportarCampana_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(820, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.checkPermisoUsuario);
            this.groupBox6.Controls.Add(this.checkPermisoFuncionalidad);
            this.groupBox6.Location = new System.Drawing.Point(658, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(197, 85);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Permisos";
            // 
            // checkPermisoUsuario
            // 
            this.checkPermisoUsuario.AutoSize = true;
            this.checkPermisoUsuario.Location = new System.Drawing.Point(20, 56);
            this.checkPermisoUsuario.Name = "checkPermisoUsuario";
            this.checkPermisoUsuario.Size = new System.Drawing.Size(123, 17);
            this.checkPermisoUsuario.TabIndex = 1;
            this.checkPermisoUsuario.Text = "Permisos por usuario";
            this.checkPermisoUsuario.UseVisualStyleBackColor = true;
            this.checkPermisoUsuario.Click += new System.EventHandler(this.checkPermisoUsuario_Click);
            // 
            // checkPermisoFuncionalidad
            // 
            this.checkPermisoFuncionalidad.AutoSize = true;
            this.checkPermisoFuncionalidad.Location = new System.Drawing.Point(20, 32);
            this.checkPermisoFuncionalidad.Name = "checkPermisoFuncionalidad";
            this.checkPermisoFuncionalidad.Size = new System.Drawing.Size(152, 17);
            this.checkPermisoFuncionalidad.TabIndex = 0;
            this.checkPermisoFuncionalidad.Text = "Permisos por funcionalidad";
            this.checkPermisoFuncionalidad.UseVisualStyleBackColor = true;
            this.checkPermisoFuncionalidad.Click += new System.EventHandler(this.checkPermisoFuncionalidad_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkSucursalEstado);
            this.groupBox5.Controls.Add(this.checkSucursalConsulta);
            this.groupBox5.Controls.Add(this.checkSucursalBaja);
            this.groupBox5.Controls.Add(this.checkSucursalModificacion);
            this.groupBox5.Controls.Add(this.checkSucursalAlta);
            this.groupBox5.Location = new System.Drawing.Point(452, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(182, 159);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sucursales";
            // 
            // checkSucursalEstado
            // 
            this.checkSucursalEstado.AutoSize = true;
            this.checkSucursalEstado.Location = new System.Drawing.Point(20, 127);
            this.checkSucursalEstado.Name = "checkSucursalEstado";
            this.checkSucursalEstado.Size = new System.Drawing.Size(116, 17);
            this.checkSucursalEstado.TabIndex = 4;
            this.checkSucursalEstado.Text = "Cambio de estados";
            this.checkSucursalEstado.UseVisualStyleBackColor = true;
            this.checkSucursalEstado.Click += new System.EventHandler(this.checkSucursalEstado_Click);
            // 
            // checkSucursalConsulta
            // 
            this.checkSucursalConsulta.AutoSize = true;
            this.checkSucursalConsulta.Location = new System.Drawing.Point(20, 103);
            this.checkSucursalConsulta.Name = "checkSucursalConsulta";
            this.checkSucursalConsulta.Size = new System.Drawing.Size(135, 17);
            this.checkSucursalConsulta.TabIndex = 3;
            this.checkSucursalConsulta.Text = "Consulta de sucursales";
            this.checkSucursalConsulta.UseVisualStyleBackColor = true;
            this.checkSucursalConsulta.Click += new System.EventHandler(this.checkSucursalConsulta_Click);
            // 
            // checkSucursalBaja
            // 
            this.checkSucursalBaja.AutoSize = true;
            this.checkSucursalBaja.Location = new System.Drawing.Point(20, 80);
            this.checkSucursalBaja.Name = "checkSucursalBaja";
            this.checkSucursalBaja.Size = new System.Drawing.Size(115, 17);
            this.checkSucursalBaja.TabIndex = 2;
            this.checkSucursalBaja.Text = "Baja de sucursales";
            this.checkSucursalBaja.UseVisualStyleBackColor = true;
            this.checkSucursalBaja.Click += new System.EventHandler(this.checkSucursalBaja_Click);
            // 
            // checkSucursalModificacion
            // 
            this.checkSucursalModificacion.AutoSize = true;
            this.checkSucursalModificacion.Location = new System.Drawing.Point(20, 56);
            this.checkSucursalModificacion.Name = "checkSucursalModificacion";
            this.checkSucursalModificacion.Size = new System.Drawing.Size(154, 17);
            this.checkSucursalModificacion.TabIndex = 1;
            this.checkSucursalModificacion.Text = "Modificacion de sucursales";
            this.checkSucursalModificacion.UseVisualStyleBackColor = true;
            this.checkSucursalModificacion.Click += new System.EventHandler(this.checkSucursalModificacion_Click);
            // 
            // checkSucursalAlta
            // 
            this.checkSucursalAlta.AutoSize = true;
            this.checkSucursalAlta.Location = new System.Drawing.Point(20, 32);
            this.checkSucursalAlta.Name = "checkSucursalAlta";
            this.checkSucursalAlta.Size = new System.Drawing.Size(112, 17);
            this.checkSucursalAlta.TabIndex = 0;
            this.checkSucursalAlta.Text = "Alta de sucursales";
            this.checkSucursalAlta.UseVisualStyleBackColor = true;
            this.checkSucursalAlta.Click += new System.EventHandler(this.checkSucursalAlta_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkUsuarioConsulta);
            this.groupBox4.Controls.Add(this.checkUsuarioHistorico);
            this.groupBox4.Controls.Add(this.checkUsuarioBaja);
            this.groupBox4.Controls.Add(this.checkUsuarioModificacion);
            this.groupBox4.Controls.Add(this.checkUsuarioAlta);
            this.groupBox4.Location = new System.Drawing.Point(240, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(182, 159);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuarios";
            // 
            // checkUsuarioConsulta
            // 
            this.checkUsuarioConsulta.AutoSize = true;
            this.checkUsuarioConsulta.Location = new System.Drawing.Point(15, 126);
            this.checkUsuarioConsulta.Name = "checkUsuarioConsulta";
            this.checkUsuarioConsulta.Size = new System.Drawing.Size(124, 17);
            this.checkUsuarioConsulta.TabIndex = 4;
            this.checkUsuarioConsulta.Text = "Consulta de usuarios";
            this.checkUsuarioConsulta.UseVisualStyleBackColor = true;
            this.checkUsuarioConsulta.CheckedChanged += new System.EventHandler(this.checkUsuarioConsulta_CheckedChanged);
            this.checkUsuarioConsulta.Click += new System.EventHandler(this.checkUsuarioConsulta_Click);
            // 
            // checkUsuarioHistorico
            // 
            this.checkUsuarioHistorico.AutoSize = true;
            this.checkUsuarioHistorico.Location = new System.Drawing.Point(15, 102);
            this.checkUsuarioHistorico.Name = "checkUsuarioHistorico";
            this.checkUsuarioHistorico.Size = new System.Drawing.Size(158, 17);
            this.checkUsuarioHistorico.TabIndex = 3;
            this.checkUsuarioHistorico.Text = "Historico usuarios logeados ";
            this.checkUsuarioHistorico.UseVisualStyleBackColor = true;
            this.checkUsuarioHistorico.Click += new System.EventHandler(this.checkUsuarioHistorico_Click);
            // 
            // checkUsuarioBaja
            // 
            this.checkUsuarioBaja.AutoSize = true;
            this.checkUsuarioBaja.Location = new System.Drawing.Point(15, 79);
            this.checkUsuarioBaja.Name = "checkUsuarioBaja";
            this.checkUsuarioBaja.Size = new System.Drawing.Size(104, 17);
            this.checkUsuarioBaja.TabIndex = 2;
            this.checkUsuarioBaja.Text = "Baja de usuarios";
            this.checkUsuarioBaja.UseVisualStyleBackColor = true;
            this.checkUsuarioBaja.Click += new System.EventHandler(this.checkUsuarioBaja_Click);
            // 
            // checkUsuarioModificacion
            // 
            this.checkUsuarioModificacion.AutoSize = true;
            this.checkUsuarioModificacion.Location = new System.Drawing.Point(15, 55);
            this.checkUsuarioModificacion.Name = "checkUsuarioModificacion";
            this.checkUsuarioModificacion.Size = new System.Drawing.Size(143, 17);
            this.checkUsuarioModificacion.TabIndex = 1;
            this.checkUsuarioModificacion.Text = "Modificacion de usuarios";
            this.checkUsuarioModificacion.UseVisualStyleBackColor = true;
            this.checkUsuarioModificacion.Click += new System.EventHandler(this.checkUsuarioModificacion_Click);
            // 
            // checkUsuarioAlta
            // 
            this.checkUsuarioAlta.AutoSize = true;
            this.checkUsuarioAlta.Location = new System.Drawing.Point(15, 31);
            this.checkUsuarioAlta.Name = "checkUsuarioAlta";
            this.checkUsuarioAlta.Size = new System.Drawing.Size(101, 17);
            this.checkUsuarioAlta.TabIndex = 0;
            this.checkUsuarioAlta.Text = "Alta de usuarios";
            this.checkUsuarioAlta.UseVisualStyleBackColor = true;
            this.checkUsuarioAlta.Click += new System.EventHandler(this.checkUsuarioAlta_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkReportes);
            this.groupBox3.Location = new System.Drawing.Point(455, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(179, 53);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Generales";
            // 
            // checkReportes
            // 
            this.checkReportes.AutoSize = true;
            this.checkReportes.Location = new System.Drawing.Point(17, 21);
            this.checkReportes.Name = "checkReportes";
            this.checkReportes.Size = new System.Drawing.Size(69, 17);
            this.checkReportes.TabIndex = 2;
            this.checkReportes.Text = "Reportes";
            this.checkReportes.UseVisualStyleBackColor = true;
            this.checkReportes.Click += new System.EventHandler(this.checkReportes_Click);
            // 
            // FrmPermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 513);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPermisosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistente para gestionar permisos de usuario";
            this.Load += new System.EventHandler(this.FrmPermisosUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuarios)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.DataGridView dvgUsuarios;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkPermisoUsuario;
        private System.Windows.Forms.CheckBox checkPermisoFuncionalidad;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkSucursalEstado;
        private System.Windows.Forms.CheckBox checkSucursalConsulta;
        private System.Windows.Forms.CheckBox checkSucursalBaja;
        private System.Windows.Forms.CheckBox checkSucursalModificacion;
        private System.Windows.Forms.CheckBox checkSucursalAlta;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkUsuarioConsulta;
        private System.Windows.Forms.CheckBox checkUsuarioHistorico;
        private System.Windows.Forms.CheckBox checkUsuarioBaja;
        private System.Windows.Forms.CheckBox checkUsuarioModificacion;
        private System.Windows.Forms.CheckBox checkUsuarioAlta;
        private System.Windows.Forms.CheckBox checkReportes;
        private System.Windows.Forms.CheckBox CheckGestiones;
        private System.Windows.Forms.CheckBox checkClientes;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox checkObjetivosUsuario;
        private System.Windows.Forms.CheckBox checkObjetivosSucursales;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox checkImportarCampana;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.CheckBox checkModificarGestion;
        private System.Windows.Forms.CheckBox checkConsultaCliente;
        private System.Windows.Forms.CheckBox checkModificarCliente;
    }
}