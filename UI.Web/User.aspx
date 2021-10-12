<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="UI.Web.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | User
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="esp-action">
        <asp:Label Text="" ID="lblId" runat="server" />
        <input type="text" name="" id="txtDesc" " />
        <asp:Button Text="Actualizar" runat="server" />
    </div>
</asp:Content>
