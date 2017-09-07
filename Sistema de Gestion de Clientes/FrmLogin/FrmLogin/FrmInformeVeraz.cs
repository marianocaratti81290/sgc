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
    public partial class FrmInformeVeraz : Form
    {
        public FrmInformeVeraz()
        {
            InitializeComponent();
        }

        private void FrmInformeVeraz_Load(object sender, EventArgs e)
        {
            



                 DataTable dtInforme = new DataTable();
                 dtInforme = Brl.obtenerInformes(FrmConsultarCliente.codigo);

                    if (dtInforme.Rows.Count > 0) 
                    {

                        txtNombre.Text =  dtInforme.Rows[0]["Nombre"].ToString();
                        txtApellido.Text = dtInforme.Rows[0]["Apellido"].ToString();
                        txtDni.Text = dtInforme.Rows[0]["DNI"].ToString();
                        txtScoreVeraz.Text = dtInforme.Rows[0]["ScoreVeraz"].ToString();
                        txtSiisa.Text = dtInforme.Rows[0]["ScoreSiisa"].ToString();
                        cbComentario.Text = dtInforme.Rows[0]["Comentario1"].ToString();
                        cbComentario1.Text = dtInforme.Rows[0]["Comentario2"].ToString();
                        cbComentario2.Text = dtInforme.Rows[0]["Comentario3"].ToString();

                    }

            if (cbComentario1.Text != "")
            {
                lblComentario1.Visible = true;
                cbComentario1.Visible = true;
            }

            if (cbComentario2.Text != "")
            {
                lblComentario2.Visible = true;
                cbComentario2.Visible = true;
            }


        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComentario1_Click(object sender, EventArgs e)
        {
            lblComentario1.Visible = true;
            cbComentario1.Visible = true;
            btnComentario2.Visible = true;
        }

        private void btnComentario2_Click(object sender, EventArgs e)
        {
            lblComentario2.Visible = true;
            cbComentario2.Visible = true;
        }

        private void txtGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" )
            {
                MessageBox.Show("Ingrese el nombre");
            }
            else
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("Ingrese el apellido");
                }
                else
                {
                    if (MessageBox.Show("Estas seguro que desea modificar el informe del cliente", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Brl.modificarApynCliente(txtDni.Text, txtNombre.Text, txtApellido.Text);
                        Brl.guardarInformeCliente(txtDni.Text, txtScoreVeraz.Text, txtSiisa.Text, cbComentario.Text, cbComentario1.Text, cbComentario2.Text);
                        MessageBox.Show("La modificacion se realizo con exito");
                    }
                    }
                

        }
    }
}
