using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace FrmLogin
{
    public partial class FrmCampana : Form
    {
        public FrmCampana()
        {
            InitializeComponent();
        }

        public static string RelacNewItem;
        private void btnImportar_Click(object sender, EventArgs e)
        {
            resultadoImportacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            int size = -1;
            openFileDialog1.Filter = "Text files (*.csv)|*.csv|All files (*.*)|*.*";
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);

                    txtRuta.Text = file;

                    size = text.Length;

                    //Importar ruta del archivo csv a tblbd


                    try
                    {
                        DataTable dtCampana = new DataTable("Campana");

                        dtCampana.Columns.Add("FECHA_OPERACION", typeof(String));
                        dtCampana.Columns.Add("DNI", typeof(String));
                        dtCampana.Columns.Add("E-MAIL", typeof(String));
                        dtCampana.Columns.Add("NOMBRE", typeof(String));
                        dtCampana.Columns.Add("CIUDAD", typeof(String));
                        dtCampana.Columns.Add("TELEFONO", typeof(String));
                        dtCampana.Columns.Add("USUARIO_OPERACION", typeof(String));
                        dtCampana.Columns.Add("USUARIO_GESTION", typeof(String));
                        dtCampana.Columns.Add("SUCURSAL", typeof(String));
                        dtCampana.Columns.Add("ORIGEN", typeof(String));
                        dtCampana.Columns.Add("TIPO", typeof(String));
                        dtCampana.Columns.Add("CAMPANA", typeof(String));

                        if (System.IO.File.Exists(txtRuta.Text))
                        {
                            using (StreamReader Leer = new StreamReader(txtRuta.Text))//"C:\\prueba\\Libro1.csv"))
                            {
                                string Linea;
                                while ((Linea = Leer.ReadLine()) != null)
                                {
                                    string[] campos = Linea.Split(',');

                                    if (campos.Length != 0)
                                    {
                                        // Ya puedo acceder al archivo
                                        // lo tengo separado por ,
                                        // ahora los valores los recorro y los inserto en el store de armado de campaña
                                        /*
                                         * campo1 --> fecha leads
                                         * campo2 --> dni
                                         * campo3 --> email
                                         * campo4 --> apyn
                                         * campo5 --> ciudad
                                         * campo6 --> telefono
                                         * campo7 --> usuario
                                         * campo8 --> fecha_alta
                                         * campo9 --> fecha_operacion
                                         * campo10 --> id_gestion
                                         * campo11 --> usr_admin
                                         * campo12 --> suc
                                         * campo13 --> origenMarketing
                                         * campo14 --> origenRelacMarketing 
                                         * campo15 --> origenCampañaRelacMarketing
                                         * 
                                         * 
                                         * */

                                        //  Brl.importarGestionUsuario(campos[0], // fecha leads
                                        //campos[1], // dni
                                        //campos[2], // email
                                        //campos[3], // nombre
                                        //campos[4], // ciudad
                                        //campos[5], // telefono              
                                        //    cbUsuarios.Text, // usr que se le asigna esta gestion
                                        //  FrmAccesoSistema.UsuarioPermiso, //usr logeo
                                        //cbSucursales.Text, // sucursal asignada
                                        //cbOrigen.Text,                                            
                                        //cbCampañaOrigenMarketing.Text);


                                        dtCampana.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], cbUsuarios.Text, // usr que se le asigna esta gestion
                                            FrmAccesoSistema.UsuarioPermiso, //usr logeo
                                            cbSucursales.Text, // sucursal asignada
                                            cbOrigen.Text,
                                            cbRelacOrigen.Text,
                                            cbCampañaOrigenMarketing.Text);
                                    }
                                }

                                if (dtCampana.Rows.Count > 0)
                                {
                                    resultadoImportacion.DataSource = dtCampana;

                                }
                                else
                                {
                                    MessageBox.Show("No se ingresaron datos");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al realizar la operacion, los campos no se pudieron procesar");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }




                }
                catch (IOException)
                {
                }
            }

        }


        private void FrmCampaña_Load(object sender, EventArgs e)
        {

        }

        private void cbOrigen_MouseDown(object sender, MouseEventArgs e)
        {
            cbRelacOrigen.SelectedValue = "";
            cbRelacOrigen.Text = "";
            cbOrigen.DataSource = Brl.obtenerOrigen();
            cbOrigen.ValueMember = "descripcion";
            cbOrigen.DisplayMember = "descripcion";
        }

        private void cbRelacOrigen_MouseDown(object sender, MouseEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cbOrigen.SelectedItem).Row.ItemArray[0].ToString();

            cbRelacOrigen.DataSource = Brl.obtenerOrigenCorrespondiente(valor);
            //indicamos el valor de los miembros
            cbRelacOrigen.ValueMember = "descripcion";
            //se indica el valor a desplegar en el combobox
            cbRelacOrigen.DisplayMember = "descripcion";

            RelacNewItem = cbRelacOrigen.Text;

        }

        private void cbUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            cbUsuarios.DataSource = Brl.obtenerUsuarioSistema();
            //indicamos el valor de los miembros
            cbUsuarios.ValueMember = "usrSinEncript";
            //se indica el valor a desplegar en el combobox
            cbUsuarios.DisplayMember = "usrSinEncript";
        }

        private void cbSucursales_MouseDown(object sender, MouseEventArgs e)
        {
            cbSucursales.DataSource = Brl.obtenerSucursalesCb();
            //indicamos el valor de los miembros
            cbSucursales.ValueMember = "nombre";
            //se indica el valor a desplegar en el combobox
            cbSucursales.DisplayMember = "nombre";
        }

        private void cbCampañaOrigenMarketing_MouseDown(object sender, MouseEventArgs e)
        {
            string valor = ((System.Data.DataRowView)cbRelacOrigen.SelectedItem).Row.ItemArray[0].ToString();
            cbCampañaOrigenMarketing.DataSource = Brl.obtenerCampanaOrigenMarketingCorrespondiente(valor);
            //indicamos el valor de los miembros
            cbCampañaOrigenMarketing.ValueMember = "descripcion";
            //se indica el valor a desplegar en el combobox
            cbCampañaOrigenMarketing.DisplayMember = "descripcion";
        }

        private void btnAgregarSubCampana_Click(object sender, EventArgs e)
        {

            new FrmAgregarItemCampana().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea realizar la operacion", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (resultadoImportacion.SelectedRows.Count != 0)
                {

                    try
                    {

                        if (resultadoImportacion.Rows.Count > 0)
                        {
                            // falta declarar variables y pasarla a la capa brl para luego cargarlas en bd 
                            //en bd agregar dos campos: estado (pendiente y realizado) y ver si es necesario otro para tener control de la gestion  
                                            
                            string fechaOperacion= "";
                            string dni = "";
                            string email = "";
                            string nombre = "";
                            string ciudad ="";
                            string telefono = "";
                            string userAdmin = FrmAccesoSistema.UsuarioPermiso;
                            
                            
                            fechaOperacion = (resultadoImportacion[0, resultadoImportacion.CurrentCell.RowIndex].Value.ToString());
                            dni = (resultadoImportacion[1, resultadoImportacion.CurrentCell.RowIndex].Value.ToString());
                            email = (resultadoImportacion[2, resultadoImportacion.CurrentCell.RowIndex].Value.ToString());
                            nombre = (resultadoImportacion[3, resultadoImportacion.CurrentCell.RowIndex].Value.ToString());                       
                            ciudad = (resultadoImportacion[4, resultadoImportacion.CurrentCell.RowIndex].Value.ToString());
                            telefono = (resultadoImportacion[5, resultadoImportacion.CurrentCell.RowIndex].Value.ToString());


                        //    -------------------------------------Prueba----------------------------------------------------
                            resultadoImportacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            int size = -1;
                            openFileDialog1.Filter = "Text files (*.csv)|*.csv|All files (*.*)|*.*";
                            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
                            
                            if (result == DialogResult.OK) // Test result.
                            {
                                string file = openFileDialog1.FileName;
                                try
                                {
                                    string text = File.ReadAllText(file);

                                    txtRuta.Text = file;

                                    size = text.Length;

                                    //Importar ruta del archivo csv a tblbd


                                    try
                                    {
                                        DataTable dtCampana = new DataTable("Campana");

                                        dtCampana.Columns.Add("FECHA_OPERACION", typeof(String));
                                        dtCampana.Columns.Add("DNI", typeof(String));
                                        dtCampana.Columns.Add("E-MAIL", typeof(String));
                                        dtCampana.Columns.Add("NOMBRE", typeof(String));
                                        dtCampana.Columns.Add("CIUDAD", typeof(String));
                                        dtCampana.Columns.Add("TELEFONO", typeof(String));
                                        dtCampana.Columns.Add("USUARIO_OPERACION", typeof(String));
                                        dtCampana.Columns.Add("USUARIO_GESTION", typeof(String));
                                        dtCampana.Columns.Add("SUCURSAL", typeof(String));
                                        dtCampana.Columns.Add("ORIGEN", typeof(String));
                                        dtCampana.Columns.Add("TIPO", typeof(String));
                                        dtCampana.Columns.Add("CAMPANA", typeof(String));

                                        if (System.IO.File.Exists(txtRuta.Text))
                                        {
                                            using (StreamReader Leer = new StreamReader("C:\\prueba\\Libro1.csv"))
                                            {
                                                string Linea;
                                                while ((Linea = Leer.ReadLine()) != null)
                                                {
                                                    string[] campos = Linea.Split(',');

                                                    if (campos.Length != 0)
                                                    {                                                                                                         
                                                        //parametros que tiene la grilla
                                                        dtCampana.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], cbUsuarios.Text, // usr que se le asigna esta gestion
                                                            FrmAccesoSistema.UsuarioPermiso, //usr logeo
                                                            cbSucursales.Text, // sucursal asignada
                                                            cbOrigen.Text,
                                                            cbRelacOrigen.Text,
                                                            cbCampañaOrigenMarketing.Text);

                                                        //guardo los campos de la grilla desde el inicio hasta el final 
                                                        Brl.generarCampanaCsv(Convert.ToDateTime(campos[0]),campos[1], campos[2], campos[3], campos[4], campos[5],
                                                            cbUsuarios.Text, // usr que se le asigna esta gestion
                                                            FrmAccesoSistema.UsuarioPermiso, //usr logeo
                                                            cbSucursales.Text, // sucursal asignada
                                                            cbOrigen.Text,
                                                            cbRelacOrigen.Text,
                                                            cbCampañaOrigenMarketing.Text);
                                //dni,
                                //email,
                                //nombre,
                                //ciudad,
                                //telefono,
                                //cbUsuarios.Text,
                                //userAdmin,
                                //cbSucursales.Text,
                                //cbOrigen.Text,
                                //cbRelacOrigen.Text,
                                //cbCampañaOrigenMarketing.Text);




                                                    }
                                                }

                                                if (dtCampana.Rows.Count > 0)
                                                {
                                                    resultadoImportacion.DataSource = dtCampana;

                                                }
                                                else
                                                {
                                                    MessageBox.Show("No se ingresaron datos");
                                                }
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Error al realizar la operacion, los campos no se pudieron procesar");
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }




                                }
                                catch (IOException)
                                {
                                }
                            }




                            //   ------------------------------prueba --------------------------------------------------------

                            



                            Brl.generarCampanaCsv(Convert.ToDateTime(fechaOperacion), 
                                dni, 
                                email, 
                                nombre, 
                                ciudad, 
                                telefono, 
                                cbUsuarios.Text, 
                                userAdmin, 
                                cbSucursales.Text,
                                cbOrigen.Text,
                                cbRelacOrigen.Text,
                                cbCampañaOrigenMarketing.Text);

                        }
                            
                                          
                            }

                    catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



                        }




                    }

                }
            }
        }
    

