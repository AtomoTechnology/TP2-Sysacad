<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Planes.aspx.cs" Inherits="UI.Web.Planes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Planes
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/plan.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="odsPlanes">
        <Columns>
            <asp:BoundField DataField="DescEspecialidad" HeaderText="Desc. Especialidad" SortExpression="DescEspecialidad" />
            <asp:BoundField DataField="DescPlan" HeaderText="Desc. Plan" SortExpression="DescPlan" />
            <asp:BoundField DataField="IdEspecialidad" HeaderText="IdEspecialidad" SortExpression="IdEspecialidad" Visible="False" />
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" Visible="False" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" Visible="False" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Planes.aspx?id={0}" Text="Editar" />
             <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Planes.aspx?id={0}" Text="Borrar" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="odsPlanes" runat="server" DataObjectTypeName="Business.Entities.Plan" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic" UpdateMethod="Save">
        <DeleteParameters>
            <asp:Parameter Name="ID" Type="Int32" />
        </DeleteParameters>
    </asp:ObjectDataSource>

    <div class="add-plan-box">
        <div class="add-plan">
                
            <fieldset>
                <asp:Label Text="Descripcion" ID="lblDesc" runat="server" />
                <input type="text" name="name" value="" runat="server"  id="txtDesc"/>
            </fieldset>

              <fieldset>
                <asp:Label Text="Descripcion" ID="Label1" runat="server" />
                <input type="text" name="name" value="" runat="server"  id="Text1"/>
            </fieldset>
            <fieldset>
                <asp:Button Text="Agregar Plan" ID="bntAddPlan" runat="server" />
            </fieldset>

        </div>
    </div>
   
</asp:Content>
