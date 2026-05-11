using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PromoWeb.Dominio
{
    public class Articulo
    {
        // Id único del artículo en base de datos
        public int Id { get; set; }

        // Nombre del premio/artículo
        public string Nombre { get; set; }

        // Descripción del artículo
        public string Descripcion { get; set; }

        // URL de imagen del artículo
        public string ImagenUrl { get; set; }
    }
}