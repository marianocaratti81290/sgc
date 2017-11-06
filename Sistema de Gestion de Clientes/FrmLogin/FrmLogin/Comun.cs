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
            public static SqlConnection establecerConexion = new SqlConnection ("Data Source= 192.168.5.83\\SQLEXPRESS; initial catalog = gestionClientes; user id = mariano; password = 1520hgW4");
        }
      

}
