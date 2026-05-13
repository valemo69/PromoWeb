<%@ page language="C#" autoeventwireup="true" masterpagefile="~/Site.Master" codebehind="DatosCliente.aspx.cs" inherits="PromoWeb.DatosCliente" %>

<%-- Esta página utiliza Site.Master como estructura general del sitio --%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- Espacio reservado para CSS o scripts específicos de esta página --%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <%-- Sección búsqueda por DNI --%>
    <div class="mb-4">

        <label class="form-label">DNI</label>

        <div class="input-group">

            <asp:TextBox
                ID="txtBuscarDni"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>

            <asp:Button
                ID="btnBuscarDni"
                runat="server"
                Text="Buscar"
                CssClass="btn btn-primary"
                OnClick="btnBuscarDni_Click"/>
        </div>
    </div>

    <%-- Contenido principal de la pantalla de datos del cliente --%>

    <asp:Panel
    ID="pnlFormulario"
    runat="server"
    Visible="false">

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



        <%-- Campo dirección --%>
        <div class="mb-3">
            <label class="form-label">Dirección</label>

            <asp:TextBox
                ID="txtDireccion"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <%-- Campo ciudad --%>
        <div class="mb-3">
            <label class="form-label">Ciudad</label>

            <asp:TextBox
                ID="txtCiudad"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <%-- Campo código postal --%>
        <div class="mb-3">
            <label class="form-label">Código Postal</label>

            <asp:TextBox
                ID="txtCP"
                runat="server"
                CssClass="form-control">
            </asp:TextBox>
        </div>

        <%-- Botón finalizar --%>
        <asp:Button
            ID="btnFinalizar"
            runat="server"
            Text="Participar!"
            CssClass="btn btn-success"
            OnClick="btnFinalizar_Click" />

    </div>
        </asp:Panel>

</asp:Content>
