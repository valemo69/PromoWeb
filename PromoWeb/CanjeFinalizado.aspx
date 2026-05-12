<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="CanjeFinalizado.aspx.cs" Inherits="PromoWeb.CanjeFinalizado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-5">

        <div class="card p-5 text-center shadow">

            <h1 class="text-success mb-4">
                ¡Canje realizado correctamente!
            </h1>

            <p class="mb-4">
                Gracias por participar de Promo Web.
            </p>

            <asp:Button
                ID="btnInicio"
                runat="server"
                Text="Volver al inicio"
                CssClass="btn btn-primary"
                PostBackUrl="~/Default.aspx" />

        </div>

    </div>

</asp:Content>