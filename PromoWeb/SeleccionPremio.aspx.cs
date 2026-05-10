using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromoWeb.Negocio;

namespace PromoWeb
{
    public partial class SeleccionPremio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Se crea objeto negocio para poder acceder a la lógica de artículos
            ArticuloNegocio negocio = new ArticuloNegocio();

            // Se obtiene desde SQL una lista con nombres de artículos
            List<string> lista = negocio.listarArticulos();

            // Recorre cada artículo de la lista
            foreach (string articulo in lista)
            {
                // Imprime cada artículo en pantalla dentro de una etiqueta <p>
                Response.Write("<p>" + articulo + "</p>");
            }
        }
    }
}