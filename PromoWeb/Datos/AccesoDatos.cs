using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PromoWeb.Datos
{
    public class AccesoDatos
    {
        public SqlConnection conexion;

        public AccesoDatos()
        {
            conexion = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PROMOS_DB;Integrated Security=True");
        }


    }
}