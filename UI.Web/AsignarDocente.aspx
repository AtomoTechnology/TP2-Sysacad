<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AsignarDocente.aspx.cs" Inherits="UI.Web.AsignarDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Asignar Docente
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .container {
            width: 80%;
            display: flex;
            flex-direction: column;
            gap: 1rem 0rem;
            margin: auto;
            align-items: center;
            justify-content: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div>
            <asp:GridView ID="gvAsignaciones" runat="server"></asp:GridView>
        </div>
        <div class="add-xxx-box">
            <div class="header-add-x">
                <asp:Label Text="Asignar Docente" ID="lblAction" runat="server" />
            </div>
            <div class="add-box">
                <fieldset>
                    <asp:Label Text="ID Curso" runat="server" />
                    <input type="text" readonly runat="server" id="txtIdCurso" value="" />
                </fieldset>

                <fieldset>
                    <asp:Label Text="Docente" runat="server" />
                    <asp:DropDownList ID="ddlDocente" runat="server">
                    </asp:DropDownList>
                </fieldset>
                <fieldset>
                    <asp:Label Text="Cargo" runat="server" />
                    <asp:DropDownList ID="ddlCargo" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                        <asp:ListItem>3</asp:ListItem>
                    </asp:DropDownList>
                </fieldset>
                <fieldset>
                    <asp:Button Text="Asignar" ID="btnAsignar" runat="server" OnClick="btnAsignar_Click" />
                </fieldset>
                <asp:Label Text="" ID="lblError" class="errorBox" Visible="false" runat="server" />


            </div>
        </div>
    </div>

</asp:Content>
