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
    public partial class FrmObjetivosXusuario : Form
    {
        public FrmObjetivosXusuario()
        {
            InitializeComponent();
        }

        private void FrmObjetivosXusuario_Load(object sender, EventArgs e)
        {

        }

        private void mostrarGrillaUsuarios()
        {
            dgvGrillaUsuarios.DataSource = Brl.obtenerUsuarios();
         
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaUsuarios.DataSource = Brl.buscarUsuarioFiltrado(txtBuscar.Text);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaUsuarios.DataSource = Brl.buscarUsuarioFiltrado(txtBuscar.Text);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
