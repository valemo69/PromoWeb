<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="DatosCliente.aspx.cs" Inherits="PromoWeb.DatosCliente" %>

<%-- Esta página utiliza Site.Master como estructura general del sitio --%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- Espacio reservado para CSS o scripts específicos de esta página --%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%-- Contenido principal de la pantalla de datos del cliente --%>

    <div class="container mt-5">

    <%-- Título principal --%>
    <h1>Datos del Cliente</h1>

    <p>Completá tus datos para finalizar el canje</p>

    <%-- Campo nombre --%>
    <div class="mb-3">
        <label class="form-label">Nombre</label>

        <asp:TextBox
            ID="txtNombre"
            runat="server"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <%-- Campo apellido --%>
    <div class="mb-3">
        <label class="form-label">Apellido</label>

        <asp:TextBox
            ID="txtApellido"
            runat="server"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <%-- Campo email --%>
    <div class="mb-3">
        <label class="form-label">Email</label>

        <asp:TextBox
            ID="txtEmail"
            runat="server"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <%-- Campo DNI --%>
    <div class="mb-3">
        <label class="form-label">DNI</label>

        <asp:TextBox
            ID="txtDni"
            runat="server"
            CssClass="form-control">
        </asp:TextBox>
    </div>

    <%-- Botón finalizar --%>
    <asp:Button
        ID="btnFinalizar"
        runat="server"
        Text="Finalizar Canje"
        CssClass="btn btn-success" />

</div>

</asp:Content>
