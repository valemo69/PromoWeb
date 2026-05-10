using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PromoWeb.Datos;

namespace PromoWeb.Negocio
{
    public class VoucherNegocio
    {
        public bool validarVoucher(string codigo)
        {
            AccesoDatos datos = new AccesoDatos();

            datos.conexion.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = datos.conexion;
            comando.CommandText = "SELECT COUNT(*) FROM Vouchers WHERE CodigoVoucher = @codigo";

            comando.Parameters.AddWithValue("@codigo", codigo);

            int cantidad = (int)comando.ExecuteScalar();

            datos.conexion.Close();

            return cantidad > 0;
        }
    }
}