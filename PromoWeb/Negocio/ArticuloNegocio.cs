using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using PromoWeb.Datos;
using PromoWeb.Dominio;

namespace PromoWeb.Negocio
{
    // Clase encargada de manejar lógica relacionada a artículos
    public class ArticuloNegocio
    {
        // Método que obtiene artículos desde base de datos
        public List<Articulo> listarArticulos()
        {
            // Lista donde se guardarán objetos Articulo
            List<Articulo> lista = new List<Articulo>();

            // Objeto de acceso a datos para usar conexión SQL
            AccesoDatos datos = new AccesoDatos();

            // Se abre conexión a base de datos
            datos.conexion.Open();

            // Se crea comando SQL
            SqlCommand comando = new SqlCommand();

            // Se indica qué conexión usar
            comando.Connection = datos.conexion;

            // Consulta SQL para traer información de artículos, imagenes incluidas x ahora solo una
            comando.CommandText =
                    "SELECT A.Id, A.Nombre, A.Descripcion, " +
                    "(SELECT TOP 1 ImagenUrl " +
                    "FROM Imagenes WHERE IdArticulo = A.Id) AS ImagenUrl " +
                    "FROM Articulos A";

            // Ejecuta consulta y devuelve lector de resultados
            SqlDataReader lector = comando.ExecuteReader();

            // Recorre fila por fila el resultado SQL
            while (lector.Read())
            {
                // Se crea nuevo objeto Articulo
                Articulo aux = new Articulo();

                // Se cargan propiedades del objeto con datos SQL
                aux.Id = (int)lector["Id"];
                aux.Nombre = lector["Nombre"].ToString();
                aux.Descripcion = lector["Descripcion"].ToString();
                aux.ImagenUrl = lector["ImagenUrl"].ToString();

                // Se agrega objeto completo a la lista
                lista.Add(aux);
            }

            // Se cierra conexión
            datos.conexion.Close();

            // Devuelve lista completa de artículos
            return lista;
        }
    }
}