<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewPassword.aspx.cs" Inherits="UI.Web.NewPassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Nueva Contraseña
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="add-xxx-box add-box">
        <fieldset>
            <asp:Label Text="Nueva Contraseña" runat="server" />
            <input required placeholder="escribe tu nueva  contrseña " type="password" id="txtPassword" runat="server"  value="" />
        </fieldset>
        <fieldset>
            <asp:Button CssClass="btn-add" Text="ChangePassword" ID="btnChangePassword" runat="server" OnClick="btnChangePassword_Click" />
        </fieldset>
        <asp:Label Visible="false" Text="" CssClass="errorBox" ID="errorChangePassword" runat="server" />
    </div>
</asp:Content>
