﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="articulos.aspx.cs" Inherits="HadaPopWeb.articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="categoria-articulos.css" />
    <div class="centro">
        <div class="titulo">
            ARTICULOS
        </div>

        <div class="tabla">

        </div>
    </div>
    <div class="plus">
        <a href="AddArticle.aspx" rel="create">
        <img src="images/add.png" />
            </a>
            
    </div>

</asp:Content>