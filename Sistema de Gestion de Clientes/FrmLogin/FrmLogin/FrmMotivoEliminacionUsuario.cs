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
    public partial class FrmMotivoEliminacionUsuario : Form
    {
        public FrmMotivoEliminacionUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMotivos.Text =="")
            {
                MessageBox.Show("Ingrese un motivo de baja");
            }
            else
            {
                Brl.historicoUsuarioBorrado(FrmEliminarUsuario.id_usuario, txtMotivos.Text);
                Brl.borrarUsuario(FrmEliminarUsuario.id_usuario); 
                MessageBox.Show("El usuario se guardó en una base de historicos");
                this.Close();
            }
        }
    }
}
