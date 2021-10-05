<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaUsuarios.aspx.cs" Inherits="UI.Web.ListaUsuarios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="app.css" />
    <style>
        #form1 {
            display: flex;
            flex-direction: column;
            justify-content: center;
            align-items: center;
            width: 90%;
            margin: auto;
        }

        input {
            outline: none;
            border: none;
            padding: 7px 10px;
            background: #ecebeb;
            border: 0.3px solid #0000002b;
            border-radius: 2px;
        }

        .cl {
            background: white;
            border: none;
            margin: auto;
            padding: 0.5rem;
            width: 95%;
            display: flex;
            justify-content: center;
            align-items: center;
            border-radius: 3px;
            box-shadow: 1px 2px 10px #040c16c7;
            margin-bottom: 1rem;
            margin-top: 1rem;
        }

        .add-user {
            margin-top: 1rem;
            width: auto;
            margin: auto;
            background: white;
            display: flex;
            justify-content: center;
            /*            align-items : center ;*/
        }

        .add-user-box {
            box-shadow: 1px 2px 6px grey;
            width: auto;
            margin: auto;
            display: flex;
            flex-direction: column;
            gap: 1rem;
            justify-content: center;
            align-items: center;
            margin-top : 1rem ;
        }

        fieldset {
            border: none;
            outline: none;
            display: flex;
            flex-direction: column;
            gap: 1rem;
        }

        .header-add-user {
            width: 100%;
            display: block;
            margin: auto;
            text-align: center;
            text-transform: capitalize;
            box-shadow: 1px 2px 6px #c1c0c087;
            background: #ff9800;
            padding: 5px 0px;
        }

            .header-add-user span {
                font-size: 25px;
                text-transform: capitalize;
            }

        .actions {
            display: flex;
            justify-content: space-around;
            width: 94%;
            margin-top: 1rem;
            gap: 1rem;
            margin-bottom: 1rem;
        }

        #btnGuardar {
            background: #ff9800;
            flex: 1;
            font-size: 20px;
            border: none;
            cursor: pointer;
            color: #05161e;
        }

        #btnCancelar {
            background: #05161e;
            flex: 1;
            font-size: 20px;
            border: none;
            cursor: pointer;
            color: white;
        }

        tr {
            padding: 10px;
            border: none;
            outline: none;
            background: #f2f2f2;
            height: 30px;
        }
    </style>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="tabl">
        </div>
        <div class="lista_usuario" style="font-family: Arial; font-size: medium; font-style: normal; background-color: #FFFFFF; border: thin none #C0C0C0; padding: 6px; margin: 2px; cursor: pointer; overflow: auto; border-spacing: inherit">

            <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" DataSourceID="odsUsuarios" Height="270px">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" Visible="False" />
                    <asp:BoundField DataField="Legajo" HeaderText="Legajo" SortExpression="Legajo" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
                    <asp:BoundField DataField="IdPersona" HeaderText="IdPersona" SortExpression="IdPersona" Visible="False" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" SortExpression="Apellido" />
                    <asp:BoundField DataField="DescTipoPersona" HeaderText="DescTipoPersona" SortExpression="DescTipoPersona" />
                    <asp:BoundField DataField="DescPlan" HeaderText="DescPlan" SortExpression="DescPlan" />
                    <asp:BoundField DataField="IdPlan" HeaderText="IdPlan" SortExpression="IdPlan" Visible="False" />
                    <asp:BoundField DataField="FechaNac" HeaderText="FechaNac" SortExpression="FechaNac" Visible="False" />
                    <asp:BoundField DataField="Telefono" HeaderText="Telefono" SortExpression="Telefono" />
                    <asp:BoundField DataField="Direccion" HeaderText="Direccion" SortExpression="Direccion" Visible="False" />
                    <asp:BoundField DataField="TipoPersona" HeaderText="TipoPersona" SortExpression="TipoPersona" Visible="False" />
                    <asp:BoundField DataField="NombreUsuario" HeaderText="NombreUsuario" SortExpression="NombreUsuario" />
                    <asp:BoundField DataField="Clave" HeaderText="Clave" SortExpression="Clave" Visible="False" />
                    <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" Visible="False" />
                    <asp:CheckBoxField DataField="Habilitado" HeaderText="Habilitado" SortExpression="Habilitado" />
                    <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" Visible="False" />
                    <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="ListaUsuarios.aspx?id={0}" Text="Editar" />
                </Columns>
            </asp:GridView>
        </div>
        <div class="add-user-box">

            <div class="header-add-user">
                <asp:Label ID="lblAccion" runat="server" Text="Label"></asp:Label>
            </div>
            <section class="add-user">
                <div>
                    <fieldset>
                        <asp:Label Text="Apellido" runat="server" />
                        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Nombre" runat="server" />
                        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Tipo persona" runat="server" />

                        <asp:RadioButtonList ID="tipoPersona" runat="server">
                            <asp:ListItem Value="1">Administrador</asp:ListItem>
                            <asp:ListItem Value="2">Docente</asp:ListItem>
                            <asp:ListItem Value="3">Alumno</asp:ListItem>
                        </asp:RadioButtonList>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Plan" runat="server" />
                        <select runat="server" id="planes">
                            <option value="10">2010</option>
                        </select>
                    </fieldset>

                </div>
                <div>
                    <fieldset>
                        <asp:Label Text="Legajo" runat="server" />
                        <asp:TextBox ID="txtNroDocumento" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Fecha Nac." runat="server" />
                        <input runat="server" type="date" id="txtFechaNacimiento" />
                    </fieldset>

                    <fieldset>
                        <asp:Label Text="Direccion" runat="server" />
                        <asp:TextBox ID="txtDirección" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Telefono" runat="server" />
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </fieldset>
                </div>
                <div>

                    <fieldset>
                        <asp:Label Text="Email" runat="server" />
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Nombre Usuario" runat="server" />
                        <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Contraseña" runat="server" />
                        <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Confirma Contrseña" runat="server" />
                        <asp:TextBox ID="txtConfirmarClave" runat="server" TextMode="Password"></asp:TextBox>
                    </fieldset>

                </div>
            </section>
            <div class="actions">
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Width="137px" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" />

            </div>

        </div>
        <asp:ObjectDataSource ID="odsUsuarios" runat="server" DeleteMethod="Delete" SelectMethod="GetAll" TypeName="Data.Database.UsuarioAdapter">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
            <SelectParameters>
                <asp:Parameter Name="tipoPersona" Type="Int32" />
            </SelectParameters>
        </asp:ObjectDataSource>

    </form>
</body>
</html>
