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
    public partial class FrmSupervisarCampana : Form
    {
        public FrmSupervisarCampana()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //if (cbUsuarios = -1)
            //{
            //    MessageBox.Show("Debe seleccionar un usuario");
            //}
            //else
            //    if (cbSucursales.ValueMember == "")
            //    {
            //        MessageBox.Show("Debe selecionar una sucursal");
            //    }
            //    else

                  dgvGrillaFiltro.DataSource=  Brl.obtenerCampanaXfiltro(Convert.ToDateTime(dtpDesde.Text), Convert.ToDateTime(dtpHasta.Text), cbUsuarios.Text, cbSucursales.Text);

           





        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscarDni_Click(object sender, EventArgs e)
        {
            int existe;

            if (txtDni.Text == "")
            {
                MessageBox.Show("Ingrese el dni del cliente que desea buscar");
            }
            else
        
                existe= Brl.existeClienteEnCampana(txtDni.Text);

            if (existe = 0)
            {
                MessageBox.Show("El cliente no tiene una campaña asignada");
            }
            else
            {
                dgvGrillaFiltro.DataSource = Brl.obtenerGestionCampanaXdni(txtDni.Text);
            }
        }
    }
}
