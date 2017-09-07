using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmLogin
{
    public partial class FrmModificarCliente : Form
    {
        public FrmModificarCliente()
        {
            InitializeComponent();
        }
                
        private void FrmModificarCliente_Load(object sender, EventArgs e)
        {
            dgvClientes.DataSource = Brl.obtenerGrillaCompletaCliente();        
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                try
                {
                    DataTable Cliente = new DataTable();
                    Cliente = Brl.buscarClienteCompletoFiltrado(cbFiltro.Text, txtBuscar.Text);
                    dgvClientes.DataSource = Brl.buscarClienteCompletoFiltrado(cbFiltro.Text, txtBuscar.Text);

                    if (Cliente.Rows.Count > 0)
                    {

                        txtNombre.Text = (dgvClientes[1, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtApellido.Text = (dgvClientes[2, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtDni.Text = (dgvClientes[3, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCuil2.Text = (dgvClientes[4, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        dtpNacimiento.Text = (dgvClientes[5, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        cbEstadoCivil.Text = (dgvClientes[6, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        cbSexo.Text = (dgvClientes[7, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodAreaDP.Text = (dgvClientes[8, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtTelDP.Text = (dgvClientes[9, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtRef1.Text = (dgvClientes[10, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodArea2DP.Text = (dgvClientes[11, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtTel2DP.Text = (dgvClientes[12, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtRef2.Text = (dgvClientes[13, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodAreaCelDP.Text = (dgvClientes[14, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCelDP.Text = (dgvClientes[15, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtRef3.Text = (dgvClientes[16, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCalle.Text = (dgvClientes[17, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtNumero.Text = (dgvClientes[18, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtEntre1.Text = (dgvClientes[19, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtEntre2.Text = (dgvClientes[20, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtPiso.Text = (dgvClientes[21, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtDepto.Text = (dgvClientes[22, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        cbLocalidad.Text = (dgvClientes[23, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        cbProvincia.Text = (dgvClientes[24, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtEmail.Text = (dgvClientes[25, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCp.Text = (dgvClientes[26, dgvClientes.CurrentCell.RowIndex].Value.ToString());

                        if (Convert.ToInt32((dgvClientes[28, dgvClientes.CurrentCell.RowIndex].Value.ToString())) == 1)
                        {
                            rbConTrabajo.Checked = true;
                            rbSinTrabajo.Checked = false;
                        }

                        else
                        {
                            rbSinTrabajo.Checked = true;
                            rbConTrabajo.Checked = false;
                        }

                        txtLugarTrabajo.Text = (dgvClientes[29, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtRubro.Text = (dgvClientes[30, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtTitulo.Text = (dgvClientes[31, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtObservacion.Text = (dgvClientes[32, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodAreaDL.Text = (dgvClientes[33, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtTelDL.Text = (dgvClientes[34, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtInt1.Text = (dgvClientes[35, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodArea2DL.Text = (dgvClientes[36, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtTel2DL.Text = (dgvClientes[33, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtInt2.Text = (dgvClientes[34, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodAreaCelDL.Text = (dgvClientes[35, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCelDL.Text = (dgvClientes[36, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCodAreaCel2DL.Text = (dgvClientes[33, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                        txtCel2DL.Text = (dgvClientes[34, dgvClientes.CurrentCell.RowIndex].Value.ToString());
               
                    }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }


            
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            DataTable Cliente = new DataTable();
            Cliente = Brl.obtenerGrillaCompletaCliente();

            if (Cliente.Rows.Count > 0)
            {

                txtNombre.Text = (dgvClientes[1, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtApellido.Text = (dgvClientes[2, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtDni.Text = (dgvClientes[3, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCuil2.Text = (dgvClientes[4, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                dtpNacimiento.Text = (dgvClientes[5, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                cbEstadoCivil.Text = (dgvClientes[6, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                cbSexo.Text = (dgvClientes[7, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodAreaDP.Text = (dgvClientes[8, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtTelDP.Text = (dgvClientes[9, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtRef1.Text = (dgvClientes[10, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodArea2DP.Text = (dgvClientes[11, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtTel2DP.Text = (dgvClientes[12, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtRef2.Text = (dgvClientes[13, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodAreaCelDP.Text = (dgvClientes[14, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCelDP.Text = (dgvClientes[15, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtRef3.Text = (dgvClientes[16, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCalle.Text = (dgvClientes[17, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtNumero.Text = (dgvClientes[18, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtEntre1.Text = (dgvClientes[19, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtEntre2.Text = (dgvClientes[20, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtPiso.Text = (dgvClientes[21, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtDepto.Text = (dgvClientes[22, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                cbLocalidad.Text = (dgvClientes[23, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                cbProvincia.Text = (dgvClientes[24, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtEmail.Text = (dgvClientes[25, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCp.Text = (dgvClientes[26, dgvClientes.CurrentCell.RowIndex].Value.ToString());

                if (Convert.ToInt32((dgvClientes[28, dgvClientes.CurrentCell.RowIndex].Value.ToString())) == 1)
                {
                    rbConTrabajo.Checked = true;
                    rbSinTrabajo.Checked = false;
                }

                else
                {
                    rbSinTrabajo.Checked = true;
                    rbConTrabajo.Checked = false;
                }
                    
                txtLugarTrabajo.Text = (dgvClientes[29, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtRubro.Text = (dgvClientes[30, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtTitulo.Text = (dgvClientes[31, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtObservacion.Text = (dgvClientes[32, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodAreaDL.Text = (dgvClientes[33, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtTelDL.Text = (dgvClientes[34, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtInt1.Text = (dgvClientes[35, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodArea2DL.Text = (dgvClientes[36, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtTel2DL.Text = (dgvClientes[33, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtInt2.Text = (dgvClientes[34, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodAreaCelDL.Text = (dgvClientes[35, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCelDL.Text = (dgvClientes[36, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCodAreaCel2DL.Text = (dgvClientes[33, dgvClientes.CurrentCell.RowIndex].Value.ToString());
                txtCel2DL.Text = (dgvClientes[34, dgvClientes.CurrentCell.RowIndex].Value.ToString());
               
            }
        }

       
    }
}
