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
    public partial class FrmAccesoSistema : Form
    {
        public FrmAccesoSistema()
        {
            InitializeComponent();
        }

        public static string UsuarioPermiso;
        private void acceder_Click(object sender, EventArgs e)
        {
            validarUsuario();        
          
        }

        private void validarUsuario()
        {
            if (txtUsuario.Text == "" && txtPass.Text == "")
            {
                MessageBox.Show("Ingrese usuario y password");
            }
            else
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Ingrese un usuario");
                }
                else
                    if (txtPass.Text == "")
                    {
                        MessageBox.Show("Ingrese la contraseña");
                    }

                    else
                    {
            int intento = 0;
            String usuario = txtUsuario.Text;
            String clave = txtPass.Text;
            UsuarioPermiso = txtUsuario.Text;

            //Encripto el texto que se cargue enel textbox Usuario
            MD5 md5Provider = new MD5CryptoServiceProvider();
            Byte[] originalBytes = ASCIIEncoding.Default.GetBytes(usuario);
            Byte[] encodedBytes = md5Provider.ComputeHash(originalBytes);
            String resultado1 = Convert.ToBase64String(encodedBytes);
            //textencriptado1.Text = resultado1;
            txtUsuario.Text = resultado1;



            //Encripto el texto que se cargue en el textbox Clave
            MD5 md5Provider2 = new MD5CryptoServiceProvider();
            Byte[] originalBytes2 = ASCIIEncoding.Default.GetBytes(clave);
            Byte[] encodedBytes2 = md5Provider.ComputeHash(originalBytes2);
            String resultado2 = Convert.ToBase64String(encodedBytes2);
            //textencriptado2.Text = resultado2;  
            txtPass.Text = resultado2;

           
                
                          
                            int existe = Brl.logearUsuario(txtUsuario.Text, txtPass.Text);

                           

                         

                            if (existe == 1)
                            {
                                Brl.guardoAccesoSistema(txtUsuario.Text);
                                this.Hide();
                                new FrmPrincipal().ShowDialog();                                
                            }
                            else
                            {
                                MessageBox.Show("Sus datos no se encuentra en la base de datos. Consulte con su administrador");
                                limpiarLogin();
                                txtUsuario.Focus();
                            }
                           
                        }
                                          
        
            
        }
        private void limpiarLogin()
        {
            txtUsuario.Text = "";
            txtPass.Text = "";
        }

        private void FrmAccesoSistema_Load(object sender, EventArgs e)
        {
            lblExito.Visible = false;
            lblNoExito.Visible = false;

            try
            {
                Comun.establecerConexion.Open();
                lblExito.Visible = true;
                Comun.establecerConexion.Close();
            }
            catch (Exception)
            {
                lblNoExito.Visible = true;
            }

        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                validarUsuario();
            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblNoExito_Click(object sender, EventArgs e)
        {

        }

        private void lblExito_Click(object sender, EventArgs e)
        {

        }
    }
}
