namespace FrmLogin
{
    partial class FrmInformeClientesNuevos
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
            this.txtSiisa = new System.Windows.Forms.TextBox();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.btnComentario2 = new System.Windows.Forms.Button();
            this.btnComentario1 = new System.Windows.Forms.Button();
            this.cbComentario2 = new System.Windows.Forms.ComboBox();
            this.cbComentario1 = new System.Windows.Forms.ComboBox();
            this.cbComentario = new System.Windows.Forms.ComboBox();
            this.lblComentario2 = new System.Windows.Forms.Label();
            this.lblComentario1 = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGuardarContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSiisa
            // 
            this.txtSiisa.Location = new System.Drawing.Point(95, 165);
            this.txtSiisa.MaxLength = 5;
            this.txtSiisa.Name = "txtSiisa";
            this.txtSiisa.Size = new System.Drawing.Size(184, 20);
            this.txtSiisa.TabIndex = 59;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(405, 209);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(99, 23);
            this.txtGuardar.TabIndex = 58;
            this.txtGuardar.Text = "Guardar y Salir";
            this.txtGuardar.UseVisualStyleBackColor = true;
            this.txtGuardar.Click += new System.EventHandler(this.txtGuardar_Click);
            // 
            // btnComentario2
            // 
            this.btnComentario2.Location = new System.Drawing.Point(595, 98);
            this.btnComentario2.Name = "btnComentario2";
            this.btnComentario2.Size = new System.Drawing.Size(21, 23);
            this.btnComentario2.TabIndex = 57;
            this.btnComentario2.Text = "+";
            this.btnComentario2.UseVisualStyleBackColor = true;
            this.btnComentario2.Visible = false;
            this.btnComentario2.Click += new System.EventHandler(this.btnComentario2_Click);
            // 
            // btnComentario1
            // 
            this.btnComentario1.Location = new System.Drawing.Point(595, 65);
            this.btnComentario1.Name = "btnComentario1";
            this.btnComentario1.Size = new System.Drawing.Size(21, 23);
            this.btnComentario1.TabIndex = 56;
            this.btnComentario1.Text = "+";
            this.btnComentario1.UseVisualStyleBackColor = true;
            this.btnComentario1.Click += new System.EventHandler(this.btnComentario1_Click);
            // 
            // cbComentario2
            // 
            this.cbComentario2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbComentario2.Location = new System.Drawing.Point(405, 134);
            this.cbComentario2.Name = "cbComentario2";
            this.cbComentario2.Size = new System.Drawing.Size(184, 21);
            this.cbComentario2.TabIndex = 55;
            this.cbComentario2.Visible = false;
            // 
            // cbComentario1
            // 
            this.cbComentario1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbComentario1.Location = new System.Drawing.Point(405, 98);
            this.cbComentario1.Name = "cbComentario1";
            this.cbComentario1.Size = new System.Drawing.Size(184, 21);
            this.cbComentario1.TabIndex = 54;
            this.cbComentario1.Visible = false;
            // 
            // cbComentario
            // 
            this.cbComentario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.cbComentario.Location = new System.Drawing.Point(405, 65);
            this.cbComentario.Name = "cbComentario";
            this.cbComentario.Size = new System.Drawing.Size(184, 21);
            this.cbComentario.TabIndex = 53;
            // 
            // lblComentario2
            // 
            this.lblComentario2.AutoSize = true;
            this.lblComentario2.Location = new System.Drawing.Point(311, 137);
            this.lblComentario2.Name = "lblComentario2";
            this.lblComentario2.Size = new System.Drawing.Size(77, 13);
            this.lblComentario2.TabIndex = 52;
            this.lblComentario2.Text = "Comentarios 3:";
            this.lblComentario2.Visible = false;
            // 
            // lblComentario1
            // 
            this.lblComentario1.AutoSize = true;
            this.lblComentario1.Location = new System.Drawing.Point(311, 101);
            this.lblComentario1.Name = "lblComentario1";
            this.lblComentario1.Size = new System.Drawing.Size(77, 13);
            this.lblComentario1.TabIndex = 51;
            this.lblComentario1.Text = "Comentarios 2:";
            this.lblComentario1.Visible = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(324, 209);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 50;
            this.btnVolver.Text = "Salir";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(252, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 24);
            this.label7.TabIndex = 49;
            this.label7.Text = "Informe Local";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(95, 133);
            this.txtDni.Name = "txtDni";
            this.txtDni.ReadOnly = true;
            this.txtDni.Size = new System.Drawing.Size(184, 20);
            this.txtDni.TabIndex = 47;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(95, 100);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(184, 20);
            this.txtApellido.TabIndex = 46;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(95, 65);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(184, 20);
            this.txtNombre.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(311, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Comentarios 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Score Siisa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Dni:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Nombre:";
            // 
            // txtGuardarContinuar
            // 
            this.txtGuardarContinuar.Location = new System.Drawing.Point(510, 209);
            this.txtGuardarContinuar.Name = "txtGuardarContinuar";
            this.txtGuardarContinuar.Size = new System.Drawing.Size(123, 23);
            this.txtGuardarContinuar.TabIndex = 61;
            this.txtGuardarContinuar.Text = "Guardar y Continuar";
            this.txtGuardarContinuar.UseVisualStyleBackColor = true;
            this.txtGuardarContinuar.Click += new System.EventHandler(this.txtGuardarContinuar_Click);
            // 
            // FrmInformeClientesNuevos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 244);
            this.Controls.Add(this.txtGuardarContinuar);
            this.Controls.Add(this.txtSiisa);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.btnComentario2);
            this.Controls.Add(this.btnComentario1);
            this.Controls.Add(this.cbComentario2);
            this.Controls.Add(this.cbComentario1);
            this.Controls.Add(this.cbComentario);
            this.Controls.Add(this.lblComentario2);
            this.Controls.Add(this.lblComentario1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmInformeClientesNuevos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de Informe Siisa";
            this.Load += new System.EventHandler(this.FrmInformeClientesNuevos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiisa;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.Button btnComentario2;
        private System.Windows.Forms.Button btnComentario1;
        private System.Windows.Forms.ComboBox cbComentario2;
        private System.Windows.Forms.ComboBox cbComentario1;
        private System.Windows.Forms.ComboBox cbComentario;
        private System.Windows.Forms.Label lblComentario2;
        private System.Windows.Forms.Label lblComentario1;
        private System.Windows.Forms.Button btnVolver;
        internal System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtGuardarContinuar;
    }
}