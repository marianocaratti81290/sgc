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
    public partial class FrmNuevaSucursal : Form
    {
        public FrmNuevaSucursal()
        {
            InitializeComponent();
        }

        public static string tpoContrato = "";
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAcecptar_Click(object sender, EventArgs e)
        {
            validarContrato();
            if (txtnombre.Text=="")
            {
                MessageBox.Show("Debe ingresar el nombre de la sucursal");
            }
            else
                if (cbEstado.Text=="")
                {
                    MessageBox.Show("Debe ingresar el estado de la sucursal");
                }
                else
                {
                    if (MessageBox.Show("Estas seguro que desea agregar la sucursal", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        Brl.agregarSucursal(txtnombre.Text,
                            txtDireccion.Text,
                            txttel_fijo.Text,
                            cbEstado.Text,
                            tpoContrato.ToString(),
                            dtpFecha.Text,
                            txtObservaciones.Text);
                        MessageBox.Show("La sucursal se agrego con exito");
                        limpiarCampos();
                    }
                }
        }

        private void limpiarCampos()
        {
            txtnombre.Clear();
            txtDireccion.Clear();
            txttel_fijo.Clear();
            txtObservaciones.Clear();
        }
        private void FrmNuevaSucursal_Load(object sender, EventArgs e)
        {
            cbEstado.SelectedIndex = 0;
        }

        private void validarContrato()
        {
            if (rbAlquiler.Checked == true)
            {
                tpoContrato = "Alquiler";
                lblContrato.Visible = true;
                dtpFecha.Visible = true;
            }
            else
            {
                tpoContrato = "Propio";
                lblContrato.Visible = false;
                dtpFecha.Visible = false;
               
            }
        }
                
        private void rbAlquiler_CheckedChanged(object sender, EventArgs e)
        {
            validarContrato();
        }

        private void txttel_fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
