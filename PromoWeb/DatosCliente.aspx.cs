
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromoWeb.Dominio;
using PromoWeb.Negocio;

namespace PromoWeb
{
    public partial class DatosCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Obtiene el id del artículo enviado por URL
            string idArticulo = Request.QueryString["id"];


        }

        protected void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Se crea objeto cliente
            Cliente cliente = new Cliente();

            // Se cargan propiedades del cliente con datos del formulario
            cliente.Nombre = txtNombre.Text;

            cliente.Apellido = txtApellido.Text;

            cliente.Email = txtEmail.Text;

            cliente.Dni = txtBuscarDni.Text;

            cliente.Direccion = txtDireccion.Text;

            cliente.Ciudad = txtCiudad.Text;

            // Convierte texto del textbox a número entero
            cliente.CP = int.Parse(txtCP.Text);

            // Se crea objeto negocio para guardar cliente
            ClienteNegocio negocio = new ClienteNegocio();

            // Guarda cliente en base de datos
            negocio.agregarCliente(cliente);

            // Mensaje visual temporal de éxito
            Response.Redirect("CanjeFinalizado.aspx");
        }

        protected void btnBuscarDni_Click(object sender, EventArgs e)
        {
            // Obtiene DNI ingresado
            string dni = txtBuscarDni.Text;

            // Validación simple: solo números
            if (!long.TryParse(dni, out _))
            {
                Response.Write("El DNI debe contener solo números");
                return;
            }

            // Se crea objeto negocio
            ClienteNegocio negocio = new ClienteNegocio();

            // Busca cliente en base de datos
            Cliente cliente = negocio.buscarClientePorDni(dni);

            // Muestra formulario
            pnlFormulario.Visible = true;

            // Si encontró cliente
            if (cliente != null)
            {
                // Precarga formulario
                txtNombre.Text = cliente.Nombre;

                txtApellido.Text = cliente.Apellido;

                txtEmail.Text = cliente.Email;

                txtDireccion.Text = cliente.Direccion;

                txtCiudad.Text = cliente.Ciudad;

                txtCP.Text = cliente.CP.ToString();
            }
            else
            {
                // Limpia formulario para nuevo cliente
                txtNombre.Text = "";

                txtApellido.Text = "";

                txtEmail.Text = "";

                txtDireccion.Text = "";

                txtCiudad.Text = "";

                txtCP.Text = "";
            }
        }
    }
}