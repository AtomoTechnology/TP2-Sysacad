<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Especialidades.aspx.cs" Inherits="UI.Web.Comisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Especialidades
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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

    <div class="add-xxx-box">
        <div class="header-add-x">
            <asp:Label ID="lblAccion" runat="server" Text="Alta"></asp:Label>
        </div>
        <div class="add-plan">

            <fieldset>
                <asp:Label Text="Descripcion" ID="lblDesc" runat="server" />
                <input type="text" name="name" value="" runat="server" id="txtDescPlan" />
                <asp:Label Text="" ID="errorAddPlan" CssClass="error error-add-plan" runat="server" />
                <fieldset>
                    <asp:Button Text="Agregar" ID="btnAddEsp" runat="server"  ToolTip="Agregar un Plan" OnClick="btnAddPlan" />
                </fieldset>
            </fieldset>
            <br />
            <br />

        </div>
    </div>
</asp:Content>
