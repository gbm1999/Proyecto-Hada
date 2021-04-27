<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowArticle.aspx.cs" Inherits="HadaPopWeb.ShowArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Precio {
            height: 21px;
            width: 85px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="ShowArticle.css" />

     <div class="center-container">

                <div class="ciudad">
                    Ciudad</div>

                <div class="foto">
                     
                     <img src="images/logo_small.png" />
                </div>

                <div class="precio">
                    Precio</div>

                <div class="texto">
                    Descripción:&nbsp;
                </div>

                <div class="texto">
                    Vendedor:&nbsp;
                </div>

             </div>

</asp:Content>

