<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Comisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Especialidades
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .add-esp {
            background: #f3f3f3;
            padding: 5px 7px;
            border-radius: 1px;
            margin-bottom: 1rem;
            display: block;
            border: 0.3px solid #e0dada;
            text-align: center;
        }

            .add-esp:hover {
                background: #07323e;
                color: white;
            }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <a class="add-esp" href="Esp.aspx">Agregar Especialidad </a>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsEspecialidades">
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="desc_especialidad" HeaderText="desc_especialidad" SortExpression="desc_especialidad" />
                <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" Visible="False" />

                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Esp.aspx?id={0}" Text="Editar" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Esp.aspx?id={0}&type=1" Text="Borrar" />

            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="odsEspecialidades" runat="server" DataObjectTypeName="Business.Entities.Especialidad" DeleteMethod="DeleteOne" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.EspecialidadLogic" UpdateMethod="Save">
            <DeleteParameters>
                <asp:Parameter Name="ID" Type="Int32" />
            </DeleteParameters>
        </asp:ObjectDataSource>
    </div>
</asp:Content>
