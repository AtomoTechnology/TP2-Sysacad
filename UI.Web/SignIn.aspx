<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="UI.Web.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Academia Login</title>
    <link href="Styles/login.css" rel="stylesheet" />
    <link href="Styles/main.css" rel="stylesheet" />
    <style>
        #form1 {
            display: flex;
            justify-content: center;
            align-items: center;
            width: 100%;
            height: 100vh;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <div class="logo">

                <img src="https://play-lh.googleusercontent.com/on7AWbuav44mB2ztIB6mp1BUu6bhIMcNd-9YjbjNDxgViamcJ3bo1dkEo06EGbC7njw" width="100" alt="Logo UTN" />

            </div>

            <h3>Inicia Session </h3>

            <fieldset>
                <asp:Label Text="Nombre Usuario" ID="lblUsername" runat="server" />
                <asp:TextBox ID="txtUsuarname" Text="jhmesseroux_profe" runat="server"></asp:TextBox>

            </fieldset>

            <fieldset>
                <asp:Label Text="Contraseña" ID="lblPassword" runat="server" />
                <asp:TextBox ID="txtPassword" Text="utn2021." runat="server"></asp:TextBox>

            </fieldset>

            <fieldset>
                <asp:Button Text="Inicia Sesion" CssClass="btn-login" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
            </fieldset>
            <fieldset>
                <a class="forget-password" href="#">Olvidé mi Contrseña</a>
            </fieldset>
            <fieldset id="signInFailedBox" runat="server" class="sign-in-failed">
                <asp:Label ID="lblSignInFailed" runat="server" />
            </fieldset>
        </div>
    </form>
</body>
</html>
