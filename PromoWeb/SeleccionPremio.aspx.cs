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

            // Recorre cada artículo de la lista
            foreach (Articulo articulo in lista)
            {
                // Muestra nombre del artículo
                Response.Write("<h3>" + articulo.Nombre + "</h3>");

                // Muestra descripción del artículo
                Response.Write("<p>" + articulo.Descripcion + "</p>");

                // Línea separadora visual
                Response.Write("<hr>");
            }
        }
    } 
}