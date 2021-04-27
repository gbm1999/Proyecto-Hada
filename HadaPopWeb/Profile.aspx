<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HadaPopWeb.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Profile.css" />

    <div class = "imagenbox">
        <div class="imagen">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/images/logo_small.png" />
        </div>
    </div>
    
</asp:Content>
