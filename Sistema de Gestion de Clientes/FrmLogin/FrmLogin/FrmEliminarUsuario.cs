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
    public partial class FrmEliminarUsuario : Form
    {
        public FrmEliminarUsuario()
        {
            InitializeComponent();
        }

        public static int id_usuario;

        private void FrmEliminarUsuario_Load(object sender, EventArgs e)
        {
            grillaUsuario();
        }

        private void grillaUsuario()
        {
            dgvGrillaUsuarios.DataSource= Brl.obtenerUsuarios();
            cbFiltro.SelectedIndex = 0;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaUsuarios.DataSource = Brl.buscarUsuarioFiltrado2(cbFiltro.Text, txtBuscar.Text);                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar el usuario", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                if ((dgvGrillaUsuarios[1, dgvGrillaUsuarios.CurrentCell.RowIndex].Value.ToString()) != "")                       
                {
                    id_usuario = Convert.ToInt32(dgvGrillaUsuarios[19, dgvGrillaUsuarios.CurrentCell.RowIndex].Value.ToString());
                   
                    new FrmMotivoEliminacionUsuario().ShowDialog();   
             
                    grillaUsuario();
                }
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvGrillaUsuarios.DataSource = Brl.buscarUsuarioFiltrado2(cbFiltro.Text, txtBuscar.Text);  
            }
            else
            {
                dgvGrillaUsuarios.DataSource = Brl.obtenerUsuarios();
            }
        }
    }
}
