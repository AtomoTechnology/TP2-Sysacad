<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoInscripto.aspx.cs" Inherits="UI.Web.NuevoInscripto" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

    <div class="add-xxx-box">
        <div class="header-add-x">
            <asp:Label Text="Nuevo Inscripto" runat="server" />
        </div>
        <div class="add-box">
            <fieldset>
                <asp:Label Text="Legajo Alumno" runat="server" />
                <asp:DropDownList ID="ddlAlumno" runat="server" DataTextField="Legajo" DataValueField="ID"></asp:DropDownList>
            </fieldset>
            <fieldset>
                <asp:Label Text="Curso" runat="server" />
                <asp:DropDownList ID="ddlCurso" runat="server" DataTextField="ID" DataValueField="ID"></asp:DropDownList>
            </fieldset>
            <fieldset>
                <asp:Button Text="Inscribir" ID="btnInscribir" runat="server" />
            </fieldset>
        </div>
    </div>
    </div>
</asp:Content>
