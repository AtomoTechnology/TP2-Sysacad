<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReporteCursos.aspx.cs" Inherits="UI.Web.ReporteCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Reporte Cursos
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvReporteCursos" runat="server">
    <Columns>
        <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
        <asp:BoundField DataField="NombreCompleto" HeaderText="Nombre Completo" />
        <asp:BoundField DataField="IdCurso" HeaderText="Id Curso" />
        <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
        <asp:BoundField DataField="DescComision" HeaderText="Comision" />
        <asp:BoundField DataField="notaString" HeaderText="Nota" />
        <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
    </Columns>
</asp:GridView>
</asp:Content>
