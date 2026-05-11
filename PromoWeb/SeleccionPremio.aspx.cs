using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromoWeb.Negocio;
using PromoWeb.Dominio;

namespace PromoWeb
{
    public partial class SeleccionPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se crea objeto negocio para poder acceder a la lógica de artículos
            ArticuloNegocio negocio = new ArticuloNegocio();

            // Se obtiene desde SQL una lista con nombres de artículos
            List<Articulo> lista = negocio.listarArticulos();

            // Recorre cada artículo de la lista y por cada araticulo genera una card bootstrap completa con su imagen, nombre, descripción y un botón para elegirlo.
            foreach (Articulo articulo in lista)
            {
                Response.Write(
                    "<div class='card m-3 p-3' style='width: 18rem; display:inline-block; vertical-align:top;'>"

                    + "<img src='" + articulo.ImagenUrl + "' class='card-img-top'>"

                    + "<div class='card-body'>"

                    + "<h5 class='card-title'>" + articulo.Nombre + "</h5>"

                    + "<p class='card-text'>" + articulo.Descripcion + "</p>"

                    + "<a href='DatosCliente.aspx?id=" + articulo.Id + "' class='btn btn-primary'>Elegir</a>"
                    //genera links con el id del artículo para que se pueda identificar cuál fue elegido en la página siguiente(parametro por url)

                    + "</div>"

                    + "</div>"
                );
            }
        }
    } 
}