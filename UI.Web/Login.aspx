<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UI.Web.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Login</title>
    <style>
        * {
            padding: 0;
            margin: 0;
        }

        #form1 {
            width: 100%;
            height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .login {
            width: 350px;
            height: auto;
            background: #f6f5f5;
            border-radius: 3px;
            box-shadow: 1px 2px 10px rgba( 0,0,0,0.5 );
            padding: 10px;
            display: flex;
            flex-direction: column;
            gap: 1rem;
            justify-content: center;
            align-content: center;
            align-items: center;
        }

        input {
            border: none;
            outline: none;
            padding: 8px 10px;
            margin: 5px 0px;
            border-radius: 3px;
            border: 0.4px solid rgba(0,0,0,0.2);
            width: 90%;
            background: #e6e4e4;
            transition: ease-in-out 300ms;
        }

            input:focus {
                border: none;
                border-bottom: 2px solid #e2a900;
            }

        fieldset {
            width: 100%;
            display: flex;
            flex-direction: column;
            background: transparent;
            border: none;
            outline: none;
        }

        #btnLogin {
            border: none;
            outline: none;
            padding: 8px 10px;
            margin: 5px 0px;
            border-radius: 3px;
            text-align: center;
            background: #e2a900;
            width: 97%;
            font-size: 20px;
            color: #031c1c;
            font-family: fantasy;
            cursor: pointer;
        }

            #btnLogin:hover {
                background: #ffc414;
            }


        .logo {
            width: 100px;
            height: 100px;
            border-radius: 50%;
            background: white;
            overflow: hidden;
            box-shadow: 1px 2px 1px #ff9800, -2px -2px 2px #607d8b
        }
    </style>
    <link href="app.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
            <div class="logo">
                <img src="https://play-lh.googleusercontent.com/on7AWbuav44mB2ztIB6mp1BUu6bhIMcNd-9YjbjNDxgViamcJ3bo1dkEo06EGbC7njw" width="100" alt="Logo UTN" />
            </div>
            <h3>Inicia Session</h3>
            <fieldset>
                <asp:Label Text="Nombre Usuario" ID="lblUsername" runat="server" />
                <input type="text" name="txtUsername" ID="txtUsername" runat="server" value="" />
            </fieldset>
            <fieldset>
                <asp:Label Text="Contraseña" ID="lblPassword" runat="server" />
                <input type="password"  ID="txtPassword" runat="server" name="txtPassword" value="" />
            </fieldset>
            <fieldset>
                <asp:Button Text="Inicia Sesion" ID="btnLogin" runat="server" OnClick="btnLogin_Click" />
            </fieldset>
            <fieldset>
                <a href="#">Olvidé mi Contrseña</a>
               
            </fieldset>
        </div>
    </form>
</body>
</html>
