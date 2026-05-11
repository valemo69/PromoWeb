<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Default.aspx.cs" Inherits="PromoWeb.Default" %>
                                     <%-- Aca arriba esta la primer conexion de esta pagina con la master--%>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server"><%-- segunda conexion dentro de un lugar especifico de la master--%>
    
    <asp:Panel ID="pnlVoucher" runat="server" DefaultButton="btnValidar"><%--aca hace que aparte de el btn aceptar funcione con enter o intro del teclado--%> 
    <div class="container mt-5">
        <h1>Promo Web</h1>
        <p>Ingresá tu voucher promocional</p>

        <asp:TextBox ID="txtVoucher" runat="server" CssClass="form-control mb-3" placeholder="Código voucher"></asp:TextBox>

        <asp:Button ID="btnValidar" runat="server" Text="Validar Voucher" CssClass="btn btn-primary" OnClick="btnValidar_Click" />
        <asp:Label ID="lblMensaje" runat="server" Visible="false" CssClass="alert alert-danger d-block mt-3"></asp:Label>

    </div>
        </asp:Panel>

</asp:Content>