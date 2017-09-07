namespace FrmLogin
{
    partial class FrmAccesoSistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAccesoSistema));
            this.cancelar = new System.Windows.Forms.Button();
            this.acceder = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNoExito = new System.Windows.Forms.Label();
            this.lblExito = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(142, 409);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(75, 23);
            this.cancelar.TabIndex = 23;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // acceder
            // 
            this.acceder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceder.Location = new System.Drawing.Point(265, 409);
            this.acceder.Name = "acceder";
            this.acceder.Size = new System.Drawing.Size(75, 23);
            this.acceder.TabIndex = 22;
            this.acceder.Text = "Aceptar";
            this.acceder.UseVisualStyleBackColor = true;
            this.acceder.Click += new System.EventHandler(this.acceder_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(95, 357);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(68, 16);
            this.Label5.TabIndex = 30;
            this.Label5.Text = "Password";
            this.Label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(108, 304);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(55, 16);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Usuario";
            this.Label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(180, 353);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(150, 20);
            this.txtPass.TabIndex = 21;
            this.txtPass.UseSystemPasswordChar = true;
            this.txtPass.TextChanged += new System.EventHandler(this.txtPass_TextChanged);
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPass_KeyDown);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AcceptsTab = true;
            this.txtUsuario.Location = new System.Drawing.Point(180, 304);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(150, 20);
            this.txtUsuario.TabIndex = 20;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(71, 259);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(322, 13);
            this.Label3.TabIndex = 28;
            this.Label3.Text = "Ingrese el nombre de usuario y contraseña para acceder al sistema";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Label2.Location = new System.Drawing.Point(80, 61);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(301, 24);
            this.Label2.TabIndex = 26;
            this.Label2.Text = "Sistema de Gestión de Clientes";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(153, 108);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(144, 134);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 24;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lblNoExito
            // 
            this.lblNoExito.AutoSize = true;
            this.lblNoExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoExito.ForeColor = System.Drawing.Color.Red;
            this.lblNoExito.Location = new System.Drawing.Point(21, 22);
            this.lblNoExito.Name = "lblNoExito";
            this.lblNoExito.Size = new System.Drawing.Size(422, 13);
            this.lblNoExito.TabIndex = 43;
            this.lblNoExito.Text = "La conexion con la base de datos fracaso, consulte con su administrador";
            this.lblNoExito.Click += new System.EventHandler(this.lblNoExito_Click);
            // 
            // lblExito
            // 
            this.lblExito.AutoSize = true;
            this.lblExito.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExito.ForeColor = System.Drawing.Color.Black;
            this.lblExito.Location = new System.Drawing.Point(108, 9);
            this.lblExito.Name = "lblExito";
            this.lblExito.Size = new System.Drawing.Size(260, 13);
            this.lblExito.TabIndex = 42;
            this.lblExito.Text = "La conexion con la base de datos es exitosa";
            this.lblExito.Click += new System.EventHandler(this.lblExito_Click);
            // 
            // FrmAccesoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 462);
            this.Controls.Add(this.lblNoExito);
            this.Controls.Add(this.lblExito);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.acceder);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.PictureBox1);
            this.Name = "FrmAccesoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesion";
            this.Load += new System.EventHandler(this.FrmAccesoSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button cancelar;
        internal System.Windows.Forms.Button acceder;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtPass;
        internal System.Windows.Forms.TextBox txtUsuario;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Label lblNoExito;
        internal System.Windows.Forms.Label lblExito;
    }
}

