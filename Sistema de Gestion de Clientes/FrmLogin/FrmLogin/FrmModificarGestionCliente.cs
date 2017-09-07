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
    public partial class FrmModificarGestionCliente : Form
    {
        public FrmModificarGestionCliente()
        {
            InitializeComponent();
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
            }

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
                }
            }
        }

        private void buscarCliente()
        {
            if (txtDni.Text != "")
            {
                dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
            }
           

        }

        private void dgvGrillaHistorialCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvGrillaHistorialCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrillaHistorialCliente.Rows.Count == 0)
            {
                MessageBox.Show("La grilla esta vacia");
            }
            else
            {

                if ((dgvGrillaHistorialCliente[1, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString()) != "")
                {
                    cbOrigen.Text = dgvGrillaHistorialCliente[4, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();
                    cbRelacOrigen.Text = dgvGrillaHistorialCliente[5, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();
                    txtOperaciones.Text = dgvGrillaHistorialCliente[2, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();
                    txtImporte.Text = dgvGrillaHistorialCliente[7, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();
                    txtPlazo.Text = dgvGrillaHistorialCliente[8, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();
                    cbEstado.Text = dgvGrillaHistorialCliente[6, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();

                    if (dgvGrillaHistorialCliente[3, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString() == "Otorgado en Sucursal")
                    {
                        rbPrestamo.Checked = true;
                    }
                    else
                    {
                        rbComercio.Checked = true;
                    }

                }


            }
        }

        private void FrmModificarGestionCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
             string guardar;
             string identificacion; 

            if (rbPrestamo.Checked == true)
            {
                guardar = "Otorgado en Sucursal";

            }
            else
            {
                guardar = "Otorgado en Comercio";
            }

            identificacion = dgvGrillaHistorialCliente[9, dgvGrillaHistorialCliente.CurrentCell.RowIndex].Value.ToString();

             Brl.modificarGestionCliente(                               txtDni.Text, 
                                                                        identificacion,                                                                      
                                                                        txtOperaciones.Text,
                                                                        guardar,
                                                                        cbOrigen.Text,
                                                                        cbRelacOrigen.Text,
                                                                        txtImporte.Text,
                                                                        txtPlazo.Text,
                                                                        cbPlazo.Text,
                                                                        cbEstado.Text
                                                                       );

                                            MessageBox.Show("La gestion se guardo con exito");

                                            dgvGrillaHistorialCliente.DataSource = Brl.obtenerHistorialCliente(txtDni.Text);
                                        
        }
    }
}
