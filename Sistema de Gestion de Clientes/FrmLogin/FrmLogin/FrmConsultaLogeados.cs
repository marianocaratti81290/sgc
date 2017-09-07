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
    public partial class FrmConsultaLogeados : Form
    {
        public FrmConsultaLogeados()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConsultaUsuario_Load(object sender, EventArgs e)
        {
            mostrarGrillaUsuarios();
            dvgUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      
        }
                
         private void mostrarGrillaUsuarios()
        {
            dvgUsuarios.DataSource = Brl.obtenerConsultaUsuario();
            cbFiltro.SelectedIndex = 0;

        }

         private void btnBuscar_Click(object sender, EventArgs e)
         {
             if (txtBuscar.Text != "")
             {
                 dvgUsuarios.DataSource = Brl.buscarUsuarioConLoginFiltrado(cbFiltro.Text, txtBuscar.Text);

             }
         }

         private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (txtBuscar.Text != "")
             {
                 dvgUsuarios.DataSource = Brl.buscarUsuarioFiltrado(cbFiltro.Text, txtBuscar.Text);

             }
         }

         private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
         {
             if (e.KeyCode == Keys.Enter)
             {
                 dvgUsuarios.DataSource = Brl.buscarUsuarioFiltrado(cbFiltro.Text, txtBuscar.Text);
             }
             else
             {
                 dvgUsuarios.DataSource = Brl.obtenerConsultaUsuario();
             }
         }
    }
}
