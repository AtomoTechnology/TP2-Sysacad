<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Comisiones.aspx.cs" Inherits="UI.Web.Comisiones" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Comisiones
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 0;
        }

        .btnAdd {
            background: #ff9800;
        }

        .error {
            BACKGROUND: #f3c9c9;
            color: RED;
            padding: 5px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="gvComisiones" runat="server" AutoGenerateColumns="False" CssClass="auto-style1" DataSourceID="odsComisiones">
        <Columns>
            <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
            <asp:BoundField DataField="DescComision" HeaderText="DescComision" SortExpression="DescComision" />
            <asp:BoundField DataField="AnioEspecialidad" HeaderText="AnioEspecialidad" SortExpression="AnioEspecialidad" />
            <asp:BoundField DataField="DescPlan" HeaderText="DescPlan" SortExpression="DescPlan" />
            <asp:BoundField DataField="IdPlan" HeaderText="IdPlan" SortExpression="IdPlan" Visible="False" />
            <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" Visible="False" />
        </Columns>
    </asp:GridView>
    <div class="add-xxx-box">
        <div class="header-add-x">
            <asp:Label ID="lblAccion" runat="server" Text="Label"></asp:Label>
        </div>
        <div style="padding: 10px;">
            <fieldset>
                <asp:Label Text="Descripcion" ID="lblDesc" runat="server" />
                <input type="text" runat="server" id="txtDesc" value="" />
            </fieldset>
            <fieldset>
                <asp:Label Text="Año" runat="server" />
                <input type="text" runat="server" id="txtAno" value="" />
            </fieldset>
            <fieldset>

                <asp:DropDownList ID="ddlPlanes" runat="server" DataSourceID="odsPlanes" DataTextField="DescPlan" DataValueField="ID">
                </asp:DropDownList>
            </fieldset>
            <fieldset>
                <asp:Button Text="Agregar Comision" CssClass="btnAdd" ID="btnAddComision" runat="server" OnClick="btnAddComision_Click" />
            </fieldset>
            <fieldset>
                <div class="error" runat="server" id="errorBox">

                </div>
            </fieldset>
            &nbsp;<asp:ObjectDataSource ID="odsPlanes" runat="server" SelectMethod="GetAll" TypeName="Business.Logic.PlanLogic"></asp:ObjectDataSource>
            <asp:ObjectDataSource ID="odsComisiones" runat="server" DataObjectTypeName="Business.Entities.Comision" DeleteMethod="Delete" InsertMethod="Save" SelectMethod="GetAll" TypeName="Business.Logic.ComisionLogic" UpdateMethod="Save">
                <DeleteParameters>
                    <asp:Parameter Name="id" Type="Int32" />
                </DeleteParameters>
            </asp:ObjectDataSource>


        </div>
    </div>
</asp:Content>
