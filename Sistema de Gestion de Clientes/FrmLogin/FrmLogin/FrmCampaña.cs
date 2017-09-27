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
    public partial class FrmCampaña : Form
    {
        public FrmCampaña()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
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
                        DataTable dtVentas = new DataTable("Ventas");

                        dtVentas.Columns.Add("nombre", typeof(String));
                        dtVentas.Columns.Add("apellido", typeof(String));
                       

                        if (System.IO.File.Exists(txtRuta.Text))
                        {
                            using (StreamReader Leer = new StreamReader("C:\\prueba\\Libro1.csv"))
                            {
                                string Linea;
                                while ((Linea = Leer.ReadLine()) != null)
                                {
                                    string[] campos = Linea.Split(',');

                                    if (campos.Length == 2)
                                    {
                                        dtVentas.Rows.Add(campos[0], campos[1]);
                                    }
                                }

                                if (dtVentas.Rows.Count > 0)
                                {
                                    resultadoImportacion.DataSource = dtVentas;

                                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy("Data Source=192.168.1.1; Initial Catalog=Ventas; User ID=usuario; Password=*******;"))
                                    {
                                        sqlBulkCopy.DestinationTableName = "ListaVentas";

                                        sqlBulkCopy.ColumnMappings.Add("nombre", "nombre");
                                        sqlBulkCopy.ColumnMappings.Add("apellido", "apellido");
                                      
                                        sqlBulkCopy.WriteToServer(dtVentas);

                                        MessageBox.Show("oky doky");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Formato o Ventas No Valido. Compruebe y vuela a ingresar el Ventas!");
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("No existe el Ventas!");
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
        
        }

        private void cbUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            cbUsuarios.DataSource = Brl.obtenerUsuarioCb();
            //indicamos el valor de los miembros
            cbUsuarios.ValueMember = "nombre";
            //se indica el valor a desplegar en el combobox
            cbUsuarios.DisplayMember = "apyn"; 
        }

        private void cbSucursales_MouseDown(object sender, MouseEventArgs e)
        {
            cbSucursales.DataSource = Brl.obtenerSucursalesCb();
            //indicamos el valor de los miembros
            cbSucursales.ValueMember = "nombre";
            //se indica el valor a desplegar en el combobox
            cbSucursales.DisplayMember = "nombre"; 
        }

          

      
        }

    
}
