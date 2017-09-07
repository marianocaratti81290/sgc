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
    public partial class FrmInformeClientesNuevos : Form
    {
        public FrmInformeClientesNuevos()
        {
            InitializeComponent();
        }

        public static string dniCliente;

        public static bool gestionCompleta;
        private void FrmInformeClientesNuevos_Load(object sender, EventArgs e)
        {
            DataTable dtInforme = new DataTable();
            dtInforme = Brl.obtenerInformesNuevo(FrmClientes.dniCliente);

            if (dtInforme.Rows.Count > 0)
            {

                txtNombre.Text = dtInforme.Rows[0]["nombre"].ToString();
                txtApellido.Text = dtInforme.Rows[0]["apellido"].ToString();
                txtDni.Text = dtInforme.Rows[0]["dni"].ToString();                
                
            }

            if (cbComentario1.Text != "")
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

        private void btnComentario1_Click(object sender, EventArgs e)
        {
            lblComentario1.Visible = true;
            cbComentario1.Visible = true;
            btnComentario2.Visible = true;
        }

        private void btnComentario2_Click(object sender, EventArgs e)
        {
            lblComentario2.Visible = true;
            cbComentario2.Visible = true;
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
             if (txtNombre.Text == "" )
            {
                MessageBox.Show("Ingrese el nombre");
            }
            else
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido");
                }
                else
                {
                    if (MessageBox.Show("Estas seguro que desea modificar el informe del cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Brl.modificarApynCliente(txtDni.Text, txtNombre.Text, txtApellido.Text);
                        Brl.guardarInformeClienteNuevo(txtDni.Text, txtSiisa.Text, cbComentario.Text, cbComentario1.Text, cbComentario2.Text);
                        MessageBox.Show("La operacion se realizo con exito");
                    }
                    }
                

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtGuardarContinuar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingrese el nombre");
            }
            else
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido");
                }
                else
                {
                    if (MessageBox.Show("Estas seguro que desea guardar el informe del cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Brl.modificarApynCliente(txtDni.Text, txtNombre.Text, txtApellido.Text);
                        Brl.guardarInformeClienteNuevo(txtDni.Text, txtSiisa.Text, cbComentario.Text, cbComentario1.Text, cbComentario2.Text);
                        MessageBox.Show("La operacion se realizo con exito");
                    }
                }

            gestionCompleta = true;
            dniCliente = txtDni.Text;
            this.Hide();
            new FrmGestionClientes().ShowDialog();
        }
        
    }
}
