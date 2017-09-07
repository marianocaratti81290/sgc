using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace FrmLogin
{
    public partial class FrmModificarUsuario : Form
    {
        public FrmModificarUsuario()
        {
            InitializeComponent();
        }

        public static int estado;

        public static string modSeleccion ;
        private void FrmModificarUsuario_Load(object sender, EventArgs e)
        {
            mostrarGrillaUsuarios();
        }

        private void mostrarGrillaUsuarios()
        {
            dvgUsuarios.DataSource = Brl.obtenerUsuarios();
            cbFiltro.SelectedIndex = 0;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            if (txtBuscar.Text!= "")
            {
               dvgUsuarios.DataSource= Brl.buscarUsuarioFiltrado(cbFiltro.Text, txtBuscar.Text);

            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string genero;
        private void dvgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgUsuarios.SelectedRows.Count != 0)
            {
            //    modSeleccion = 0; dvgUsuarios.SelectedRows[1].Index;
                modSeleccion = (dvgUsuarios[19, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());

                try
                {
                    DataTable dtSocio = new DataTable();
                    dtSocio = Brl.obtenerUsuarioSeleccionado(modSeleccion);

                    if (dtSocio.Rows.Count > 0)
                    {

                        txtapellido.Text = (dvgUsuarios[1, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtnombre.Text = (dvgUsuarios[0, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtdni.Text = (dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        genero = (dvgUsuarios[5, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        dtpNacimiento.Text = (dvgUsuarios[4, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtDireccion.Text = (dvgUsuarios[10, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        cbProvincia.Text = (dvgUsuarios[9, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        cbLocalidad.Text = (dvgUsuarios[8, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtCel.Text = (dvgUsuarios[6, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txttel_fijo.Text = (dvgUsuarios[7, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtEmail.Text = (dvgUsuarios[12, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtcp.Text = (dvgUsuarios[11, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtObservaciones.Text = (dvgUsuarios[13, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtUsuario.Text = (dvgUsuarios[17, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtPass.Text = (dvgUsuarios[18, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        txtConfirmarContraseña.Text = (dvgUsuarios[18, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        cbEstado.Text = (dvgUsuarios[16, dvgUsuarios.CurrentCell.RowIndex].Value.ToString());
                        
                                            
                        
                        if (cbEstado.Text == "Activo")
                        {
                            cbEstado.Text = "Activo ";

                        }
                        else
                            cbEstado.Text = "Inactivo";
                    }

                    if (genero == "Masculino ")
                    {
                        cbSexo.Text = "Masculino";
                    }
                    else
                    {
                        cbSexo.Text = "Femenino";
                    }
                  
                }

                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea modificar el usuario", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Brl.modificarUsuario(modSeleccion,
                   txtnombre.Text,
                   txtapellido.Text,
                   txtdni.Text,
                   cbSexo.Text,
                   Convert.ToDateTime(dtpNacimiento.Text),
                   txtDireccion.Text,
                   cbProvincia.Text,
                   cbLocalidad.Text,
                   txtCel.Text,
                   txttel_fijo.Text,
                   txtEmail.Text,
                   txtcp.Text,
                   txtObservaciones.Text);

                if (txtPass.ReadOnly==false)
                {

                    if (txtPass.Text != txtConfirmarContraseña.Text)
                    {
                        MessageBox.Show("Por favor verifique la contraseña");
                    }
                    else
                    {
                    
                    String clave = txtPass.Text;

                    lblusrSinEncript.Text = txtUsuario.Text;
                    lblPassSinEncript.Text = txtPass.Text;

                    MD5 md5Provider = new MD5CryptoServiceProvider();
                    Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(clave);
                    Byte[] encodedBytes = md5Provider.ComputeHash(originalBytes);
                    String resultado1 = Convert.ToBase64String(encodedBytes);
                    //textencriptado1.Text = resultado1;
                    txtPass.Text = resultado1;


                    if (cbEstado.Text == "Activo")
                    {
                        cbEstado.Text = "1 ";

                    }
                    else
                    {
                        cbEstado.Text = "0";
                    }

                    Brl.modificarLogin(modSeleccion, txtPass.Text, cbEstado.Text, lblusrSinEncript.Text,lblPassSinEncript.Text);
                    }
                          
                }
                 
                MessageBox.Show("El usuario se modifico con exito");

                mostrarGrillaUsuarios();
            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dvgUsuarios.DataSource = Brl.buscarUsuarioFiltrado2(cbFiltro.Text, txtBuscar.Text);
            }
            else
            {
                dvgUsuarios.DataSource = Brl.obtenerUsuarios();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            txtUsuario.ReadOnly = true;
            
            txtPass.ReadOnly = false;
            txtPass.Text = "";
            txtConfirmarContraseña.ReadOnly = false;
            txtConfirmarContraseña.Text = "";
            cbEstado.Visible = true;
            label18.Visible = true;

        }
    }
}
