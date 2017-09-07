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
    public partial class FrmConsultaUsuarios : Form
    {
        public FrmConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaUsuarios_Load(object sender, EventArgs e)
        {
            mostrarGrillaUsuarios();
        }

        private void mostrarGrillaUsuarios()
        {            
            dgvGrillaUsuarios.DataSource = Brl.obtenerUsuarios();             
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaUsuarios.DataSource = Brl.buscarUsuarioFiltrado(txtBuscar.Text);

            }
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaUsuarios.DataSource = Brl.buscarUsuarioFiltrado(txtBuscar.Text);

            }
        }

        }
}
