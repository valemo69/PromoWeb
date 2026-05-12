using PromoWeb.Dominio;
using PromoWeb.Negocio;
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

            cliente.Dni = txtDni.Text;

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
    }
}