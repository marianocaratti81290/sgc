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
    public partial class FrmPermisosUsuarios : Form
    {
        public FrmPermisosUsuarios()
        {
            InitializeComponent();
        }

        string usr = FrmAccesoSistema.UsuarioPermiso;
        string usrSeleccionado = "";
        private void FrmPermisosUsuarios_Load(object sender, EventArgs e)
        {
            mostrarGrillaUsuarios();
        }

        private void mostrarGrillaUsuarios()
        {
            dvgUsuarios.DataSource = Brl.obtenerUsuarios();
            cbFiltro.SelectedIndex = 0;
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dvgUsuarios.DataSource = Brl.buscarUsuarioFiltrado(cbFiltro.Text, txtBuscar.Text);

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text != "")
            {
                dvgUsuarios.DataSource = Brl.buscarUsuarioConLoginFiltrado(cbFiltro.Text, txtBuscar.Text);

            }
        }

        private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dvgUsuarios.DataSource = Brl.buscarUsuarioFiltrado(cbFiltro.Text, txtBuscar.Text);
            }
            else
            {
                dvgUsuarios.DataSource = Brl.obtenerConsultaUsuario();
            }
        }

        private void checkClientes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ModificarPermisoUsuarioI(string usr, string formulario)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            Brl.ModificarPermisosUsuarioI(dni, formulario);
        }

        private void ModificarPermisoUsuarioD(string usr, string formulario)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            Brl.ModificarPermisosUsuarioD(dni, formulario);
        }
        private void checkClientes_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkClientes.Checked == true)
            {

                ModificarPermisoUsuarioI(dni, "FrmClientes");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmClientes");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void CheckGestiones_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (CheckGestiones.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmGestionClientes");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmGestionClientes");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkReportes_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkReportes.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmReportes");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmReportes");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkUsuarioAlta_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
             if (checkUsuarioAlta.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmNuevoUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmNuevoUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkUsuarioModificacion_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkUsuarioModificacion.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmModificarUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmModificarUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkUsuarioBaja_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkUsuarioBaja.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmEliminarUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmEliminarUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkUsuarioHistorico_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkUsuarioHistorico.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmConsultaLogeados");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmConsultaLogeados");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkUsuarioConsulta_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkUsuarioConsulta.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmConsultaUsuarios");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmConsultaUsuarios");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkSucursalAlta_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkSucursalAlta.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmNuevaSucursal");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmNuevaSucursal");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkSucursalModificacion_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkSucursalModificacion.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmModificarSucursal");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmModificarSucursal");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkSucursalBaja_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkUsuarioBaja.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmEliminarSucursal");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmEliminarSucursal");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkSucursalConsulta_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkSucursalConsulta.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmConsultaSucursales");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmConsultaSucursales");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkSucursalEstado_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkSucursalEstado.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmEstadoSucursales");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmEstadoSucursales");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkPermisoFuncionalidad_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkPermisoFuncionalidad.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmPermisosFuncionalidad");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmPermisosFuncionalidad");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkPermisoUsuario_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                
            if (checkPermisoUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmPermisosUsuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmPermisosUsuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void dvgUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgUsuarios.SelectedRows.Count != 0)
            {

                string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));
                                
                // PERMISOS 
                string frm = "";
                //Permisos frmclientes
               
                int existe;

                frm = "FrmClientes";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkClientes.Checked = true;
                }
                else
                {
                    checkClientes.Checked = false;
                }


                //Permisos frmGestionClientes
                frm = "FrmGestionClientes";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                   CheckGestiones.Checked = true;
                }
                else
                {
                    CheckGestiones.Checked = false;
                }

                //Permisos frmNuevoUsuario
                frm = "FrmNuevoUsuario";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkUsuarioAlta.Checked = true;
                }
                else
                {
                    checkUsuarioAlta.Checked = false;
                }

                //Permisos frmModificarUsuario
                frm = "FrmModificarUsuario";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkUsuarioModificacion.Checked = true;
                }
                else
                {
                    checkUsuarioModificacion.Checked = false;
                }


                //Permisos frmEliminarUsuario
                frm = "FrmEliminarUsuario";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkUsuarioBaja.Checked = true;
                }
                else
                {
                    checkUsuarioBaja.Checked = false;
                }

                //Permisos frmConsultaUsuario
                frm = "FrmConsultaUsuario";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkUsuarioConsulta.Checked = true;
                }
                else
                {
                    checkUsuarioConsulta.Checked = false;
                }

                //Permisos frmNuevaSucursal
                frm = "FrmNuevaSucursal";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkSucursalAlta.Checked = true;
                }
                else
                {
                    checkSucursalAlta.Checked = false;
                }

                //Permisos frmModificarSucursal
                frm = "FrmModificarSucursal";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkSucursalModificacion.Checked = true;
                }
                else
                {
                    checkSucursalModificacion.Checked = false;
                }

                //Permisos frmEliminarSucursal
                frm = "FrmEliminarSucursal";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkSucursalBaja.Checked = true;
                }
                else
                {
                    checkSucursalBaja.Checked = false;
                }

                //Permisos frmConsultaSucursales
                frm = "FrmConsultaSucursales";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkSucursalConsulta.Checked = true;
                }
                else
                {
                    checkSucursalConsulta.Checked = false;
                }

                //Permisos frmestadoSucursales
                frm = "FrmEstadoSucursales";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkSucursalEstado.Checked = true;
                }
                else
                {
                    checkSucursalEstado.Checked = false;
                }

                //Permisos reportes
                frm = "FrmEstadoSucursales";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkSucursalEstado.Checked = true;
                }
                else
                {
                    checkSucursalEstado.Checked = false;
                }

                //Permisos 
                frm = "FrmPermisosUsuarios";
                existe = Brl.PermisosPuntualesUsuarios(dni, frm);
                if (existe == 1)
                {
                    checkPermisoUsuario.Checked = true;
                }
                else
                {
                    checkPermisoUsuario.Checked = false;
                }
             
                  
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkUsuarioConsulta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkImportarCampana_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));

            if (checkImportarCampana.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmCampana");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmCampana");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkObjetivosUsuario_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));

            if (checkObjetivosUsuario.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmObjetivosXusuario");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmObjetivosXusuario");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkModificarGestion_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));

            if (checkModificarGestion.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmModificarGestionCliente");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmModificarGestionCliente");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkModificarCliente_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));

            if (checkModificarCliente.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmModificarClientes");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmModificarCliente");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        private void checkConsultaCliente_Click(object sender, EventArgs e)
        {
            string dni = Convert.ToString((dvgUsuarios[2, dvgUsuarios.CurrentCell.RowIndex].Value));

            if (checkConsultaCliente.Checked == true)
            {
                ModificarPermisoUsuarioI(dni, "FrmConsultarClientes");
                MessageBox.Show("Permiso Insertado con exito");
            }
            else
            {
                ModificarPermisoUsuarioD(dni, "FrmConsultarClientes");
                MessageBox.Show("Permiso DesHabilitado con exito");
            }
        }

        

        
    }
}
