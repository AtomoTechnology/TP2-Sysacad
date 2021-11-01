<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="UI.Web.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </div>
</asp:Content>
