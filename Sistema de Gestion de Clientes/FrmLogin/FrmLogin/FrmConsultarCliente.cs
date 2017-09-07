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
    public partial class FrmConsultarCliente : Form
    {
        public FrmConsultarCliente()
        {
            InitializeComponent();
        }

        private int id_cliente ;

        public static string codigo;

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dvgClientes.DataSource = Brl.buscarClienteFiltrado(cbFiltro.Text, txtBuscar.Text);
            }
        }

        private void FrmConsultarCliente_Load(object sender, EventArgs e)
        {
            mostrarClientes();
            dvgClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      
        }

        private void mostrarClientes()
        {
            dvgClientes.DataSource = Brl.obtenerGrillaClienteSinDetalle();
        }

        private void dvgClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgClientes.SelectedRows.Count != 0)
            {

                id_cliente = Convert.ToInt32((dvgClientes[3, dvgClientes.CurrentCell.RowIndex].Value));
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e) 
        {
            codigo = (dvgClientes[3, dvgClientes.CurrentCell.RowIndex].Value.ToString());
            new FrmInformeVeraz().ShowDialog();
          
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dvgClientes.DataSource = Brl.buscarClienteFiltrado(cbFiltro.Text, txtBuscar.Text);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
