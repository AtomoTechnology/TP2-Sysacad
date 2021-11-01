<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Esp.aspx.cs" Inherits="UI.Web.Esp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Especialidad
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style>
        .esp-action {
            display: flex;
            background: rgb(255 255 255 / 54%);
            justify-content: space-between;
            flex-direction: column;
            padding: 10px;
            height: auto;
            border-radius: 3px;
            box-shadow: 1px 2px 10px grey;
        }
        #lblId{
            margin-bottom : 1rem ;
        }
        .btnUpdateEsp{
            background :  #ff9800 ;
        }
    </style>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Label Text="Agregar una especialidad" ID="lblId" runat="server" />
    <div class="esp-action">
        <fieldset>
            <asp:Label Text="Descripcion" runat="server" />
            <input type="text" runat="server" name="" id="txtDesc" />
            <asp:Label Text="" ID="errorDesc" CssClass="errorinput" runat="server" />
        </fieldset>
        <fieldset>
            <asp:Button Text="Actualizar" CssClass="btnUpdateEsp" ID="btnUpdateEsp" runat="server" OnClick="btnUpdateEsp_Click" />
        </fieldset>
    </div>
</asp:Content>
