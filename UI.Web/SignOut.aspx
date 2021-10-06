<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignOut.aspx.cs" Inherits="UI.Web.SignOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
    <style>
        body {
            padding: 0;
            margin: 0;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
        }

        .sign-out {

            display: flex;
            justify-content: center;
            align-content: center;
            text-align: center;
            background: #ff5722;
            font-size: 20px;
            padding: 6px;
            width: 250px;
            border-radius: 50px;
            color: white;
            text-decoration: underline;
            text-transform: uppercase;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="sign-out">
            <asp:Label Text="Sign out" runat="server" />
        </div>
    </form>
</body>
</html>
