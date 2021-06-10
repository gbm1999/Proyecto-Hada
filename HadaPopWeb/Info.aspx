<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="HadaPopWeb.Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <link rel="stylesheet" href="estilos/Info.css" />
            <link rel="preconnect" href="https://fonts.gstatic.com">
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap" rel="stylesheet">



<div class="center-container">
        

        <div class="titulo">
           Quienes somos
        </div>
        <div class="texto">
        HadaPop es una empresa en continua evolución. Una compañía nueva, dinámica, que desea hacerte la vida más fácil. </div>
        
    

    <div class="descripcion">
        Los clientes serán capaces de realizar transacciones de compra-venta de artículos de cualquier tipo,
        donde el usuario será el encargado de gestionar sus ventas y sus compras, 
        teniendo la posibilidad de subir sus propios artículos e interactuar con otros usuarios. 
        Nosotros proporcionamos la plataforma, la seguridad, privacidad de datos y la gestión del transporte de los productos.</div>

   
          
    <div>
        
        <div class="atencion-container">
            <asp:ImageButton runat="server" CssClass="atimg" OnClick="Facebook_Click" src="images/logoFacebook.png" />
        </div> 
    </div>
    <div class="foto-empresa">
        <asp:Image runat="server" src="images/HRTrends-que-es-el-empowerment-en-una-empresa.jpg" />
    </div>

    <div class="oficinas">
        <asp:Image runat="server" src="images/oficinas.jpg" />
    </div>"
    

    
</div>

   </asp:Content>
