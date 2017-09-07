namespace FrmLogin
{
    partial class FrmPermisoFuncionalidad
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dvgUsuariosOrigen = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dvgUsuariosDestino = new System.Windows.Forms.DataGridView();
            this.txtBuscar2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelegarPermisos = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuariosOrigen)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuariosDestino)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.dvgUsuariosOrigen);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 307);
            this.groupBox1.TabIndex = 121;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos Origen";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(360, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dvgUsuariosOrigen
            // 
            this.dvgUsuariosOrigen.AllowUserToAddRows = false;
            this.dvgUsuariosOrigen.AllowUserToOrderColumns = true;
            this.dvgUsuariosOrigen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuariosOrigen.Location = new System.Drawing.Point(6, 54);
            this.dvgUsuariosOrigen.Name = "dvgUsuariosOrigen";
            this.dvgUsuariosOrigen.ReadOnly = true;
            this.dvgUsuariosOrigen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUsuariosOrigen.Size = new System.Drawing.Size(429, 247);
            this.dvgUsuariosOrigen.TabIndex = 5;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(91, 25);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(249, 20);
            this.txtBuscar.TabIndex = 4;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Buscar Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 23);
            this.label1.TabIndex = 120;
            this.label1.Text = "Asistente para gestionar permisos por funcionalidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dvgUsuariosDestino);
            this.groupBox2.Controls.Add(this.txtBuscar2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(551, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 307);
            this.groupBox2.TabIndex = 122;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Permisos destino";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(360, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dvgUsuariosDestino
            // 
            this.dvgUsuariosDestino.AllowUserToAddRows = false;
            this.dvgUsuariosDestino.AllowUserToOrderColumns = true;
            this.dvgUsuariosDestino.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgUsuariosDestino.Location = new System.Drawing.Point(6, 54);
            this.dvgUsuariosDestino.Name = "dvgUsuariosDestino";
            this.dvgUsuariosDestino.ReadOnly = true;
            this.dvgUsuariosDestino.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgUsuariosDestino.Size = new System.Drawing.Size(429, 247);
            this.dvgUsuariosDestino.TabIndex = 5;
            // 
            // txtBuscar2
            // 
            this.txtBuscar2.Location = new System.Drawing.Point(91, 23);
            this.txtBuscar2.Name = "txtBuscar2";
            this.txtBuscar2.Size = new System.Drawing.Size(246, 20);
            this.txtBuscar2.TabIndex = 4;
            this.txtBuscar2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar2_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar Usuario";
            // 
            // btnDelegarPermisos
            // 
            this.btnDelegarPermisos.Location = new System.Drawing.Point(470, 198);
            this.btnDelegarPermisos.Name = "btnDelegarPermisos";
            this.btnDelegarPermisos.Size = new System.Drawing.Size(75, 56);
            this.btnDelegarPermisos.TabIndex = 123;
            this.btnDelegarPermisos.Text = "Delegar Permisos >>>>";
            this.btnDelegarPermisos.UseVisualStyleBackColor = true;
            this.btnDelegarPermisos.Click += new System.EventHandler(this.btnDelegarPermisos_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(911, 366);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 124;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmPermisoFuncionalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 401);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnDelegarPermisos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "FrmPermisoFuncionalidad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos por funcionalidad";
            this.Load += new System.EventHandler(this.FrmPermisoFuncionalidad_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuariosOrigen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgUsuariosDestino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dvgUsuariosOrigen;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dvgUsuariosDestino;
        private System.Windows.Forms.TextBox txtBuscar2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelegarPermisos;
        private System.Windows.Forms.Button btnVolver;
    }
}