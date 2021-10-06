<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UI.Web.SignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Sign In
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="login">
        <div class="logo">

            <img src="https://play-lh.googleusercontent.com/on7AWbuav44mB2ztIB6mp1BUu6bhIMcNd-9YjbjNDxgViamcJ3bo1dkEo06EGbC7njw" width="100" alt="Logo UTN" />

        </div>

        <h3>Inicia Session </h3>

        <fieldset>
            <asp:Label Text = "Nombre Usuario" ID="lblUsername" runat="server" />
            <asp:TextBox ID="txtUsuarname" runat="server"></asp:TextBox>

        </fieldset>

        <fieldset>
            <asp:Label Text = "Contraseña" ID="lblPassword" runat="server" />            
              <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>

        </fieldset>

        <fieldset>
            <asp:Button Text = "Inicia Sesion" CssClass="btn-login" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
        </fieldset>
        <fieldset>
            <a class="forget-password" href="#">Olvidé mi Contrseña</a>
        </fieldset>
        <fieldset id="signInFailedBox" runat="server"  class="sign-in-failed">
            <asp:Label ID="lblSignInFailed" runat="server" />
        </fieldset>
    </div>
</asp:Content>
