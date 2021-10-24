<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NuevoInscripto.aspx.cs" Inherits="UI.Web.NuevoInscripto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .box-nuevo-curso {
            width: 100%;
            margin: auto;
            display: flex;
            justify-content: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-nuevo-curso">

        <div class="add-xxx-box">
            <div class="header-add-x">
                <asp:Label Text="Nuevo Inscripto" ID="lblAction" runat="server" />
            </div>
            <div class="add-box">
                <fieldset>
                    <asp:Label Text="Legajo Alumno" runat="server" />
                    <asp:DropDownList ID="ddlAlumno" runat="server" DataTextField="Legajo"></asp:DropDownList>
                </fieldset>
                <!--
                <fieldset>
                    <asp:Label Text="Materia" ID="lblMateria" runat="server" />
                    <asp:DropDownList ID="ddlMateria" runat="server" DataTextField="DescMateria" DataValueField="ID"></asp:DropDownList>
                </fieldset>
                <fieldset>
                    <asp:Label Text="Comision" ID="lblComision" runat="server" />
                    <asp:DropDownList ID="ddlComison" runat="server" DataTextField="DescComision" DataValueField="ID"></asp:DropDownList>
                </fieldset> -->

                <fieldset>
                    <asp:Label Text="Curso" runat="server" />
                    <asp:DropDownList ID="ddlCurso" runat="server" DataTextField="ID" DataValueField="ID" OnSelectedIndexChanged="ddlCurso_SelectedIndexChanged"></asp:DropDownList>
                </fieldset>

                <fieldset visible="false" id="otherFields" runat="server">
                    <fieldset>
                        <asp:Label Text="Nota" runat="server" />
                        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
                    </fieldset>
                    <fieldset>
                        <asp:Label Text="Condicion" runat="server" />
                        <asp:DropDownList ID="ddlCondicion" runat="server">
                            <asp:ListItem Selected="True">_seleccionar Condicion_</asp:ListItem>
                            <asp:ListItem>Aprobada</asp:ListItem>
                            <asp:ListItem>Cursando</asp:ListItem>
                            <asp:ListItem>Libre</asp:ListItem>
                            <asp:ListItem>Regular</asp:ListItem>
                        </asp:DropDownList>
                    </fieldset>
                </fieldset>
                <fieldset>
                    <asp:Button Text="Inscribir" ID="btnInscribir" runat="server" OnClick="btnInscribir_Click" />
                </fieldset>
            </div>
        </div>
    </div>
</asp:Content>
