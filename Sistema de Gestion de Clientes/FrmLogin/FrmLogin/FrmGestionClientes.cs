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
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void cbOrigen_MouseDown(object sender, MouseEventArgs e)
        {
            cbRelacOrigen.SelectedValue = "";
            cbRelacOrigen.Text = "";
            cbOrigen.DataSource = Brl.obtenerOrigen();           
            cbOrigen.ValueMember = "descripcion";           
            cbOrigen.DisplayMember = "descripcion";
        }

        private void cbRelacOrigen_MouseDown(object sender, MouseEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cbOrigen.SelectedItem).Row.ItemArray[0].ToString();

            cbRelacOrigen.DataSource = Brl.obtenerOrigenCorrespondiente(valor);
            //indicamos el valor de los miembros
            cbRelacOrigen.ValueMember = "descripcion";
            //se indica el valor a desplegar en el combobox
            cbRelacOrigen.DisplayMember = "descripcion";    
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}

           
        }

        private void txtDni_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                 int existeDni = Brl.validoDniClientes(txtDni.Text);
                 if (existeDni == 0)
                 {
                     MessageBox.Show("El cliente no existe en la base de datos");
                 }
                 else
                 {
                     buscarCliente();
                     buscarInforme();
                 }
            }
        }

        private void buscarCliente()
        {
            if (txtDni.Text != "")
            {
                dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
            }
            txtAApyn.DataSource = Brl.obtenerApynCliente(txtDni.Text);
            //indicamos el valor de los miembros
            txtAApyn.ValueMember = "apyn";
            //se indica el valor a desplegar en el combobox
            txtAApyn.DisplayMember = "apyn";
            
        }

        private void FrmGestionClientes_Load(object sender, EventArgs e)
        {
            if (FrmInformeClientesNuevos.gestionCompleta == true)
            {
                txtDni.Text = FrmInformeClientesNuevos.dniCliente;
                dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
            }
            dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);

            if (FrmPrincipal.SolicitoGestion == 1)
            {
                txtDni.Text = FrmPrincipal.dniCliente;
                dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
            }
            dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int existeDni = Brl.validoDniClientes(txtDni.Text);
            if (existeDni == 0)
            {
                MessageBox.Show("El cliente no existe en la base de datos");
            }
            else
            {
                buscarCliente();
                buscarInforme();
            }
            
            
            //if (txtDni.Text != "")
            //{
            //    dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
            //}
            //txtAApyn.DataSource = Brl.obtenerApynCliente(txtDni.Text);
            ////indicamos el valor de los miembros
            //txtAApyn.ValueMember = "apyn";
            ////se indica el valor a desplegar en el combobox
            //txtAApyn.DisplayMember = "apyn";
                     
        }

        private void buscarInforme()
        {


            DataTable dtInforme = new DataTable();
            dtInforme = Brl.obtenerInformesClienteSeleccionado(txtDni.Text);

            if (dtInforme.Rows.Count > 0)
            {

                txtScoreVeraz.Text = dtInforme.Rows[0][1].ToString();
                txtSiisa.Text = dtInforme.Rows[0][2].ToString();
                cbComentario.Text = dtInforme.Rows[0][3].ToString();
                cbComentario1.Text = dtInforme.Rows[0][5].ToString();
                cbComentario2.Text = dtInforme.Rows[0][6].ToString();

                if (cbComentario.Text != "")
                {
                    lblComentario1.Visible = true;
                    cbComentario1.Visible = true;
                }

                if (cbComentario2.Text != "")
                {
                    lblComentario2.Visible = true;
                    cbComentario2.Visible = true;
                }


                    
                  
            }


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese un dni");
            }

            else

                if (txtAApyn.Text == "")
                {
                    MessageBox.Show("El cliente no existe en el sistema");
                }

                else

                    if (txtOperaciones.SelectedValue == "")
                    {
                        MessageBox.Show("Seleccione un campo en la solapa operaciones");
                    }

                    else

                        if (cbPlazo.SelectedValue == "")
                        {
                            MessageBox.Show("Seleccione un campo en la solapa plazo");
                        }

                        else

                        if (rbComercio.Checked == false && rbPrestamo.Checked == false)
                        {
                            MessageBox.Show("Asigne tipo de prestamo");
                        }

                        else

                            if ((cbOrigen.SelectedValue == "") && (cbRelacOrigen.SelectedValue == ""))
                            {
                                MessageBox.Show("Ingrese un origen");
                            }

                            else

                                if (txtImporte.Text == "")
                                {
                                    MessageBox.Show("Ingrese un importe");
                                }

                                else

                                    if (txtPlazo.Text == "")
                                    {
                                        MessageBox.Show("Ingrese un plazo");
                                    }

                                    else

                                        if (txtAApyn.Text == "")
                                        {
                                            MessageBox.Show("El cliente no existe en la base de datos");
                                        }

                                        else

                                        if (cbEstado.SelectedValue == "")
                                        {
                                            MessageBox.Show("Seleccione un estado");
                                        }

                                        else
                                        {
                                            string tipoPrestamo;

                                            if (rbPrestamo.Checked==true)
                                            {
                                                tipoPrestamo = "S";
                                            }
                                            else
                                            {
                                                tipoPrestamo = "N";
                                            }

                                            Brl.guardarGestionCliente(txtDni.Text,
                                                                        txtAApyn.Text,
                                                                        txtOperaciones.Text,
                                                                        tipoPrestamo,
                                                                        cbOrigen.Text,
                                                                        cbRelacOrigen.Text,
                                                                        txtImporte.Text,
                                                                        txtPlazo.Text,
                                                                        cbPlazo.Text,
                                                                        cbEstado.Text,
                                                                        txtObservaciones.Text
                                                                       );



                                            MessageBox.Show("La gestion se guardo con exito");

                                            dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);

                                            if (FrmPrincipal.SolicitoGestion==1)
                                            {
                                                Brl.cambiarEstadoCampanaFinalizado(FrmPrincipal.dniCliente);

                                            }
                                        }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDetalleCliente_Click(object sender, EventArgs e)
        {
            new FrmDetalleOperacionCliente().ShowDialog();
            //if ((dgvGrillaHistorialCliente[1, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString()) != "")
            //{
            //   int id_operacion = Convert.ToInt32(dgvGrillaHistorialCliente[9, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString());
            //   int dni = Convert.ToInt32(dgvGrillaHistorialCliente[1, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString());
            //   new f

            //}




        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void rbComercio_Click(object sender, EventArgs e)
        {
            cbPlazo.Visible = false;
            cbComercioAdheridos.Visible = true;
            cbProductos.Visible = true;
            lblComercio.Visible = true;
            lblProducto.Visible = true;
        }

        private void rbPrestamo_Click(object sender, EventArgs e)
        {
            cbPlazo.Visible = true;
            cbComercioAdheridos.Visible = false;
            cbProductos.Visible = false;
            lblComercio.Visible = false;
            lblProducto.Visible = false;
        }


        
    }
}
