﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="categoria.aspx.cs" Inherits="HadaPopWeb.categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="categoria-articulos.css" />
    <div class="centro">
        <div class="titulo">
            CATEGORIAS
        </div>

        <div class="tabla">

        </div>
    </div>

    <div class="plus">
        <a href="AddCategoria.aspx" rel="create">
        <img src="images/add.png" />
            </a>
            
    </div>
</asp:Content>