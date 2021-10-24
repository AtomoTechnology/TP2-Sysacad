<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisDatos.aspx.cs" Inherits="UI.Web.MisDatos" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academai | Mis datos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            width: 90%;
            margin: auto;
        }

        .user-header {
            height: 100px;
            overflow: hidden;
            display: flex;
            background: white;
            margin: 0.4rem 0px;
            box-shadow: 1px 2px 10px #e7e0e0;
            border-bottom: 2px solid #d6d6d6;
            gap: 1rem;
            padding: 10px;
        }

        .item-user {
            transition: 300ms ease-in-out;
            margin-bottom: 0.4rem;
            transition: 300ms ease-in-out;
            padding: 10px 7px;
        }

            .item-user:hover {
                background: #042f48;
            }

        .user-content {
            margin: 1rem 0px;
        }

        .side-bar {
            background: white;
            /*            box-shadow: 1px 1px 10px #c0bbbb;*/
            border-right: 2px solid #d6d6d6;
        }


        .container img {
            width: 150px;
        }

        .user-content {
            display: grid;
            gap: 1rem;
            grid-template-columns: 25% 70%;
            justify-content: center;
        }

        .user-datos {
            padding: 10px;
            /*            background: #00000012;*/
            /*            box-shadow: 1px 1px 10px #061e2e14, -1px -1px 10px #061e2e4f;*/
        }

            .user-datos section {
                width: 90%;
                background: white;
                border-radius: 4px;
                box-shadow: 1px 2px 10px #d6d6d6;
                padding: 10px;
                margin: auto;
                margin: 1rem 0px;
                border: 0.2px solid #d6d6d6bf;
            }

                .user-datos section fieldset {
                    width: 80%;
                }

                .user-datos section .title {
                    font-size: 20px;
                    font-weight: 700;
                    font-family: sans-serif;
                }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="user-header">

            <img src="https://www.pngitem.com/pimgs/m/256-2560275_avatar-icon-red-png-clipart-png-download-red.png" alt="Logo User" />

            <div class="user-header-right">
                Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
            </div>

        </div>
        <div class="user-content">
            <div class="side-bar">
                <ul>
                    <li class="item-user">
                        <a href="#datos-personal">Datos personal</a>

                    </li>
                    <li class="item-user">
                        <a href="#datos-cuenta">Datos Cuenta</a>

                    </li>
                    <li class="item-user">
                        <a href="#datos-materia">Datos personal</a>

                    </li>

                </ul>
            </div>
            <div class="user-datos">
                <section id="datos-personal">
                    <asp:Label Text="Datos Personal" CssClass="title" runat="server" />
                    <div>

                        <fieldset>
                            <asp:Label Text="Nombre" runat="server" />
                            <input type="text" name="name" id="txtNombre" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Apellido" runat="server" />
                            <input type="text" id="txtApellido" name="name" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Legajo" runat="server" />
                            <input type="text" id="txtLegajo" name="name" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Telefono" runat="server" />
                            <input type="text" id="txtTelefono" name="name" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Direccion" runat="server" />
                            <input type="text" id="txtDireccion" name="name" readonly value="" />
                        </fieldset>

                    </div>
                </section>
                <section id="datos-cuenta">
                    <asp:Label Text="Datos Cuenta" CssClass="title" runat="server" />
                    <div>
                        <fieldset>
                            <asp:Label Text="Nombre Usuario" runat="server" />
                            <input type="text" id="txtUsuario" readonly name="name" value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Email" runat="server" />
                            <input type="email" id="txtEmail" readonly name="name" value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Contraseña" runat="server" />
                            <input type="password" id="textPassword" readonly name="name" value="abx123" />
                        </fieldset>
                    </div>
                </section>

                <section id="datos-materia">
                    <asp:Label Text="Materias Aprobadas" CssClass="title" runat="server" />
                    <div>
                        <fieldset>
                            <asp:Label Text="Nombre Usuario" runat="server" />
                            <input type="text" id="" readonly name="name" value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Email" runat="server" />
                            <input type="email" id="" readonly name="name" value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Contraseña" runat="server" />
                            <input type="password" id="" readonly name="name" value="abx123" />
                        </fieldset>
                    </div>
                </section>
            </div>
        </div>
    </div>
</asp:Content>


