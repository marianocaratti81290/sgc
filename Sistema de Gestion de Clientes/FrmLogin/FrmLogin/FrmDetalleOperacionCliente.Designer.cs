namespace FrmLogin
{
    partial class FrmDetalleOperacionCliente
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.obtenerDetalleOperacionCliente_q_spBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GestionClienteOperacionDetallada = new FrmLogin.GestionClienteOperacionDetallada();
            this.label1 = new System.Windows.Forms.Label();
            this.obtenerDetalleOperacionCliente_q_spTableAdapter = new FrmLogin.GestionClienteOperacionDetalladaTableAdapters.obtenerDetalleOperacionCliente_q_spTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.obtenerDetalleOperacionCliente_q_spBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestionClienteOperacionDetallada)).BeginInit();
            this.SuspendLayout();
            // 
            // obtenerDetalleOperacionCliente_q_spBindingSource
            // 
            this.obtenerDetalleOperacionCliente_q_spBindingSource.DataMember = "obtenerDetalleOperacionCliente_q_sp";
            this.obtenerDetalleOperacionCliente_q_spBindingSource.DataSource = this.GestionClienteOperacionDetallada;
            // 
            // GestionClienteOperacionDetallada
            // 
            this.GestionClienteOperacionDetallada.DataSetName = "GestionClienteOperacionDetallada";
            this.GestionClienteOperacionDetallada.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(345, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 23);
            this.label1.TabIndex = 138;
            this.label1.Text = "Detalles de la operacion del cliente";
            // 
            // obtenerDetalleOperacionCliente_q_spTableAdapter
            // 
            this.obtenerDetalleOperacionCliente_q_spTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.obtenerDetalleOperacionCliente_q_spBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "FrmLogin.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(349, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 139;
            // 
            // FrmDetalleOperacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 357);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleOperacionCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario operacion del cliente";
            this.Load += new System.EventHandler(this.FrmDetalleOperacionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.obtenerDetalleOperacionCliente_q_spBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GestionClienteOperacionDetallada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource obtenerDetalleOperacionCliente_q_spBindingSource;
        private GestionClienteOperacionDetallada GestionClienteOperacionDetallada;
        private GestionClienteOperacionDetalladaTableAdapters.obtenerDetalleOperacionCliente_q_spTableAdapter obtenerDetalleOperacionCliente_q_spTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}