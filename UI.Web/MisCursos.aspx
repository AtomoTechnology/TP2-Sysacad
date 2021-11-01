<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MisCursos.aspx.cs" Inherits="UI.Web.MisCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
Academia | Mis Cursos</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvMisCursos" runat="server">
    <Columns>
        <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
        <asp:BoundField DataField="DescComision" HeaderText="Comision" />
        <asp:BoundField DataField="DescCargo" HeaderText="Cargo" />
        <asp:BoundField DataField="NombreCompleto" HeaderText="Docente" />
    </Columns>
</asp:GridView>
</asp:Content>
