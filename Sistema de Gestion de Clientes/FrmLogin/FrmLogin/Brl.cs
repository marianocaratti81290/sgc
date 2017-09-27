using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace FrmLogin
{
    public class Brl
    {
        public static int logearUsuario(string usuario, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Logeo_buscarUsuario_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@password", password);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecerConexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void agregarUsuario(string nombre,
            string apellido,
            string dni,
            DateTime fecha_nacimiento,
            string sexo,
            string cel,
            string tel,
            string localidad,
            string provincia,
            string direccion,
            string cp,
            string email,
            string observaciones,
            string usuario,
            string password,
            int estado,
            string usuarioSinEncript,
            string passSinEncript

           )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("nuevoUsuario_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", fecha_nacimiento);
                cmd.Parameters.AddWithValue("@sexo", sexo);
                cmd.Parameters.AddWithValue("@cel", cel);
                cmd.Parameters.AddWithValue("@tel", tel);
                cmd.Parameters.AddWithValue("@localidad", localidad);
                cmd.Parameters.AddWithValue("@provincia", provincia);
                cmd.Parameters.AddWithValue("@domicilio", direccion);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@observacion", observaciones);
                cmd.Parameters.AddWithValue("@usr", usuario);
                cmd.Parameters.AddWithValue("@pass", password);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@usrSinEncript", usuarioSinEncript);
                cmd.Parameters.AddWithValue("@passSinEncript", passSinEncript);
                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void guardarInformeCliente(string dni,
            string veraz,
            string siisa,           
            string comentario1,
            string comentario2,
            string comentario3          
           )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarVerazCliente_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@veraz", veraz);
                cmd.Parameters.AddWithValue("@siisa", siisa);
                cmd.Parameters.AddWithValue("@comentario1", comentario1);
                cmd.Parameters.AddWithValue("@comentario2", comentario2);
                cmd.Parameters.AddWithValue("@comentario3", comentario3);
                
                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void guardarInformeClienteNuevo(string dni,            
            string siisa,
            string comentario1,
            string comentario2,
            string comentario3
           )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarVerazClienteNuevo_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);            
                cmd.Parameters.AddWithValue("@siisa", siisa);
                cmd.Parameters.AddWithValue("@comentario1", comentario1);
                cmd.Parameters.AddWithValue("@comentario2", comentario2);
                cmd.Parameters.AddWithValue("@comentario3", comentario3);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void modificarApynCliente(string dni,
           string nombre,
           string apellido
          
          )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarApynCliente_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
               
                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static void agregarUsuarioPrueba(string nombre,
            string apellido
            
            
           )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("insertarPrueba_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                
               
                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable ObtenerProvincias()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerProvincia_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerUsuarioCb()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("buscarClientecb_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerSucursalesCb()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerSucursalesCb_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerSucursalesCompleta()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("mostrarSucursalesCompleta_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        
        public static DataTable obtenerGrillaClienteSinDetalle()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerClienteSinDetalle_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerGrillaCompletaCliente()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerDatosClienteCompletos_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;


                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarUsuarioxFuncionalidad(string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerPermisosPorFuncionalidad_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerInformes(string dni)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerInforme_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigo", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerInformesNuevo(string dni)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerInformeNuevo_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@codigo", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerGrillaCliente()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerCliente_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable obtenerLocalidadCorrespondiente(string id_provincia)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerLocalidadCorrespondiente_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("valor", id_provincia);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarUsuarioFiltrado(string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("buscarUsuarioFiltrado_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int validoDni(string dni)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("validarDni_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@validarDni", dni);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecerConexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static int validoUsuario(string usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("validarLogin_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@validarLogin", usuario);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecerConexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerUsuarios()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerUsuarios_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarUsuarioFiltrado(string filtro, string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerUsuarioFiltrado_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("filtro", filtro);

                cmd.Parameters.AddWithValue("buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable buscarClienteFiltrado(string filtro, string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerClienteFiltradoSinFiltro_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("filtro", filtro);

                cmd.Parameters.AddWithValue("buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable buscarClienteCompletoFiltrado(string filtro, string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerClienteCompletoFiltrado_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("filtro", filtro);

                cmd.Parameters.AddWithValue("buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataTable obtenerUsuarioSeleccionado(string id_usuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerUsuarioSeleccionado_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("id_usuario", id_usuario);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void guardoAccesoSistema(string usuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("guardarInicioSessionUsuario_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@usuario", usuario);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void delegarPermisos(string origen, string destino)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("delegarPermisosPorFuncionalidad_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@origen", origen);

                cmd.Parameters.AddWithValue("@destino", destino);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void borrarUsuario(int id_usuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("borrarUsuario_d_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void historicoUsuarioBorrado(int id_usuario, string observacion)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("guardarHistoricoUsuario_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", id_usuario);
                cmd.Parameters.AddWithValue("@observacion", observacion);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();

                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerConsultaUsuario()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerConsultaUsuario_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarUsuarioConLoginFiltrado(string filtro, string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerUsuarioFiltrado_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("filtro", filtro);

                cmd.Parameters.AddWithValue("buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void agregarSucursal(string nombre, string direccion, string telefono, string estado, string tpoContrato, string fechaContrato, string observaciones)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("nuevaSucursal_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@tpoContrato", tpoContrato);
                cmd.Parameters.AddWithValue("@fechaContrato", fechaContrato);
                cmd.Parameters.AddWithValue("@observacion", observaciones);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();

                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void borrarSucursal(int id_sucursal)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("borrarSucursal_d_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();

                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void historicoSucursalBorrado(int id_sucursal, string observacion)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("guardarHistoricoSucursal_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_sucursal", id_sucursal);

                cmd.Parameters.AddWithValue("@observacion", observacion);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();

                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarSucursal(string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerSucursalFiltrada_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerSucursales()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerSucursales_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerSucursalSeleccionada(string id_sucursal)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerSucursalSeleccionada_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("id_sucursal", id_sucursal);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void modificarSucursal(string modSeleccion,
                     string Nombre,
                     string Direccion,
                     DateTime fechaAlta,
                     string Telefono,
                     string Estado,
                     string Contrato,
                     DateTime dtpContrato,
                     string Observacion
          )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarSucursal_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_sucursal", modSeleccion);
                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@fecha_alta", fechaAlta);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@estado", Estado);
                cmd.Parameters.AddWithValue("@tpoContrato", Contrato);
                cmd.Parameters.AddWithValue("@fechaContrato", dtpContrato);
                cmd.Parameters.AddWithValue("@observacion", Observacion);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void cambiarEstado(string modSeleccion,
                   string estadoSucursal

        )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarEstadoSucursal_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_sucursal", modSeleccion);
                cmd.Parameters.AddWithValue("@estado", estadoSucursal);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarUsuarioFiltrado2(string filtro, string buscar)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerUsuarioFiltrado2_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("filtro", filtro);

                cmd.Parameters.AddWithValue("buscar", buscar);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void modificarUsuario(
                   string modSeleccion,
                   string nombre,
                   string apellido,
                   string dni,
                   string Sexo,
                   DateTime Nacimiento,
                   string Direccion,
                   string Provincia,
                   string Localidad,
                   string Cel,
                   string tel_fijo,
                   string Email,
                   string cp,
                   string Observaciones

        )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarUsuario_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", modSeleccion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@apellido", apellido);
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@sexo", Sexo);
                cmd.Parameters.AddWithValue("@nacimiento", Nacimiento);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@provincia", Provincia);
                cmd.Parameters.AddWithValue("@localidad", Localidad);
                cmd.Parameters.AddWithValue("@cel", Cel);
                cmd.Parameters.AddWithValue("@tel_fijo", tel_fijo);
                cmd.Parameters.AddWithValue("@email", Email);
                cmd.Parameters.AddWithValue("@cp", cp);
                cmd.Parameters.AddWithValue("@observaciones", Observaciones);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static void modificarLogin(
                   string modSeleccion,

                   string password,
                   string estado,
                   string usrSinEncript,
                   string passSinEncript

        )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarLogin_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@id_usuario", modSeleccion);

                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@estado", estado);
                cmd.Parameters.AddWithValue("@usrSinEncript", usrSinEncript);
                cmd.Parameters.AddWithValue("@passSinEncript", passSinEncript);
                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int validoDniClientes(string dni)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("validarDniCliente_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@validarDni", dni);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecerConexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void nuevoCliente(
                                    string txtNombre,
                                    string txtApellido,
                                    string txtDni,
                                    string txtCuil1,
                                    string txtCuil2,
                                    string txtCuil3,
                                    DateTime dtpNacimiento,
                                    string cbEstadoCivil,
                                    string cbSexo,
                                    string txtCodAreaDP,
                                    string txtTelDP,
                                    string txtRef1,
                                    string txtCodArea2DP,
                                    string txtTel2DP,
                                    string txtRef2,
                                    string txtCodAreaCelDP,
                                    string txtCelDP,
                                    string txtRef3,
                                    string txtcalle,
                                    string txtNro,
                                    string txtEntre1,
                                    string txtEntre2,
                                    string txtPiso,
                                    string txtDepto,
                                    string cbLocalidad,
                                    string cbProvincia,
                                    string txtEmail,
                                    string txtCp,
                                    string situacionLaboral,
                                    string txtLugarTrabajo,
                                    string txtRubro,
                                    string txtTitulo,
                                    string txtObservacion,
                                    string txtCodAreaDL,
                                    string txtTelDL,
                                    string txtInt1,
                                    string txtCodArea2DL,
                                    string txtTel2DL,
                                    string txtInt2,
                                    string txtCodAreaCelDL,
                                    string txtCelDL,
                                    string txtCodAreaCel2DL,
                                    string txtCel2DL
            )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("nuevoCliente_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", txtNombre);
                cmd.Parameters.AddWithValue("@apellido", txtApellido);
                cmd.Parameters.AddWithValue("@dni", txtDni);
                cmd.Parameters.AddWithValue("@cuil", txtCuil1 + txtCuil2 + txtCuil3);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", dtpNacimiento);
                cmd.Parameters.AddWithValue("@estado_civil", cbEstadoCivil);
                cmd.Parameters.AddWithValue("@sexo", cbSexo);
                cmd.Parameters.AddWithValue("@codAreaTel1", txtCodAreaDP);
                cmd.Parameters.AddWithValue("@tel1", txtTelDP);
                cmd.Parameters.AddWithValue("@ref1", txtRef1);
                cmd.Parameters.AddWithValue("@codAreaTel2", txtCodArea2DP);
                cmd.Parameters.AddWithValue("@tel2", txtTel2DP);
                cmd.Parameters.AddWithValue("@ref2", txtRef2);
                cmd.Parameters.AddWithValue("@codAreaCel1", txtCodAreaCelDP);
                cmd.Parameters.AddWithValue("@cel1", txtCelDP);
                cmd.Parameters.AddWithValue("@ref3", txtRef3);
                cmd.Parameters.AddWithValue("@calle", txtcalle);
                cmd.Parameters.AddWithValue("@nro", txtNro);
                cmd.Parameters.AddWithValue("@entre1", txtEntre1);
                cmd.Parameters.AddWithValue("@entre2", txtEntre2);
                cmd.Parameters.AddWithValue("@piso", txtPiso);
                cmd.Parameters.AddWithValue("@depto", txtDepto);
                cmd.Parameters.AddWithValue("@localidad", cbLocalidad);
                cmd.Parameters.AddWithValue("@provincia", cbProvincia);
                cmd.Parameters.AddWithValue("@email", txtEmail);
                cmd.Parameters.AddWithValue("@cp", txtCp);
                cmd.Parameters.AddWithValue("@situacionLaboral", situacionLaboral);
                cmd.Parameters.AddWithValue("@lugarTrabajo", txtLugarTrabajo);
                cmd.Parameters.AddWithValue("@rubro", txtRubro);
                cmd.Parameters.AddWithValue("@titulo", txtTitulo);
                cmd.Parameters.AddWithValue("@observacion", txtObservacion);
                cmd.Parameters.AddWithValue("@codAreaTel1Laboral", txtCodAreaDL);
                cmd.Parameters.AddWithValue("@tel1Laboral", txtTelDL);
                cmd.Parameters.AddWithValue("@Int1", txtInt1);
                cmd.Parameters.AddWithValue("@codAreaTel2Laboral", txtCodArea2DL);
                cmd.Parameters.AddWithValue("@tel2Laboral", txtTel2DL);
                cmd.Parameters.AddWithValue("@int2", txtInt2);
                cmd.Parameters.AddWithValue("@codAreaCel1Laboral", txtCodAreaCelDL);
                cmd.Parameters.AddWithValue("@cel1Laboral", txtCelDL);
                cmd.Parameters.AddWithValue("@codAreaCel2Laboral", txtCodAreaCel2DL);
                cmd.Parameters.AddWithValue("@cel2Laboral", txtCel2DL);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void modificarCliente(
                                   string txtNombre,
                                   string txtApellido,
                                   string txtDni,
                                   string txtCuil1,
                                   string txtCuil2,
                                   string txtCuil3,
                                   DateTime dtpNacimiento,
                                   string cbEstadoCivil,
                                   string cbSexo,
                                   string txtCodAreaDP,
                                   string txtTelDP,
                                   string txtRef1,
                                   string txtCodArea2DP,
                                   string txtTel2DP,
                                   string txtRef2,
                                   string txtCodAreaCelDP,
                                   string txtCelDP,
                                   string txtRef3,
                                   string txtcalle,
                                   string txtNro,
                                   string txtEntre1,
                                   string txtEntre2,
                                   string txtPiso,
                                   string txtDepto,
                                   string cbLocalidad,
                                   string cbProvincia,
                                   string txtEmail,
                                   string txtCp,
                                   string situacionLaboral,
                                   string txtLugarTrabajo,
                                   string txtRubro,
                                   string txtTitulo,
                                   string txtObservacion,
                                   string txtCodAreaDL,
                                   string txtTelDL,
                                   string txtInt1,
                                   string txtCodArea2DL,
                                   string txtTel2DL,
                                   string txtInt2,
                                   string txtCodAreaCelDL,
                                   string txtCelDL,
                                   string txtCodAreaCel2DL,
                                   string txtCel2DL
           )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarCliente_u_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", txtNombre);
                cmd.Parameters.AddWithValue("@apellido", txtApellido);
                cmd.Parameters.AddWithValue("@dni", txtDni);
                cmd.Parameters.AddWithValue("@cuil", txtCuil1 + txtCuil2 + txtCuil3);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", dtpNacimiento);
                cmd.Parameters.AddWithValue("@estado_civil", cbEstadoCivil);
                cmd.Parameters.AddWithValue("@sexo", cbSexo);
                cmd.Parameters.AddWithValue("@codAreaTel1", txtCodAreaDP);
                cmd.Parameters.AddWithValue("@tel1", txtTelDP);
                cmd.Parameters.AddWithValue("@ref1", txtRef1);
                cmd.Parameters.AddWithValue("@codAreaTel2", txtCodArea2DP);
                cmd.Parameters.AddWithValue("@tel2", txtTel2DP);
                cmd.Parameters.AddWithValue("@ref2", txtRef2);
                cmd.Parameters.AddWithValue("@codAreaCel1", txtCodAreaCelDP);
                cmd.Parameters.AddWithValue("@cel1", txtCelDP);
                cmd.Parameters.AddWithValue("@ref3", txtRef3);
                cmd.Parameters.AddWithValue("@calle", txtcalle);
                cmd.Parameters.AddWithValue("@nro", txtNro);
                cmd.Parameters.AddWithValue("@entre1", txtEntre1);
                cmd.Parameters.AddWithValue("@entre2", txtEntre2);
                cmd.Parameters.AddWithValue("@piso", txtPiso);
                cmd.Parameters.AddWithValue("@depto", txtDepto);
                cmd.Parameters.AddWithValue("@localidad", cbLocalidad);
                cmd.Parameters.AddWithValue("@provincia", cbProvincia);
                cmd.Parameters.AddWithValue("@email", txtEmail);
                cmd.Parameters.AddWithValue("@cp", txtCp);
                cmd.Parameters.AddWithValue("@situacionLaboral", situacionLaboral);
                cmd.Parameters.AddWithValue("@lugarTrabajo", txtLugarTrabajo);
                cmd.Parameters.AddWithValue("@rubro", txtRubro);
                cmd.Parameters.AddWithValue("@titulo", txtTitulo);
                cmd.Parameters.AddWithValue("@observacion", txtObservacion);
                cmd.Parameters.AddWithValue("@codAreaTel1Laboral", txtCodAreaDL);
                cmd.Parameters.AddWithValue("@tel1Laboral", txtTelDL);
                cmd.Parameters.AddWithValue("@Int1", txtInt1);
                cmd.Parameters.AddWithValue("@codAreaTel2Laboral", txtCodArea2DL);
                cmd.Parameters.AddWithValue("@tel2Laboral", txtTel2DL);
                cmd.Parameters.AddWithValue("@int2", txtInt2);
                cmd.Parameters.AddWithValue("@codAreaCel1Laboral", txtCodAreaCelDL);
                cmd.Parameters.AddWithValue("@cel1Laboral", txtCelDL);
                cmd.Parameters.AddWithValue("@codAreaCel2Laboral", txtCodAreaCel2DL);
                cmd.Parameters.AddWithValue("@cel2Laboral", txtCel2DL);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerOrigen()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerOrigen_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable obtenerOrigenCorrespondiente(string relacOrigen)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerOrigenCorrespondiente_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@valor", relacOrigen);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void ModificarPermisosUsuarioI(string usr, string formulario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("InsertarPermisosPuntuales_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", usr);

                cmd.Parameters.AddWithValue("@formulario", formulario);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void ModificarPermisosUsuarioD(string usr, string formulario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("EliminarPermisosPuntuales_d_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", usr);

                cmd.Parameters.AddWithValue("@formulario", formulario);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       
        public static int PermisosPuntualesUsuarios(string dni, string formulario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PermisosPuntuales_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@Formulario", formulario);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecerConexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static int PermisosPuntualesLogeo(string usr, string formulario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("PermisosPuntualesLogeo_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usr", usr);
                cmd.Parameters.AddWithValue("@Formulario", formulario);
                SqlParameter existe = new SqlParameter("@existe", SqlDbType.Int);
                existe.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(existe);
                Comun.establecerConexion.Open();
                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();
                return (int)existe.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        //public static void ModificarPermisosUsuarioI(string usr, string formulario)
        //{
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand("InsertarPermisosPuntuales_i_sp", Comun.establecerConexion);

        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@usr", usr);

        //        cmd.Parameters.AddWithValue("@formulario", formulario);

        //        Comun.establecerConexion.Open();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        cmd.ExecuteReader().Close();
        //        Comun.establecerConexion.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public static void ModificarPermisosUsuarioD(string usr, string formulario)
        //{
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand("EliminarPermisosPuntuales_d_sp", Comun.establecerConexion);

        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@usr", usr);

        //        cmd.Parameters.AddWithValue("@formulario", formulario);

        //        Comun.establecerConexion.Open();

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        cmd.ExecuteReader().Close();
        //        Comun.establecerConexion.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }

        //}

        //public static DataTable PermisosxUsuario(string usr)
        //{
        //    try
        //    {

        //        SqlCommand cmd = new SqlCommand("ObtenerPermisosxUsuario_q_sp", Comun.establecerConexion);

        //        cmd.CommandType = CommandType.StoredProcedure;

        //        cmd.Parameters.AddWithValue("@usr", usr);

        //        SqlDataAdapter da = new SqlDataAdapter(cmd);

        //        DataTable dt = new DataTable();

        //        da.Fill(dt);

        //        return dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }



        public static DataTable obtenerPermisoXusuario(string usuario)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerPermisosUsuario", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("usuario", usuario);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerUsuarioSegunDni(string dni)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerUsuarioParaPermisos_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerClientes()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerClientes_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable obtenerDetalleClienteSeleccionado()
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerDetalleCliente_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static DataTable obtenerApynCliente(string dni)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerApynCliente_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public static void guardarGestionCliente(string dni,
           string apyn,
           string operacion,
           string tipoPrestamo,
           string origen,
           string relacOrigen,
           string importe,
           string plazo,
           string cbPlazo,
           string estado
           
          )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("nuevaGestionCliente_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@apyn", apyn);
                cmd.Parameters.AddWithValue("@operacion", operacion);
                cmd.Parameters.AddWithValue("@tipoPrestamo", tipoPrestamo);
                cmd.Parameters.AddWithValue("@origen", origen);
                cmd.Parameters.AddWithValue("@relacOrigen", relacOrigen);
                cmd.Parameters.AddWithValue("@importe", importe);
                cmd.Parameters.AddWithValue("@plazo", plazo);
                cmd.Parameters.AddWithValue("@cbplazo", cbPlazo);
                cmd.Parameters.AddWithValue("@estado", estado);
               
                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void modificarGestionCliente(string dni,
           string identificacion,
           string operacion,
           string guardar,
           string origen,
           string relacOrigen,
           string importe,
           string plazo,
           string cbPlazo,
           string estado

          )
        {
            try
            {

                SqlCommand cmd = new SqlCommand("modificarGestionCliente_i_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);
                cmd.Parameters.AddWithValue("@identificacion", identificacion);  
                cmd.Parameters.AddWithValue("@operacion", operacion);
                cmd.Parameters.AddWithValue("@tipoPrestamo", guardar);
                cmd.Parameters.AddWithValue("@origen", origen);
                cmd.Parameters.AddWithValue("@relacOrigen", relacOrigen);
                cmd.Parameters.AddWithValue("@importe", importe);
                cmd.Parameters.AddWithValue("@plazo", plazo);
                cmd.Parameters.AddWithValue("@cbplazo", cbPlazo);
                cmd.Parameters.AddWithValue("@estado", estado);

                Comun.establecerConexion.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                cmd.ExecuteReader().Close();
                Comun.establecerConexion.Close();

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static DataTable obtenerHistorialCliente(string dni)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("obtenerSituacionClienteSeleccionado_q_sp", Comun.establecerConexion);

                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@dni", dni);

                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
    
    
        

