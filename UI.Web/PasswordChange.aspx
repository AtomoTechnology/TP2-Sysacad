<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="UI.Web.PasswordChange" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Change Password
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="add-xxx-box add-box">
        <fieldset>
            <asp:Label Text="Contraseña Actual " runat="server" />
            <input required placeholder="escribe tu contrseña actual" type="password" id="txtPassword" runat="server"  value="" />
        </fieldset>
        <fieldset>
            <asp:Button CssClass="btn-add" Text="Next" ID="btnNext" runat="server" OnClick="btnNext_Click" />
        </fieldset>
        <asp:Label Visible="false" Text="" CssClass="errorBox" ID="errorChangePassword" runat="server" />
    </div>
</asp:Content>
