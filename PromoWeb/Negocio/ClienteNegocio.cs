using PromoWeb.Datos;
using PromoWeb.Dominio;
using PromoWeb.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PromoWeb.Negocio
{
    public class ClienteNegocio
    {
        public void agregarCliente(Cliente cliente)
        {
            // Objeto encargado de la conexión SQL
            AccesoDatos datos = new AccesoDatos();

            // Se abre conexión a SQL Server
            datos.conexion.Open();

            // Objeto que ejecutará el comando SQL
            SqlCommand comando = new SqlCommand();

            // Se indica qué conexión utilizar
            comando.Connection = datos.conexion;

            // Consulta SQL INSERT
            comando.CommandText =
            "INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
            "VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)";

            // Reemplaza parámetros SQL con datos del objeto cliente
            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);

            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);

            comando.Parameters.AddWithValue("@Email", cliente.Email);

            comando.Parameters.AddWithValue("@Documento", cliente.Dni);

            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);

            comando.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);

            comando.Parameters.AddWithValue("@CP", cliente.CP);

            // Ejecuta INSERT en base de datos
            comando.ExecuteNonQuery();

            // Cierra conexión SQL
            datos.conexion.Close();
        }
    }
}