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
    public partial class FrmModificarSucursal : Form
    {
        public FrmModificarSucursal()
        {
            InitializeComponent();
        }

        public static string modSeleccion;

        private void FrmModificarSucursal_Load(object sender, EventArgs e)
        {
            GrillaSucursales();
        }

        private void GrillaSucursales()
        {
            dgvGrillaSucursales.DataSource = Brl.obtenerSucursalesCompleta();
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
                //    modSeleccion = 0; dvgUsuarios.SelectedRows[1].Index;
                modSeleccion = (dgvGrillaSucursales[0, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());

                try
                {
                    DataTable dtSocio = new DataTable();
                    dtSocio = Brl.obtenerSucursalSeleccionada(modSeleccion);

                    if (dtSocio.Rows.Count > 0) 
                    {

                        txtNombre.Text = (dgvGrillaSucursales[1, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        txtDireccion.Text = (dgvGrillaSucursales[2, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        dtpFechaAlta.Text = (dgvGrillaSucursales[3, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        
                        txtTelefono.Text = (dgvGrillaSucursales[5, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());                       
                        txtObservacion.Text = (dgvGrillaSucursales[9, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        dtpContrato.Text = (dgvGrillaSucursales[8, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        string Estado = (dgvGrillaSucursales[6, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        string TpoContrato = (dgvGrillaSucursales[7, dgvGrillaSucursales.CurrentCell.RowIndex].Value.ToString());
                        
                        if (Estado == "Activo")
                        {
                            cbEstado.Text = "Activo";
                        }
                        else
                        {
                            cbEstado.Text = "Inactivo";
                        }

                        if (TpoContrato == "Alquiler  ")
                        {
                            rbAlquilado.Checked = true;
                            dtpContrato.Visible= true;
                            label9.Visible=true;
                            
                        }
                        else
                        {
                            rbPropio.Checked = true;
                            rbAlquilado.Checked = false;
                            dtpContrato.Visible = false;
                            label9.Visible = false;
                            (dgvGrillaSucursales[8, dgvGrillaSucursales.CurrentCell.RowIndex].Value)= "";
                        
                        }
                        
                       
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
            if (MessageBox.Show("Estas seguro que desea modificar la sucursal", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string tpoContrato;

                    if (rbAlquilado.Checked==true)
                    {
                        tpoContrato = "Alquiler";
                    }
                    else
                    {
                        tpoContrato="Propio";
                       
                    }                            

                Brl.modificarSucursal(modSeleccion,
                    txtNombre.Text, 
                    txtDireccion.Text,
                    dtpFechaAlta.Value,
                    txtTelefono.Text,
                    cbEstado.Text,                    
                    tpoContrato,
                    dtpContrato.Value,
                    txtObservacion.Text);

                MessageBox.Show("La sucursal se modifico con exito");

                GrillaSucursales();
                
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             private void rbPropio_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPropio.Checked == true)
            {
                dtpContrato.Visible = false;
                label9.Visible = false;
            }
        }

             private void rbAlquilado_CheckedChanged(object sender, EventArgs e)
             {
                 if (rbAlquilado.Checked == true)
                 {
                     dtpContrato.Visible = true;
                     label9.Visible = true;
                 }
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
