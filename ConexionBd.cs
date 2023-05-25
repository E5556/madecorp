using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api1
{
    class ConexionBd
    {
        string cadena = "Data Source=EDWARDCUESTA\\SQLEXPRESS;Initial Catalog=madecorp;Integrated Security=True";
        public SqlConnection conexion = new SqlConnection("server=EDWARDCUESTA\\SQLEXPRESS; database=madecorp; integrated security = true");

    }
}
