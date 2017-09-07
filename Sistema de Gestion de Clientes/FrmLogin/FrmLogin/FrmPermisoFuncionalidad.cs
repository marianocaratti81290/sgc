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
    public partial class FrmPermisoFuncionalidad : Form
    {
        public FrmPermisoFuncionalidad()
        {
            InitializeComponent();
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dvgUsuariosOrigen.DataSource = Brl.buscarUsuarioxFuncionalidad(txtBuscar.Text);
            }
            
        }

        private void FrmPermisoFuncionalidad_Load(object sender, EventArgs e)
        {

        }

        private void txtBuscar2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dvgUsuariosDestino.DataSource = Brl.buscarUsuarioxFuncionalidad(txtBuscar2.Text);
            }
        }

        private void btnDelegarPermisos_Click(object sender, EventArgs e)
        {
            Brl.delegarPermisos(txtBuscar.Text, txtBuscar2.Text);
            MessageBox.Show("Permiso insertado con exito");
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dvgUsuariosOrigen.DataSource = Brl.buscarUsuarioxFuncionalidad(txtBuscar.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dvgUsuariosDestino.DataSource = Brl.buscarUsuarioxFuncionalidad(txtBuscar2.Text);
        }

    }
}
