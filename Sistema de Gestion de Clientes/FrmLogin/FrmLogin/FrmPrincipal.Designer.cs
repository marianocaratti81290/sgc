namespace FrmLogin
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaGestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarGestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoricoUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarEstadoDeSucursalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importarCampañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objetivosPorSucursalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosPorUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.permisosPorFuncionalidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvCampanaUsuario = new System.Windows.Forms.DataGridView();
            this.gbCampana = new System.Windows.Forms.GroupBox();
            this.btnHabilitarCamp = new System.Windows.Forms.Button();
            this.btnDesHabilitarCamp = new System.Windows.Forms.Button();
            this.listadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeCampañasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampanaUsuario)).BeginInit();
            this.gbCampana.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.gestionesToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.sucursalesToolStripMenuItem,
            this.campañasToolStripMenuItem,
            this.listadoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.objetivosToolStripMenuItem,
            this.permisoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.modificarClienteToolStripMenuItem,
            this.consultarClienteToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // modificarClienteToolStripMenuItem
            // 
            this.modificarClienteToolStripMenuItem.Name = "modificarClienteToolStripMenuItem";
            this.modificarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.modificarClienteToolStripMenuItem.Text = "Modificar Cliente";
            this.modificarClienteToolStripMenuItem.Click += new System.EventHandler(this.modificarClienteToolStripMenuItem_Click);
            // 
            // consultarClienteToolStripMenuItem
            // 
            this.consultarClienteToolStripMenuItem.Name = "consultarClienteToolStripMenuItem";
            this.consultarClienteToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarClienteToolStripMenuItem.Text = "Consultar Cliente";
            this.consultarClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarClienteToolStripMenuItem_Click);
            // 
            // gestionesToolStripMenuItem
            // 
            this.gestionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaGestionToolStripMenuItem,
            this.modificarGestionToolStripMenuItem});
            this.gestionesToolStripMenuItem.Name = "gestionesToolStripMenuItem";
            this.gestionesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gestionesToolStripMenuItem.Text = "Gestiones";
            this.gestionesToolStripMenuItem.Click += new System.EventHandler(this.gestionesToolStripMenuItem_Click);
            // 
            // nuevaGestionToolStripMenuItem
            // 
            this.nuevaGestionToolStripMenuItem.Name = "nuevaGestionToolStripMenuItem";
            this.nuevaGestionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.nuevaGestionToolStripMenuItem.Text = "Nueva Gestion";
            this.nuevaGestionToolStripMenuItem.Click += new System.EventHandler(this.nuevaGestionToolStripMenuItem_Click);
            // 
            // modificarGestionToolStripMenuItem
            // 
            this.modificarGestionToolStripMenuItem.Name = "modificarGestionToolStripMenuItem";
            this.modificarGestionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.modificarGestionToolStripMenuItem.Text = "Modificar Gestion";
            this.modificarGestionToolStripMenuItem.Click += new System.EventHandler(this.modificarGestionToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeUsuariosToolStripMenuItem,
            this.modificacionDeUsuariosToolStripMenuItem,
            this.bajaDeUsuariosToolStripMenuItem,
            this.HistoricoUsuariosToolStripMenuItem,
            this.consultaDeUsuariosToolStripMenuItem1});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // altaDeUsuariosToolStripMenuItem
            // 
            this.altaDeUsuariosToolStripMenuItem.Name = "altaDeUsuariosToolStripMenuItem";
            this.altaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.altaDeUsuariosToolStripMenuItem.Text = "Alta de Usuarios";
            this.altaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.altaDeUsuariosToolStripMenuItem_Click);
            // 
            // modificacionDeUsuariosToolStripMenuItem
            // 
            this.modificacionDeUsuariosToolStripMenuItem.Name = "modificacionDeUsuariosToolStripMenuItem";
            this.modificacionDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.modificacionDeUsuariosToolStripMenuItem.Text = "Modificacion de usuarios";
            this.modificacionDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeUsuariosToolStripMenuItem_Click);
            // 
            // bajaDeUsuariosToolStripMenuItem
            // 
            this.bajaDeUsuariosToolStripMenuItem.Name = "bajaDeUsuariosToolStripMenuItem";
            this.bajaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.bajaDeUsuariosToolStripMenuItem.Text = "Baja de usuarios";
            this.bajaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.bajaDeUsuariosToolStripMenuItem_Click);
            // 
            // HistoricoUsuariosToolStripMenuItem
            // 
            this.HistoricoUsuariosToolStripMenuItem.Name = "HistoricoUsuariosToolStripMenuItem";
            this.HistoricoUsuariosToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.HistoricoUsuariosToolStripMenuItem.Text = "Historial usuarios logeados";
            this.HistoricoUsuariosToolStripMenuItem.Click += new System.EventHandler(this.HistoricoUsuariosToolStripMenuItem_Click);
            // 
            // consultaDeUsuariosToolStripMenuItem1
            // 
            this.consultaDeUsuariosToolStripMenuItem1.Name = "consultaDeUsuariosToolStripMenuItem1";
            this.consultaDeUsuariosToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
            this.consultaDeUsuariosToolStripMenuItem1.Text = "Consulta de usuarios";
            this.consultaDeUsuariosToolStripMenuItem1.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem1_Click);
            // 
            // sucursalesToolStripMenuItem
            // 
            this.sucursalesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeSucursalesToolStripMenuItem,
            this.modificacionDeSucursalesToolStripMenuItem,
            this.bajaDeSucursalesToolStripMenuItem,
            this.consultaDeSucursalesToolStripMenuItem,
            this.cambiarEstadoDeSucursalesToolStripMenuItem});
            this.sucursalesToolStripMenuItem.Name = "sucursalesToolStripMenuItem";
            this.sucursalesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.sucursalesToolStripMenuItem.Text = "Sucursales";
            // 
            // altaDeSucursalesToolStripMenuItem
            // 
            this.altaDeSucursalesToolStripMenuItem.Name = "altaDeSucursalesToolStripMenuItem";
            this.altaDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.altaDeSucursalesToolStripMenuItem.Text = "Alta de Sucursales";
            this.altaDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.altaDeSucursalesToolStripMenuItem_Click);
            // 
            // modificacionDeSucursalesToolStripMenuItem
            // 
            this.modificacionDeSucursalesToolStripMenuItem.Name = "modificacionDeSucursalesToolStripMenuItem";
            this.modificacionDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.modificacionDeSucursalesToolStripMenuItem.Text = "Modificacion de Sucursales";
            this.modificacionDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.modificacionDeSucursalesToolStripMenuItem_Click);
            // 
            // bajaDeSucursalesToolStripMenuItem
            // 
            this.bajaDeSucursalesToolStripMenuItem.Name = "bajaDeSucursalesToolStripMenuItem";
            this.bajaDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.bajaDeSucursalesToolStripMenuItem.Text = "Baja de Sucursales";
            this.bajaDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.bajaDeSucursalesToolStripMenuItem_Click);
            // 
            // consultaDeSucursalesToolStripMenuItem
            // 
            this.consultaDeSucursalesToolStripMenuItem.Name = "consultaDeSucursalesToolStripMenuItem";
            this.consultaDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.consultaDeSucursalesToolStripMenuItem.Text = "Consulta de Sucursales";
            this.consultaDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.consultaDeSucursalesToolStripMenuItem_Click);
            // 
            // cambiarEstadoDeSucursalesToolStripMenuItem
            // 
            this.cambiarEstadoDeSucursalesToolStripMenuItem.Name = "cambiarEstadoDeSucursalesToolStripMenuItem";
            this.cambiarEstadoDeSucursalesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.cambiarEstadoDeSucursalesToolStripMenuItem.Text = "Cambiar estado de Sucursales";
            this.cambiarEstadoDeSucursalesToolStripMenuItem.Click += new System.EventHandler(this.cambiarEstadoDeSucursalesToolStripMenuItem_Click);
            // 
            // campañasToolStripMenuItem
            // 
            this.campañasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importarCampañaToolStripMenuItem});
            this.campañasToolStripMenuItem.Name = "campañasToolStripMenuItem";
            this.campañasToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.campañasToolStripMenuItem.Text = "Campañas";
            // 
            // importarCampañaToolStripMenuItem
            // 
            this.importarCampañaToolStripMenuItem.Name = "importarCampañaToolStripMenuItem";
            this.importarCampañaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.importarCampañaToolStripMenuItem.Text = "Importar campaña";
            this.importarCampañaToolStripMenuItem.Click += new System.EventHandler(this.importarCampañaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Click += new System.EventHandler(this.reportesToolStripMenuItem_Click);
            // 
            // objetivosToolStripMenuItem
            // 
            this.objetivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.objetivosPorUsuarioToolStripMenuItem,
            this.objetivosPorSucursalToolStripMenuItem});
            this.objetivosToolStripMenuItem.Name = "objetivosToolStripMenuItem";
            this.objetivosToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.objetivosToolStripMenuItem.Text = "Objetivos";
            // 
            // objetivosPorUsuarioToolStripMenuItem
            // 
            this.objetivosPorUsuarioToolStripMenuItem.Name = "objetivosPorUsuarioToolStripMenuItem";
            this.objetivosPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.objetivosPorUsuarioToolStripMenuItem.Text = "Objetivos por usuario";
            this.objetivosPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.objetivosPorUsuarioToolStripMenuItem_Click);
            // 
            // objetivosPorSucursalToolStripMenuItem
            // 
            this.objetivosPorSucursalToolStripMenuItem.Name = "objetivosPorSucursalToolStripMenuItem";
            this.objetivosPorSucursalToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.objetivosPorSucursalToolStripMenuItem.Text = "Objetivos por sucursal";
            this.objetivosPorSucursalToolStripMenuItem.Click += new System.EventHandler(this.objetivosPorSucursalToolStripMenuItem_Click);
            // 
            // permisoToolStripMenuItem
            // 
            this.permisoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.permisosPorUsuarioToolStripMenuItem,
            this.permisosPorFuncionalidadToolStripMenuItem});
            this.permisoToolStripMenuItem.Name = "permisoToolStripMenuItem";
            this.permisoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.permisoToolStripMenuItem.Text = "Permiso";
            this.permisoToolStripMenuItem.Click += new System.EventHandler(this.permisoToolStripMenuItem_Click);
            // 
            // permisosPorUsuarioToolStripMenuItem
            // 
            this.permisosPorUsuarioToolStripMenuItem.Name = "permisosPorUsuarioToolStripMenuItem";
            this.permisosPorUsuarioToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.permisosPorUsuarioToolStripMenuItem.Text = "Permisos por Usuario";
            this.permisosPorUsuarioToolStripMenuItem.Click += new System.EventHandler(this.permisosPorUsuarioToolStripMenuItem_Click);
            // 
            // permisosPorFuncionalidadToolStripMenuItem
            // 
            this.permisosPorFuncionalidadToolStripMenuItem.Name = "permisosPorFuncionalidadToolStripMenuItem";
            this.permisosPorFuncionalidadToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.permisosPorFuncionalidadToolStripMenuItem.Text = "Permisos por Funcionalidad";
            this.permisosPorFuncionalidadToolStripMenuItem.Click += new System.EventHandler(this.permisosPorFuncionalidadToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // dgvCampanaUsuario
            // 
            this.dgvCampanaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampanaUsuario.Location = new System.Drawing.Point(13, 16);
            this.dgvCampanaUsuario.Name = "dgvCampanaUsuario";
            this.dgvCampanaUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCampanaUsuario.Size = new System.Drawing.Size(323, 596);
            this.dgvCampanaUsuario.TabIndex = 1;
            this.dgvCampanaUsuario.DoubleClick += new System.EventHandler(this.dgvCampanaUsuario_DoubleClick);
            // 
            // gbCampana
            // 
            this.gbCampana.Controls.Add(this.dgvCampanaUsuario);
            this.gbCampana.Location = new System.Drawing.Point(12, 67);
            this.gbCampana.Name = "gbCampana";
            this.gbCampana.Size = new System.Drawing.Size(352, 626);
            this.gbCampana.TabIndex = 2;
            this.gbCampana.TabStop = false;
            this.gbCampana.Text = "Proceso de campañas ";
            // 
            // btnHabilitarCamp
            // 
            this.btnHabilitarCamp.Location = new System.Drawing.Point(12, 38);
            this.btnHabilitarCamp.Name = "btnHabilitarCamp";
            this.btnHabilitarCamp.Size = new System.Drawing.Size(109, 23);
            this.btnHabilitarCamp.TabIndex = 3;
            this.btnHabilitarCamp.Text = "Ver campañas";
            this.btnHabilitarCamp.UseVisualStyleBackColor = true;
            this.btnHabilitarCamp.Visible = false;
            this.btnHabilitarCamp.Click += new System.EventHandler(this.btnHabilitarCamp_Click);
            // 
            // btnDesHabilitarCamp
            // 
            this.btnDesHabilitarCamp.Location = new System.Drawing.Point(127, 38);
            this.btnDesHabilitarCamp.Name = "btnDesHabilitarCamp";
            this.btnDesHabilitarCamp.Size = new System.Drawing.Size(128, 23);
            this.btnDesHabilitarCamp.TabIndex = 5;
            this.btnDesHabilitarCamp.Text = "Ocultar Campañas";
            this.btnDesHabilitarCamp.UseVisualStyleBackColor = true;
            this.btnDesHabilitarCamp.Click += new System.EventHandler(this.btnDesHabilitarCamp_Click);
            // 
            // listadoToolStripMenuItem
            // 
            this.listadoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeCampañasToolStripMenuItem});
            this.listadoToolStripMenuItem.Name = "listadoToolStripMenuItem";
            this.listadoToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.listadoToolStripMenuItem.Text = "Listado";
            // 
            // listadoDeCampañasToolStripMenuItem
            // 
            this.listadoDeCampañasToolStripMenuItem.Name = "listadoDeCampañasToolStripMenuItem";
            this.listadoDeCampañasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.listadoDeCampañasToolStripMenuItem.Text = "Listado de campañas";
            this.listadoDeCampañasToolStripMenuItem.Click += new System.EventHandler(this.listadoDeCampañasToolStripMenuItem_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.btnDesHabilitarCamp);
            this.Controls.Add(this.btnHabilitarCamp);
            this.Controls.Add(this.gbCampana);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Gestion de Clientes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampanaUsuario)).EndInit();
            this.gbCampana.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoricoUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem permisosPorFuncionalidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificacionDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarEstadoDeSucursalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaGestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosPorUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objetivosPorSucursalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarGestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campañasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importarCampañaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvCampanaUsuario;
        private System.Windows.Forms.GroupBox gbCampana;
        private System.Windows.Forms.Button btnHabilitarCamp;
        private System.Windows.Forms.Button btnDesHabilitarCamp;
        private System.Windows.Forms.ToolStripMenuItem listadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeCampañasToolStripMenuItem;
    }
}