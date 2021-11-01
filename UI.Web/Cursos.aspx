<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Cursos.aspx.cs" Inherits="UI.Web.Cursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Cursos 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="dgvCursos" runat="server" DataKeyNames="ID" OnSelectedIndexChanged="dgvCursos_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
            <asp:BoundField DataField="DescComision" HeaderText="Comision" />
            <asp:BoundField DataField="AnioCalendario" HeaderText="Año" />
            <asp:BoundField DataField="Cupo" HeaderText="Cupo" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="AsignarDocente.aspx?id={0}" HeaderText="Asignar Docente" Text="Asignar" />
            <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="Cursos.aspx?id={0}" Text="Editar" />
            <asp:CommandField HeaderText="Borrar" ShowHeader="True" SelectText="Borrar" ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <div class="add-xxx-box">
        <div class="header-add-x">
            <asp:Label Text="Alta" ID="lblAction" runat="server" />
        </div>
        <div class="add-box">
            <fieldset>
                <asp:Label Text="Comision"  runat="server" />
                <asp:DropDownList ID="ddlComisiones" runat="server" DataTextField="DescComision" DataValueField="ID">
                </asp:DropDownList>
            </fieldset>
            <fieldset>
                <asp:Label Text="Materia" runat="server" />
                <asp:DropDownList ID="ddlMateria" runat="server" DataTextField="DescMateria" DataValueField="ID">
                </asp:DropDownList>
            </fieldset>
            <fieldset>
                <asp:Label ID="lblAnioCalendario" runat="server" Text="Año Calendario"></asp:Label>
                <asp:TextBox ID="txtAnioCalendario" runat="server"></asp:TextBox>
                <asp:Label Visible="false" Text="Año Calendario obligatorio" ID="lblAnioCalendarioError" CssClass="errorBox" runat="server" />
            </fieldset>
            <fieldset>
                <asp:Label ID="lblCupo" runat="server" Text="Cupo"></asp:Label>
                <asp:TextBox ID="txtCupo" runat="server"></asp:TextBox>
                <asp:Label Visible="false" Text="Cupo obligatorio" ID="lblCupoError" CssClass="errorBox" runat="server" />

            </fieldset>
            <fieldset>
                <asp:Button Text="Agregar" ID="btnAgregarCurso" runat="server" OnClick="btnAgregarCurso_Click" />
            </fieldset>
            
        </div>
    </div>

</asp:Content>
