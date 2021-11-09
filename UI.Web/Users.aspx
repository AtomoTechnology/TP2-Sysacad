<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="UI.Web.Users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Usuarios
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/users.css" rel="stylesheet" />
    <style>
        .error-input {
            color: red;
            padding: 3px 5px;
            background-color: #e5b8b8;
            border-radius: 50px;
            text-align : center ;
        }

        .chkHabilitar {
            flex-direction: row;
            align-items: center;
            gap: 1rem;
        }
        .add-user-box.toggle{
            display : none ;
        }
    </style>

   

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="lista_usuario" style="font-family: Arial; font-size: medium; font-style: normal; background-color: #FFFFFF; border: thin none #C0C0C0; padding: 6px; margin: 2px; cursor: pointer; overflow: auto; border-spacing: inherit">
        <asp:GridView ID="grdUsuarios" runat="server" AutoGenerateColumns="False" Height="270px" DataKeyNames="ID">
            <Columns>
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
                <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre Usuario" />
                <asp:BoundField DataField="DescTipoPersona" HeaderText="Tipo Persona" />
                <asp:BoundField DataField="DescPlan" HeaderText="Plan" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Users.aspx?id={0}" HeaderText="Accion" Text="Editar" />
            </Columns>
        </asp:GridView>
         <div class="btn-nuevo btn-nuevo-usuario">
            Nuevo Usuario
        </div>
    </div>
    <div class="add-user-box toggle">

        <div class="header-add-x">
            <asp:Label ID="lblAccion" runat="server" Text="Alta"></asp:Label>
        </div>
        <section class="add-user">
            <div>
                <fieldset>
                    <asp:Label Text="Apellido * " runat="server" />
                    <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                    <asp:Label Text="Apellido Obligatorio" CssClass="error-input" ID="errorApellido" runat="server" Visible="False" />
                </fieldset>
                <fieldset>
                    <asp:Label Text="Nombre * " runat="server" />
                    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                    <asp:Label Text="Nombre Obligatorio" CssClass="error-input" ID="errorNombre" runat="server" Visible="False" />

                </fieldset>
                <fieldset>
                    <asp:Label Text="Tipo persona * " runat="server" />

                    <asp:RadioButtonList ID="tipoPersona" runat="server">
                        <asp:ListItem Value="1">Administrador</asp:ListItem>
                        <asp:ListItem Value="2">Docente</asp:ListItem>
                        <asp:ListItem Selected="True" Value="3">Alumno</asp:ListItem>
                    </asp:RadioButtonList>
                </fieldset>

            </div>
            <div>
                <fieldset>
                    <asp:Label Text="Legajo * " runat="server" />
                    <asp:TextBox ID="txtNroDocumento" runat="server"></asp:TextBox>
                    <asp:Label Text="Legajo Obligatorio" CssClass="error-input" ID="errorLegajo" runat="server" Visible="False" />

                </fieldset>
                <fieldset>
                    <asp:Label Text="Fecha Nac. *" runat="server" />
                    <input runat="server" type="date" id="txtFechaNacimiento" required="required" />
                </fieldset>

                <fieldset>
                    <asp:Label Text="Direccion" runat="server" />
                    <asp:TextBox ID="txtDirección" runat="server"></asp:TextBox>
                    <fieldset>
                        <asp:Label Text="Telefono" runat="server" />
                        <asp:TextBox ID="txtTelefono" runat="server"></asp:TextBox>
                    </fieldset>
                </fieldset>
                <fieldset class="chkHabilitar">
                    <asp:CheckBox ID="chkHabilitado" runat="server" Text="Habilitado" />
                </fieldset>
                &nbsp;
            </div>
            <div>
                <fieldset>
                    <asp:Label Text="Plan * " ID="lblPlan" runat="server" />
                    <asp:DropDownList ID="ddlPlanes" runat="server" DataTextField="DescPlan" DataValueField="ID">
                    </asp:DropDownList>

                </fieldset>
                <fieldset>
                    <asp:Label Text="Email *" runat="server" />
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    <asp:Label Text="Email Obligatorio y Valido" CssClass="error-input" ID="errorEmail" runat="server" Visible="False" />

                </fieldset>
                <fieldset>
                    <asp:Label Text="Nombre Usuario *" runat="server" />
                    <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                    <asp:Label Text="Nombre Usuario Obligatorio" CssClass="error-input" ID="errorNombreUsuario" runat="server" Visible="False" />

                </fieldset>
                <fieldset class="password" runat="server" id="password">
                    <asp:Label Text="Contraseña *" runat="server" />
                    <asp:TextBox ID="txtClave" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label Text="Clave Obligatorio" CssClass="error-input" ID="errorClave" runat="server" Visible="False" />

                </fieldset>
                <fieldset runat="server" id="passwordConfirm">
                    <asp:Label Text="Confirma Contrseña *" runat="server" />
                    <asp:TextBox ID="txtConfirmarClave" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label Text="Las claves deben ser igaules" CssClass="error-input" ID="errorConfirmClave" runat="server" Visible="False" />

                </fieldset>

                <input type="hidden" name="txtIdPersona" runat="server" id="txtIdPersona" />

            </div>
        </section>
        <div class="actions">
            <asp:Button ID="btnGuardar" CssClass="btn-guardar" runat="server" Text="Guardar" Width="137px" OnClick="btnGuardar_Click" />
            <asp:Button ID="btnCancelar" runat="server" CssClass="btn-cancelar" Text="Cancelar" />

        </div>
        <asp:Label Text="" CssClass="error" ID="error" runat="server" />

    </div>
    
 <script> 

     var add = document.querySelector(".btn-nuevo-usuario");
     var addUser = document.querySelector(".add-user-box");
     add.addEventListener("click", () => {        
         addUser.classList.toggle("toggle");
     });
 </script>
</asp:Content>