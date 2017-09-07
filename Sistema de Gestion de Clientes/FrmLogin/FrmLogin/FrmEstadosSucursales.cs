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
    public partial class FrmEstadosSucursales : Form
    {
        public FrmEstadosSucursales()
        {
            InitializeComponent();
        }

        public static string modSeleccion;
        public static string estadoSucursal;

        private void FrmEstadosSucursales_Load(object sender, EventArgs e)
        {
            dgvGrillaSucursales.DataSource = Brl.obtenerSucursales();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dgvGrillaSucursales.DataSource = Brl.buscarSucursal(txtBuscar.Text);
            }
        }

        private void dgvGrillaSucursales_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGrillaSucursales.SelectedRows.Count != 0)
            {
              
                modSeleccion = (dgvGrillaSucursales[0, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());

                try
                {
                    DataTable dtSucursal = new DataTable();
                    dtSucursal = Brl.obtenerSucursalSeleccionada(modSeleccion);

                    if (dtSucursal.Rows.Count > 0)
                    {
                       estadoSucursal = (dgvGrillaSucursales[6, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                    }

                    if (estadoSucursal == "Activo")
                    {
                        rbHabilitado.Checked = true;
                        rbDeshabilitado.Checked = false;
                    }
                    else
                    {
                        rbDeshabilitado.Checked = true;
                        rbHabilitado.Checked = false;
                    }

                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbHabilitado.Checked==true)
            {
                estadoSucursal = "Activo";
            }
            else
            {
                estadoSucursal="Inactivo";
            }

            Brl.cambiarEstado(modSeleccion, estadoSucursal);
            dgvGrillaSucursales.DataSource = Brl.obtenerSucursales();

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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
