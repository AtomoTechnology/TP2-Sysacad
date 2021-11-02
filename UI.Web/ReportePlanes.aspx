<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ReportePlanes.aspx.cs" Inherits="UI.Web.ReportePlanes" %>

<%@ Register Assembly="BoldReports.WebForms" Namespace="BoldReports.WebForms" TagPrefix="Bold" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Academia | Reporte Plan 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="dgvReportePlanes" runat="server">
</asp:GridView>
    <Bold:ReportViewer ID="ReportViewer1" runat="server" ProcessingMode="Local" ReportPath="UI.Web.ReportViewerPlanes.rdlc"></Bold:ReportViewer>
    
</asp:Content>
