<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Materias.aspx.cs" Inherits="UI.Web.Materias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Materias</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
       
    </style>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div runat="server" id="ModalBox" visible="false" class="modal-box">
        <div class="modal modal-delete-materia">
            <div class="header-add-x">
                <asp:Label Text="¿ Estás seguro ? " ID="Label1" runat="server" />
            </div>
            <div class="btns">
                <asp:Button Text="Borrar" CssClass="btn-delete" ID="btnDelete" runat="server" OnClick="btnDelete_Click" />
                <asp:Button Text="Cancelar" CssClass="btn-cancel" ID="bntCancer" runat="server" OnClick="bntCancer_Click" />
            </div>
        </div>
    </div>

    <asp:GridView ID="dgvMaterias" runat="server" OnSelectedIndexChanged="dgvMaterias_SelectedIndexChanged" DataKeyNames="ID">
        <Columns>
            <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
            <asp:BoundField DataField="HsSemanales" HeaderText="HS Semanales" />
            <asp:BoundField DataField="HsTotales" HeaderText="HS Totales" />
            <asp:BoundField DataField="DescPlan" HeaderText="Plan" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Materias.aspx?id={0}" Text="Editar" />           
            <asp:CommandField ItemStyle-CssClass="btn-delete-materia" NewText="Borrar" ShowSelectButton="True" SelectText="Borrar" >
<ItemStyle CssClass="btn-delete-materia"></ItemStyle>
            </asp:CommandField>
        </Columns>
    </asp:GridView>

    <div class="add-xxx-box">
        <div class="header-add-x">
            <asp:Label Text="Alta" ID="lblAction" runat="server" />
        </div>
        <div class="add-fields">
            <fieldset id="desc" runat="server">
                <asp:Label Text="Descripcion Materia" runat="server" />
                <input type="text" name="desc" value="" runat="server" id="txtDesc" placeholder="Ej : Analisis 1" />
            </fieldset>
            <fieldset>
                <asp:Label Text="Horas Semanales" ID="txtHorasSemanales" runat="server" />
                <input type="number" name="hss" value="" runat="server" placeholder="3 Horas Semanales " id="txtHsSemanales" max="10" min="1" />
            </fieldset>
            <fieldset>
                <asp:Label Text="Horas Totales" ID="lblHsTotales" runat="server" />
                <input type="number" name="hst" value="" placeholder="9 Horas Totales " runat="server" id="txtHsTotales" max="150" min="1" />
            </fieldset>
            <fieldset>
                <asp:Label Text="Plan" ID="lblDdlPlan" runat="server" />
                <asp:DropDownList ID="ddlPlanes" runat="server" DataTextField="DescPlan" DataValueField="ID">
                </asp:DropDownList>
                <fieldset>
                    <asp:Button Text="Agregar Materia" CssClass="btn-add" ID="addMateria" runat="server" OnClick="addMateria_Click" />
                </fieldset>
            </fieldset>
            <div class="errorBox" runat="server" id="errorsBox"></div>
            <input type="hidden" name="id" value="" class="id-materia-delete" id="idMateria" runat="server" />
            <asp:Label Text="" ID="lblId" class="lblId" runat="server" />
            &nbsp;
        </div>
    </div>
</asp:Content>
