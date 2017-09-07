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
    public partial class FrmEliminarSucursal : Form
    {
        public FrmEliminarSucursal()
        {
            InitializeComponent();
        }

        public static int id_sucursal;
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


        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea eliminar la sucursal", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (dgvGrillaSucursales.Rows.Count == 0)
                {
                    MessageBox.Show("La grilla esta vacia");
                }
                else
                {

                    if ((dgvGrillaSucursales[1, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString()) != "")
                    {
                        id_sucursal = Convert.ToInt32(dgvGrillaSucursales[0, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());

                        new FrmMotivoEliminacionSucursal().ShowDialog();

                        grillaSucursales();

                    }
                }
            }
        }

        private void FrmEliminarSucursal_Load(object sender, EventArgs e)
        {
            grillaSucursales();
            dgvGrillaSucursales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      
        }

        private void grillaSucursales()
        {
            dgvGrillaSucursales.DataSource = Brl.obtenerSucursales();
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
