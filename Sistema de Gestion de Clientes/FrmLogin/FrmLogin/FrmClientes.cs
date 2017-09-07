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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        public static string dniCliente;

        public static bool gestionCompleta;
        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {               
                guardarCliente();
                gestionCompleta = false;
                this.Hide();
            }
        }


        private void guardarCliente()
        {
           // rbConTrabajo.Checked = true;

          
        }

        private void rbSinTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSinTrabajo.Checked == true)
            {
                txtLugarTrabajo.ReadOnly = true;
                txtRubro.ReadOnly = true;
                txtTitulo.ReadOnly = true;
                txtObservacion.ReadOnly = true;
                txtCodAreaDL.ReadOnly = true;
                txtTelDL.ReadOnly = true;
                txtCodArea2DL.ReadOnly = true;
                txtTel2DL.ReadOnly = true;
                txtCodAreaCelDL.ReadOnly = true;
                txtCel2DL.ReadOnly = true;
                txtCelDL.ReadOnly = true;
                txtCodAreaCel2DL.ReadOnly = true;
            }
            else
            {
                txtLugarTrabajo.ReadOnly = false;
                txtRubro.ReadOnly = false;
                txtTitulo.ReadOnly = false;
                txtObservacion.ReadOnly = false;
                txtCodAreaDL.ReadOnly = false;
                txtTelDL.ReadOnly = false;
                txtCodArea2DL.ReadOnly = false;
                txtTel2DL.ReadOnly = false;
                txtCodAreaCelDL.ReadOnly = false;
                txtCel2DL.ReadOnly = false;
                txtCelDL.ReadOnly = false;
                txtCodAreaCel2DL.ReadOnly = false;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodAreaDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodAreaCelDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCelDP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodAreaDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodArea2DL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTel2DL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodAreaCelDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCelDL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCodAreaCel2DL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCel2DL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

             

        private void cbLocalidad_MouseDown(object sender, MouseEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cbProvincia.SelectedItem).Row.ItemArray[0].ToString();

            cbLocalidad.DataSource = Brl.obtenerLocalidadCorrespondiente(valor);
            //indicamos el valor de los miembros
            cbLocalidad.ValueMember = "localidad";
            //se indica el valor a desplegar en el combobox
            cbLocalidad.DisplayMember = "localidad";         
        }

        private void cbProvincia_MouseDown(object sender, MouseEventArgs e)
        {
            cbLocalidad.SelectedValue= "";
            cbLocalidad.Text = "";
            cbProvincia.DataSource = Brl.ObtenerProvincias();
            //indicamos el valor de los miembros
            cbProvincia.ValueMember = "provincia";
            //se indica el valor a desplegar en el combobox
            cbProvincia.DisplayMember = "provincia";
            
        }

        private void btnCp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.nexo.com.ar/codigosPostales.asp");
            }
            catch { }
        }

        private void txtGuardarContinuar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (rbConTrabajo.Checked == true && txtLugarTrabajo.Text == "" && txtRubro.Text == "")
                {

                    MessageBox.Show("Ingrese los datos laborales");

                }
                else


                    if (txtNombre.Text == "")
                    {
                        MessageBox.Show("Ingrese el Nombre del cliente");
                    }
                    else
                        if (txtApellido.Text == "")
                        {
                            MessageBox.Show("Ingrese el apellido del cliente");
                        }
                        else
                            if (txtDni.Text == "")
                            {
                                MessageBox.Show("Ingrese el dni del cliente");
                            }
                            else

                                if (txtDni.Text != "")
                                {
                                    int existeDni = Brl.validoDniClientes(txtDni.Text);
                                    if (existeDni == 0)
                                    {
                                        string situacionLaboral;

                                        if (rbConTrabajo.Checked == true)
                                        {
                                            situacionLaboral = "1";
                                        }
                                        else
                                        {
                                            situacionLaboral = "0";
                                            txtLugarTrabajo.Text = "No posee";
                                            txtRubro.Text = "No posee";
                                            txtTitulo.Text = "No posee";
                                            txtObservacion.Text = "No posee";
                                            txtCodAreaDL.Text = "0";
                                            txtTelDL.Text = "0";
                                            txtInt1.Text = "0";
                                            txtCodArea2DL.Text = "0";
                                            txtTel2DL.Text = "0";
                                            txtInt2.Text = "0";
                                            txtCodAreaCelDL.Text = "0";
                                            txtCelDL.Text = "0";
                                            txtCodAreaCel2DL.Text = "0";
                                            txtCel2DL.Text = "0";

                                        }



                                        Brl.nuevoCliente(
                                            txtNombre.Text,
                                            txtApellido.Text,
                                            txtDni.Text,
                                            txtCuil1.Text,
                                            txtCuil2.Text,
                                            txtCuil3.Text,
                                            Convert.ToDateTime(dtpNacimiento.Text),
                                            cbEstadoCivil.Text,
                                            cbSexo.Text,
                                            txtCodAreaDP.Text,
                                            txtTelDP.Text,
                                            txtRef1.Text,
                                            txtCodArea2DP.Text,
                                            txtTel2DP.Text,
                                            txtRef2.Text,
                                            txtCodAreaCelDP.Text,
                                            txtCelDP.Text,
                                            txtRef3.Text,
                                            txtCalle.Text,
                                            txtNumero.Text,
                                            txtEntre1.Text,
                                            txtEntre2.Text,
                                            txtPiso.Text,
                                            txtDepto.Text,
                                            cbLocalidad.Text,
                                            cbProvincia.Text,
                                            txtEmail.Text,
                                            txtCp.Text,
                                            situacionLaboral,
                                            txtLugarTrabajo.Text,
                                            txtRubro.Text,
                                            txtTitulo.Text,
                                            txtObservacion.Text,
                                            txtCodAreaDL.Text,
                                            txtTelDL.Text,
                                            txtInt1.Text,
                                            txtCodArea2DL.Text,
                                            txtTel2DL.Text,
                                            txtInt2.Text,
                                            txtCodAreaCelDL.Text,
                                            txtCelDL.Text,
                                            txtCodAreaCel2DL.Text,
                                            txtCel2DL.Text
                                            );

                                        MessageBox.Show("El cliente se grabo correctamente");
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Ya existe el cliente en la base de datos");
                                    }


                                    {
                                        //    Brl.agregarCliente(txtNombre,txtApellido,txtDni,dtpNacimiento,cbEstadoCivil,cbSexo,txtCodAreaDP,txtTelDP, txtCodAreaCelDP,txtCelDP,txtDomicilio,cbLocalidad,cbProvincia,txtEmail,txtCp );
                                    }

                                    gestionCompleta = true;
                                    dniCliente = txtDni.Text;
                                    this.Hide();
                                    new FrmInformeClientesNuevos().ShowDialog();
                                }
               
            }
        }

        private void txtCuil1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuil2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCuil3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDepto_TextChanged(object sender, EventArgs e)
        {

        }

       

      
    }
}
