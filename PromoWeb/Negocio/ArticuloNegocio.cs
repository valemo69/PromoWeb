using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PromoWeb.Datos;

namespace PromoWeb.Negocio
{
    public class ArticuloNegocio
    {
        public List<string> listarArticulos()
        {
            // Lista donde se van a guardar los nombres de artículos traídos desde SQL
            List<string> lista = new List<string>();

            // Se crea objeto de acceso a datos para usar la conexión
            AccesoDatos datos = new AccesoDatos();

            // Se abre conexión a base de datos
            datos.conexion.Open();

            // Se arma comando SQL
            SqlCommand comando = new SqlCommand();

            // Se indica qué conexión usar
            comando.Connection = datos.conexion;

            // Consulta SQL: traer nombres de todos los artículos
            comando.CommandText = "SELECT Nombre FROM Articulos";

            // Ejecuta consulta y devuelve lector de resultados
            SqlDataReader lector = comando.ExecuteReader();

            // Recorre cada fila devuelta por SQL
            while (lector.Read())
            {
                // Agrega nombre del artículo a la lista
                lista.Add(lector["Nombre"].ToString());
            }

            // Se cierra conexión
            datos.conexion.Close();

            // Devuelve lista completa de artículos
            return lista;
        }
    }
}