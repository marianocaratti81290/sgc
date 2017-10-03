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
    public partial class FrmAgregarItemCampana : Form
    {
        public FrmAgregarItemCampana()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el item", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
          
            if ((txtItem.Text != "") && (FrmCampana.RelacNewItem != ""))
                {
                    Brl.agregarCampanaMarketingRelac(FrmCampana.RelacNewItem, txtItem.Text);
                    MessageBox.Show("El item se agrego de forma correcta");
                    this.Close();
                }
            else
            {

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
