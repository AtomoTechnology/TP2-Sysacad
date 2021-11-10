<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inscripciones.aspx.cs" Inherits="UI.Web.Inscripciones" %>

<%@ Register Src="~/ddlplanes.ascx" TagPrefix="uc1" TagName="ddlplanes" %>


<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Inscripciones
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .box {
            display: flex;
            flex-direction: column;
            padding: 1rem;
            width: 90%;
            overflow: hidden;
            justify-content: center;
            gap: 1rem;
        }

        .btn-nuevo {
            width: max-content;
            background: white;
            transition: 500ms ease-in-out;
            padding: 5px 0.3rem;
            text-align: center;
            color: white !important;
            border-radius: 3px;
            box-shadow: 1px 3px 5px #ebebeb;
            border: 0.4px solid #cccccc;
        }

        

        .btn-nuevo:hover {
            background: #d29f08;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div runat="server" id="ModalBox" visible="false" class="modal-box">
        <div class="modal modal-delete-materia">
            <div class="header-add-x">
                <asp:Label Text="¿ Estás seguro ? " ID="Label1" runat="server" />
            </div>
            <div class="btns">
                <asp:Button Text="Borrar" CssClass="btn-delete" ID="btnDelete" runat="server" OnClick="btnDelete_Click"  />
                <asp:Button Text="Cancelar" CssClass="btn-cancel" ID="bntCancer" runat="server" OnClick="bntCancer_Click"  />
            </div>
        </div>
    </div>
    <div class="box">

        <div class="btn-nuevo">
            <a href="NuevoInscripto.aspx">Nuevo Inscripto</a>
        </div>
        <asp:GridView ID="dgvInscripciones" runat="server" DataKeyNames="ID" OnSelectedIndexChanged="dgvInscripciones_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Legajo" HeaderText="Legajo" />
                <asp:BoundField DataField="NombreCompleto" HeaderText="NombreCompleto" />
                <asp:BoundField DataField="DescMateria" HeaderText="Materia" />
                <asp:BoundField DataField="DescComision" HeaderText="Comision" />
                <asp:BoundField DataField="NotaString" HeaderText="Nota" />
                <asp:BoundField DataField="Condicion" HeaderText="Condicion" />
                <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="NuevoInscripto.aspx?id={0}" Text="Editar" />
                <asp:CommandField SelectText="Borrar"  ShowSelectButton="True" />
            </Columns>
        </asp:GridView>
    </div>

    <uc1:ddlplanes runat="server" id="ddlplanes" />

</asp:Content>
