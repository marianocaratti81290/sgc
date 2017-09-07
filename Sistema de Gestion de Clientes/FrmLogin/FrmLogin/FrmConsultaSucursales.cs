using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace FrmLogin
{
    public partial class FrmConsultaSucursales : Form
    {
        public FrmConsultaSucursales()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaSucursales.DataSource = Brl.buscarSucursal(txtBuscar.Text);
            }
        }

        private void FrmConsultaSucursales_Load(object sender, EventArgs e)
        {
            dgvGrillaSucursales.DataSource = Brl.obtenerSucursales();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvGrillaSucursales.DataSource = Brl.buscarSucursal(txtBuscar.Text);
            }
            else
            {
                dgvGrillaSucursales.DataSource = Brl.obtenerSucursales();
            }
        }
    }
}
