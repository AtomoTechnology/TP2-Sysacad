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
            overflow: hidden;
            display: flex;
            background: white;
            margin: 0.4rem 0px;
            box-shadow: 1px 2px 10px #00000017;
            border-bottom: 2px solid #d6d6d6;
            gap: 1rem;
            padding: 10px;
            justify-content: space-between;
        }

        .user-header-right {
            display: flex;
            justify-content: flex-end;
            padding: 10px;
            min-width: 350px;
            gap: 1rem;
        }

        .item-user {
            transition: 300ms ease-in-out;
            margin-bottom: 0.4rem;
            transition: 300ms ease-in-out;
            padding: 10px 7px;
            border-bottom: 0.4px solid #d0c7c8;
        }

            .item-user:hover {
                background: #042f48;
            }



        .side-bar {
            background: #f2f1f1;
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
            margin: 1rem 0px;
/*            position: relative;*/
/*            z-index: -1;*/
            background: #fcfcfc;
        }

        .user-datos {
            padding: 10px;
          
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

        .lblMA {
            width: 25px;
            background: #d6d6d6;
            padding: 0.3rem;
            height: 25px;
            text-align: center;
            display: flex;
            justify-content: center;
            align-items: center;
            font-size: 20px;
            box-shadow: 1px 1px 10px #e2a9005c, -1px -1px 5px #e7e0e0;
            border-radius: 50%;
        }

        .box-img {
            width: 100px;
            height: 100px;
            overflow: hidden;
            display: flex;
            align-items: center;
            justify-content: center;
            box-shadow: 2px 3px 6px #061e2e;
            border-radius: 50%;
            padding: 10px;
        }

        .lblCant {
            text-align: center;
            font-size: 20px;
            margin-top: 10px;
        }

        .editar {
            margin-top: 10px;
            background: #e2a900;
            text-align: center;
            border-radius: 50px;
        }

        .change-password {
            background: #ff9800;
            border-radius: 50px;
            padding: 5px;
            text-align: center;
            font-size: 20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="user-header">
            <div class="box-img">

                <img  src="assets/logoUser.png" alt="Logo User" />
            </div>

            <div class="user-header-right">
                <fieldset>
                    <asp:Label Text="Usuario" ID="lblNombreCompleto" runat="server" />
                    <a class="editar" href="#">Editar Perfil</a>
                </fieldset>
                <fieldset visible="false" runat="server" id="userBoxmateria1">
                    <a href="#datos-cuenta">Materias Aprobadas</a>
                    <asp:Label Text="" ID="lblCantMatApro" CssClass="lblCant" runat="server" />
                </fieldset>

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
                    <li class="item-user" runat="server" id="itemMateria" visible="false">
                        <a href="#datos-cuenta">Materia(s) Aprobada(s)</a>
                    </li>

                </ul>
            </div>
            <div class="user-datos">
                <section id="datos-personal">
                    <asp:Label Text="Datos Personal" CssClass="title" runat="server" />
                    <div>

                        <fieldset>
                            <asp:Label Text="Nombre" runat="server" />
                            <input type="text" name="name" runat="server" id="txtNombre" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Apellido" runat="server" />
                            <input type="text" runat="server" id="txtApellido" name="name" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Legajo" runat="server" />
                            <input type="text" runat="server" id="txtLegajo" name="name" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Telefono" runat="server" />
                            <input type="text" runat="server" id="txtTelefono" name="name" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Direccion" runat="server" />
                            <input type="text" runat="server" id="txtDireccion" name="name" readonly value="" />
                        </fieldset>

                    </div>
                </section>
                <section id="datos-cuenta">
                    <asp:Label Text="Datos Cuenta" CssClass="title" runat="server" />
                    <div>
                        <fieldset>
                            <asp:Label Text="Nombre Usuario" runat="server" />
                            <input type="text" runat="server" id="txtUsuario" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Email" runat="server" />
                            <input type="text" runat="server" id="txtEmail" readonly value="" />
                        </fieldset>
                        <fieldset>
                            <asp:Label Text="Contraseña" runat="server" />
                            <input type="password" runat="server" id="txtPassword" readonly  value="" />
                        </fieldset>
                        <fieldset>
                            <a class="change-password" href="PasswordChange.aspx">Cambiar Contrseña</a>
                        </fieldset>
                    </div>
                </section>

                <section visible="false" runat="server" id="userBoxmateria2">
                    <asp:Label Text="Materias Aprobadas" CssClass="title" runat="server" />
                    <div>
                        <fieldset style="flex-direction: row; gap: 1rem; align-items: center; padding: 5px;">
                            <asp:Label Text="Cantidad Materia(s) Aprobada(s)" runat="server" />
                            <asp:Label Text="" ID="lblCantidadMateriasAprobadass" CssClass="lblMA" runat="server" />
                        </fieldset>
                        <fieldset>

                            <asp:GridView ID="gvMaterias" runat="server">
                                <Columns>
                                    <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
                                    <asp:BoundField DataField="DescComision" HeaderText="Comision" />
                                    <asp:BoundField DataField="notaString" HeaderText="Nota" />
                                </Columns>
                            </asp:GridView>
                        </fieldset>

                    </div>
                </section>
            </div>
        </div>
    </div>
</asp:Content>


