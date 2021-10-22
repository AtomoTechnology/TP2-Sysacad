<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Usuarios.aspx.cs" Inherits="TP2L06.Usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Usuarios</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContentPlaceHolder" runat="server">
    <asp:GridView ID="gridPanel" runat="server" DataKeyNames="ID" OnSelectedIndexChanged="gridPanel_SelectedIndexChanged">
    <Columns>
        <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
        <asp:BoundField DataField="Apellido" HeaderText="Apellido" />
        <asp:BoundField DataField="Email" HeaderText="EMail" />
        <asp:BoundField DataField="NombreUsuario" HeaderText="Usuario" />
        <asp:BoundField DataField="Habilitado" HeaderText="Habilitado" />
        <asp:CommandField ShowSelectButton="True" />
    </Columns>
</asp:GridView>
    <asp:Panel ID="formPanel" Visible="false" runat="server">
        <asp:Label ID="nombreLabel" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="nombreTextBox" runat="server" ></asp:TextBox>  
        <asp:Label ID="eNombre" runat="server" ForeColor="#CC0000" Text="*" Visible="False"></asp:Label>
        <br />

           <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
        <asp:TextBox ID="apellidoTextBox" runat="server" ></asp:TextBox>  
        <asp:Label ID="eApellido" runat="server" ForeColor="#CC0000" Text="*" Visible="False"></asp:Label>
        <br />

           <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server" ></asp:TextBox>  
        <asp:Label ID="eEmail" runat="server" ForeColor="#CC0000" Text="*" Visible="False"></asp:Label>
        <br />

           <asp:Label ID="Label3" runat="server" Text="Habilitado"></asp:Label>
        <asp:CheckBox ID="habilitadoTextBox" runat="server" ></asp:CheckBox>  <br />

         <asp:Label ID="Label6" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="nombreUsuarioTextBox" runat="server" ></asp:TextBox>  
        <asp:Label ID="eNombreUsuario" runat="server" ForeColor="#CC0000" Text="*" Visible="False"></asp:Label>
        <br />

           <asp:Label ID="Label4" runat="server" Text="Clave"></asp:Label>
        <asp:TextBox ID="claveTextBox" runat="server" ></asp:TextBox>  
        <asp:Label ID="eClave" runat="server" ForeColor="#CC0000" Text="*" Visible="False"></asp:Label>
        <br />

            <asp:Label ID="Label5" runat="server" Text="Confirmar Clave"></asp:Label>
        <asp:TextBox ID="reprtirClaveTextBox" runat="server" ></asp:TextBox>  
        <asp:Label ID="eRepetirClave" runat="server" ForeColor="#CC0000" Text="*" Visible="False"></asp:Label>
        <br />

    </asp:Panel>
     <asp:Panel ID="gridActionPanel"  runat="server">
       <asp:LinkButton ID="EditarLinkButton" runat="server" OnClick="EditarLinkButton_Click">Editar</asp:LinkButton>
       <asp:LinkButton ID="EliminarLinkButton" runat="server" OnClick="EliminarLinkButton_Click">Eliminar</asp:LinkButton>
       <asp:LinkButton ID="nuevoLinkButton" runat="server" OnClick="nuevoLinkButton_Click">nuevo</asp:LinkButton>

    </asp:Panel>
     <asp:Panel ID="formActionPanel" runat="server">
       <asp:LinkButton ID="aceptarLinkButton" runat="server" OnClick="aceptarLinkButton_Click">Aceptar</asp:LinkButton>
       <asp:LinkButton ID="cancelarLinkButton" runat="server" OnClick="cancelarLinkButton_Click">Cancelar</asp:LinkButton>
    </asp:Panel>
</asp:Content>
