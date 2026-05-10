using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PromoWeb.Negocio;

namespace PromoWeb
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)// evento onclick del boton validar, se ejecuta cada vez que se hace click en el boton
        {
            string codigo = txtVoucher.Text;

            VoucherNegocio negocio = new VoucherNegocio();
            bool valido = negocio.validarVoucher(codigo);

            if (valido)
                Response.Redirect("SeleccionPremio.aspx");
            else
                Response.Write("Voucher inválido");
        }
    }
}