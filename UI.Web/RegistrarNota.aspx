<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegistrarNota.aspx.cs" Inherits="UI.Web.RegistrarNota" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Registra Nota
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .container{
            gap: 1rem;
    display: flex;
    flex-direction: column;
        }
        .filtro{
            
            display: flex;
            gap: 2rem;
            align-items : center ;
            justify-content : center ;
            background: white;
            padding: 10px;
            border: 0.3px solid #e6e3e3;
            box-shadow: 1px 2px 10px #dcd4d4;
                border-radius: 4px;
        }

    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div>
            <asp:Label Text="Filtro" runat="server" />
        </div>
    <div class="filtro">
        <fieldset>
            <asp:Label Text="Materia" ID="lblMateria" runat="server" />
            <asp:DropDownList ID="ddlMaterias" runat="server" DataTextField="DescMateria" DataValueField="ID"></asp:DropDownList>
        </fieldset>
         <fieldset>
            <asp:Label Text="Comision" ID="lblComision" runat="server" />
            <asp:DropDownList ID="ddlComisiones" runat="server" DataTextField="DescComision" DataValueField="ID"></asp:DropDownList>
        </fieldset>        
            <asp:Button Text="Filtrar" ID="btnFiltrar" runat="server" OnClick="btnFiltrar_Click" />
    </div>
    <div class="inscripciones-box">
        <asp:GridView ID="gvInscripciones" runat="server">
            <Columns>
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="NombreCompleto" HeaderText="Alumno" />
                <asp:BoundField DataField="DescComision" HeaderText="Comision" />
                <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
                <asp:BoundField DataField="notaString" HeaderText="Nota" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
            </Columns>
        </asp:GridView>
    </div>
    </div>
</asp:Content>
