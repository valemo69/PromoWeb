using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace PromoWeb.Dominio
{
    public class Cliente
    {
        // Nombre del cliente
        public string Nombre { get; set; }

        // Apellido del cliente
        public string Apellido { get; set; }

        // Email del cliente
        public string Email { get; set; }

        // DNI del cliente
        public string Dni { get; set; }

        // Dirección del cliente
        public string Direccion { get; set; }

        // Ciudad del cliente
        public string Ciudad { get; set; }

        // Código postal
        public int CP { get; set; }
    }
}