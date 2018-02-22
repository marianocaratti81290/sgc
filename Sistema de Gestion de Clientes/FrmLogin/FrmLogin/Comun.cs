using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FrmLogin
{
        public static class Comun
        {
            public static SqlConnection establecerConexion = new SqlConnection("Data Source= serverprod.database.windows.net; initial catalog = GestionClientes; user id = administrador; password = 1520hgW4");
        }
      

}
