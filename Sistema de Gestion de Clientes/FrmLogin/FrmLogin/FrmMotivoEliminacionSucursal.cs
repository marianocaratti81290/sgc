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
    public partial class FrmMotivoEliminacionSucursal : Form
    {
        public FrmMotivoEliminacionSucursal()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
              if (txtMotivos.Text =="")
            {
                MessageBox.Show("Ingrese un motivo de baja");
            }
            else
            {
                Brl.historicoSucursalBorrado(FrmEliminarSucursal.id_sucursal, txtMotivos.Text);
                Brl.borrarSucursal(FrmEliminarSucursal.id_sucursal); 
                MessageBox.Show("El usuario se guardó en una base de historicos");
                this.Close();
            }
        }
        
    }
}
