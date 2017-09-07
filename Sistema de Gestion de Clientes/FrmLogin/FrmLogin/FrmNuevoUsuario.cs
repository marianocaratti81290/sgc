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
    public partial class FrmNuevoUsuario : Form
    {
        public FrmNuevoUsuario()
        {
            InitializeComponent();
        }

        public static int estado;

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro que desea agregar el usuario", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                validarEstado();
                verificarDatos();
            }
        }

       private void validarEstado()
        {
           if (cbEstado.Text=="Activo")
           {
               estado = 1;
           }
           else
           {
               estado=0;
           }
        }

       private void verificarDatos()
       {
           if (txtnombre.Text == "")
           {
               MessageBox.Show("Ingrese el Nombre del usuario");
           }
           else
               if (txtapellido.Text == "")
               {
                   MessageBox.Show("Ingrese el apellido del usuario");
               }
               else
                   if (txtdni.Text == "")
                   {
                       MessageBox.Show("Ingrese el dni del usuario");
                   }
                   else
                       if (dtpfecha_nac.Text == "")
                       {
                           MessageBox.Show("Ingrese la fecha de nacimiento del usuario");
                       }
                       else
                       {
                           if (txtUsuario.Text == "")
                           {
                               MessageBox.Show("Ingrese un usuario");
                           }
                           else
                               if (txtPass.Text == "")
                               {
                                   MessageBox.Show("Ingrese una contraseña");
                               }
                               else
                               {
                                   String usuario = txtUsuario.Text;
                                   String clave = txtPass.Text;
                                   lblusr.Text = txtUsuario.Text;
                                   lblpass.Text = txtPass.Text;

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

                                   //Encripto el texto que se cargue en el textbox Clave
                                   MD5 md5Provider3 = new MD5CryptoServiceProvider();
                                   Byte[] originalBytes3 = ASCIIEncoding.Default.GetBytes(clave);
                                   Byte[] encodedBytes3 = md5Provider.ComputeHash(originalBytes2);
                                   String resultado3 = Convert.ToBase64String(encodedBytes2);
                                   //textencriptado2.Text = resultado2;  
                                   txtConfirmarContraseña.Text = resultado3;

                                   if (txtPass.Text != txtConfirmarContraseña.Text)
                                   {
                                       MessageBox.Show("Las contraseñas no coinciden");
                                   }
                                   else
                                   {
                                       int existe = Brl.validoUsuario(txtUsuario.Text);

                                       if (existe == 1)
                                       {
                                           MessageBox.Show("El usuario ya existe en la base de datos");
                                           txtUsuario.Text = "";
                                           txtPass.Text = "";
                                           txtConfirmarContraseña.Text = "";
                                       }
                                       else
                                       {
                                           if (txtdni.Text != "")
                                           {
                                               int existeDni = Brl.validoDni(txtdni.Text);

                                               if (existeDni == 0)
                                               {
                                                   

                                                   Brl.agregarUsuario(txtnombre.Text,
                                                       txtapellido.Text,
                                                       txtdni.Text,
                                                       Convert.ToDateTime(dtpfecha_nac.Text),
                                                       cbSexo.Text,
                                                       txtCel.Text,
                                                       txttel_fijo.Text,
                                                       cbLocalidad.Text,
                                                       cbProvincia.Text,
                                                       txtDireccion.Text,
                                                       txtcp.Text,
                                                       txtEmail.Text,
                                                       txtObservaciones.Text,
                                                       txtUsuario.Text,
                                                       txtPass.Text,
                                                       estado,
                                                       lblusr.Text,
                                                       lblpass.Text);
                                                   limpiarCliente();
                                                   MessageBox.Show("El usuario se agrego de forma correcta");

                                               }
                                               else
                                               {
                                                   MessageBox.Show("El dni ya se encuentra registrado en la base de datos");

                                               }
                                           }
                                       }
                                   }
                               }
                       }
       }

        private void limpiarCliente()
        {
            txtnombre.Clear();
            txtapellido.Clear();
            txtdni.Clear();
            dtpfecha_nac.Text = "";
            txttel_fijo.Clear();
            txtCel.Clear();
            txtDireccion.Clear();
            cbProvincia.Refresh();
            cbLocalidad.Refresh();
            txtcp.Clear();
            txtEmail.Clear();
            txtObservaciones.Clear();
            txtUsuario.Text = "";
            txtPass.Text = "";
            txtConfirmarContraseña.Text = "";

        }

        private void btnCp_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://www.nexo.com.ar/codigosPostales.asp");
            }
            catch { }
        }

        private void cbProvincia_MouseClick(object sender, MouseEventArgs e)
        {
            cbLocalidad.Text = "";
            cbProvincia.DataSource = Brl.ObtenerProvincias();
            //indicamos el valor de los miembros
            cbProvincia.ValueMember = "provincia";
            //se indica el valor a desplegar en el combobox
            cbProvincia.DisplayMember = "provincia";

        }

        private void cbLocalidad_MouseClick(object sender, MouseEventArgs e)
        {
          //  if (cbProvincia.Text != "")
            {
                string valor = ((System.Data.DataRowView)cbProvincia.SelectedItem).Row.ItemArray[0].ToString();

                cbLocalidad.DataSource = Brl.obtenerLocalidadCorrespondiente(valor);
                //indicamos el valor de los miembros
                cbLocalidad.ValueMember = "localidad";
                //se indica el valor a desplegar en el combobox
                cbLocalidad.DisplayMember = "localidad";
            }
        }

        private void txtdni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txttel_fijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void FrmNuevoUsuario_Load(object sender, EventArgs e)
        {
            cbSexo.SelectedIndex = 0;
            cbEstado.SelectedIndex = 0;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
              
    }
}
