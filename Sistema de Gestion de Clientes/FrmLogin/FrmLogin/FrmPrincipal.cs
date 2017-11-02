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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        public static int SolicitoGestion = 0;

        public static string dniCliente = "";
        private void altaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevoUsuario().ShowDialog();
        }

        private void modificacionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarUsuario().ShowDialog();
        }

        private void bajaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEliminarUsuario().ShowDialog();
        }

      
        private void altaDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmNuevaSucursal().ShowDialog();
        }

        private void bajaDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEliminarSucursal().ShowDialog();
        }

        private void modificacionDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarSucursal().ShowDialog();
        }

        private void consultaDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaSucursales().ShowDialog();
        }

        private void cambiarEstadoDeSucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmEstadosSucursales().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void gestionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void permisoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void permisosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPermisosUsuarios().ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            // PERMISOS 

            //Permisos frmclientes
            string usr = FrmAccesoSistema.UsuarioPermiso;
            string frm = "";
            int existe;

            frm = "FrmClientes";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                clientesToolStripMenuItem.Visible = true;
            }
            else
            {
                clientesToolStripMenuItem.Visible = false;
            }


            //Permisos frmGestionClientes
            frm = "FrmGestionClientes";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                nuevaGestionToolStripMenuItem.Visible = true;
            }
            else
            {
                nuevaGestionToolStripMenuItem.Visible = false;
            }

            //Permisos frmNuevoUsuario
            frm = "FrmNuevoUsuario";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                altaDeUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                altaDeUsuariosToolStripMenuItem.Visible = false;
            }

            //Permisos frmModificarUsuario
            frm = "FrmModificarUsuario";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                modificacionDeUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                modificacionDeUsuariosToolStripMenuItem.Visible = false;
            }


            //Permisos frmEliminarUsuario
            frm = "FrmEliminarUsuario";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                bajaDeUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                bajaDeUsuariosToolStripMenuItem.Visible = false;
            }

            //Permisos frmConsultaUsuario
            frm = "FrmConsultaUsuarios";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                consultaDeUsuariosToolStripMenuItem1.Visible = true;
            }
            else
            {
                consultaDeUsuariosToolStripMenuItem1.Visible = false;
            }

            //Permisos frmConsultaUsuarioLogeados
            frm = "FrmConsultaUsuario";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                HistoricoUsuariosToolStripMenuItem.Visible = true;
            }
            else
            {
                HistoricoUsuariosToolStripMenuItem.Visible = false;
            }

            //Permisos frmNuevaSucursal
            frm = "FrmNuevaSucursal";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                altaDeSucursalesToolStripMenuItem.Visible = true;
            }
            else
            {
                altaDeSucursalesToolStripMenuItem.Visible = false;
            }

            //Permisos frmModificarSucursal
            frm = "FrmModificarSucursal";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                modificacionDeSucursalesToolStripMenuItem.Visible = true;
            }
            else
            {
                modificacionDeSucursalesToolStripMenuItem.Visible = false;
            }

            //Permisos frmEliminarSucursal
            frm = "FrmEliminarSucursal";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                bajaDeSucursalesToolStripMenuItem.Visible = true;
            }
            else
            {
                bajaDeSucursalesToolStripMenuItem.Visible = false;
            }

            //Permisos frmConsultaSucursales
            frm = "FrmConsultaSucursales";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                consultaDeSucursalesToolStripMenuItem.Visible = true;
            }
            else
            {
                consultaDeSucursalesToolStripMenuItem.Visible = false;
            }

                  //Permisos frmestadoSucursales
            frm = "FrmEstadoSucursales";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                cambiarEstadoDeSucursalesToolStripMenuItem.Visible = true;
            }
            else
            {
                cambiarEstadoDeSucursalesToolStripMenuItem.Visible = false;
            }

            //Permisos reportes
            frm = "FrmEstadoSucursales";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                reportesToolStripMenuItem.Visible = true;
            }
            else
            {
                reportesToolStripMenuItem.Visible = false;
            }

            //Permisos 
            frm = "FrmPermisosUsuarios";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                permisosPorUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                permisosPorUsuarioToolStripMenuItem.Visible = false;
            }
            
            frm = "FrmPermisosFuncionalidad";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                permisosPorFuncionalidadToolStripMenuItem.Visible = true;
            }
            else
            {
                permisosPorFuncionalidadToolStripMenuItem.Visible = false;
            }

           // -----------------------------------------campañasToolStripMenuItem ----------------------------------------

            frm = "FrmCampana";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                importarCampañaToolStripMenuItem.Visible = true;
            }
            else
            {
                importarCampañaToolStripMenuItem.Visible = false;
            }

           // ------------------------------------------- objetivosPorUsuarioToolStripMenuItem ---------------------------------

            frm = "FrmObjetivosXusuario";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                objetivosPorUsuarioToolStripMenuItem.Visible = true;
            }
            else
            {
                objetivosPorUsuarioToolStripMenuItem.Visible = false;
            }

            // ------------------------------------------- objetivosPorSucursalesToolStripMenuItem ---------------------------------

            frm = "FrmObjetivosXSucursales";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                objetivosPorSucursalToolStripMenuItem.Visible = true;
            }
            else
            {
                objetivosPorSucursalToolStripMenuItem.Visible = false;
            }

            

                // ------------------------------------------- Modificar gestion clientes ---------------------------------

            frm = "FrmModificarGestionCliente";
            existe = Brl.PermisosPuntualesLogeo(usr, frm);
            if (existe == 1)
            {
                modificarGestionToolStripMenuItem.Visible = true;
            }
            else
            {
                modificarGestionToolStripMenuItem.Visible = false;
            }

            //----------------------------------------- CAMPAÑA POR USUARIO -----------------------------------------------------------

            dgvCampanaUsuario.DataSource=  Brl.obtenercampanaXusuario(FrmAccesoSistema.UsuarioPermiso);
            dgvCampanaUsuario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
      



       

        }

        private void consultaDeUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new FrmConsultaUsuarios().ShowDialog();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmClientes().ShowDialog();
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultarCliente().ShowDialog();
        }

        private void consultarGestionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void permisosPorFuncionalidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPermisoFuncionalidad().ShowDialog();
        }

        private void HistoricoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaLogeados().ShowDialog();
        }

        private void objetivosPorUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmObjetivosXusuario().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Prueba().ShowDialog();
        }

        private void nuevaGestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmGestionClientes().ShowDialog();
        }

        private void modificarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarCliente().ShowDialog();
        }

        private void modificarGestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmModificarGestionCliente().ShowDialog();
        }

        private void importarCampañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCampana().ShowDialog();
        }

        private void btnHabilitarCamp_Click(object sender, EventArgs e)
        {
            gbCampana.Visible = true;
            btnHabilitarCamp.Visible = false;
            btnDesHabilitarCamp.Visible = true;
        }

        private void btnDesHabilitarCamp_Click(object sender, EventArgs e)
        {
            gbCampana.Visible = false;
            btnDesHabilitarCamp.Visible = false;
            btnHabilitarCamp.Visible = true;
        }

        private void dgvCampanaUsuario_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCampanaUsuario.SelectedRows.Count != 0)
            {
                dniCliente = (dgvCampanaUsuario[2, dgvCampanaUsuario.CurrentCell.RowIndex].Value.ToString());
                SolicitoGestion = 1;
                new FrmGestionClientes().ShowDialog();                             

                int existe = Brl.estadoGestionCamp(FrmPrincipal.dniCliente);

                if (existe == 1)
                {
                    dgvCampanaUsuario.DataSource = Brl.obtenercampanaXusuario(FrmAccesoSistema.UsuarioPermiso);
                }
            }

            SolicitoGestion = 0;


        }

        private void objetivosPorSucursalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        
    }
}
