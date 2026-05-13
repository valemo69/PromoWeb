
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PromoWeb.Datos;
using PromoWeb.Dominio;
using System.Data.SqlClient;

namespace PromoWeb.Negocio
{
    // Clase encargada de manejar lógica relacionada a clientes
    public class ClienteNegocio
    {
        // Busca un cliente por DNI
        public Cliente buscarClientePorDni(string dni)
        {
            // Objeto conexión SQL
            AccesoDatos datos = new AccesoDatos();

            // Cliente inicialmente vacío
            Cliente cliente = null;

            // Abrir conexión
            datos.conexion.Open();

            // Comando SQL
            SqlCommand comando = new SqlCommand();

            // Asignar conexión
            comando.Connection = datos.conexion;

            // Consulta SQL
            comando.CommandText =
                "SELECT Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP " +
                "FROM Clientes " +
                "WHERE Documento = @Documento";

            // Parámetro SQL
            comando.Parameters.AddWithValue("@Documento", dni);

            // Ejecutar SELECT
            SqlDataReader lector = comando.ExecuteReader();

            // Si encontró cliente
            if (lector.Read())
            {
                // Crear objeto cliente
                cliente = new Cliente();

                // Cargar propiedades desde SQL
                cliente.Dni = lector["Documento"].ToString();

                cliente.Nombre = lector["Nombre"].ToString();

                cliente.Apellido = lector["Apellido"].ToString();

                cliente.Email = lector["Email"].ToString();

                cliente.Direccion = lector["Direccion"].ToString();

                cliente.Ciudad = lector["Ciudad"].ToString();

                cliente.CP = (int)lector["CP"];
            }

            // Cerrar lector
            lector.Close();

            // Cerrar conexión
            datos.conexion.Close();

            // Devolver cliente o null
            return cliente;
        }

        // Guarda un nuevo cliente en base de datos
        public void agregarCliente(Cliente cliente)
        {
            // Objeto conexión SQL
            AccesoDatos datos = new AccesoDatos();

            // Abrir conexión
            datos.conexion.Open();

            // Comando SQL
            SqlCommand comando = new SqlCommand();

            // Asignar conexión
            comando.Connection = datos.conexion;

            // Consulta INSERT
            comando.CommandText =
                "INSERT INTO Clientes (Documento, Nombre, Apellido, Email, Direccion, Ciudad, CP) " +
                "VALUES (@Documento, @Nombre, @Apellido, @Email, @Direccion, @Ciudad, @CP)";

            // Parámetros SQL
            comando.Parameters.AddWithValue("@Documento", cliente.Dni);

            comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);

            comando.Parameters.AddWithValue("@Apellido", cliente.Apellido);

            comando.Parameters.AddWithValue("@Email", cliente.Email);

            comando.Parameters.AddWithValue("@Direccion", cliente.Direccion);

            comando.Parameters.AddWithValue("@Ciudad", cliente.Ciudad);

            comando.Parameters.AddWithValue("@CP", cliente.CP);

            // Ejecutar INSERT
            comando.ExecuteNonQuery();

            // Cerrar conexión
            datos.conexion.Close();
        }
    }
}