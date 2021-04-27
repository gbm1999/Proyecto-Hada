<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Info.aspx.cs" Inherits="HadaPopWeb.Info" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .top {
            height: 628px;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <link rel="stylesheet" href="Info.css" />
<div class="center-container">
    <div class="logo">
    <img src="images/logo_small.png" style="height: 81px; width: 102px"/></div>

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
    
    <div class="seguridad-container">
        <div class="texto_seguridad">Realiza tus compras y ventas de forma rápida y segura. Utiliza el método de pago que más se adapte a ti. Nuestra prioridad es ponertelo fácil.</div>
        <div class="seguridad">
        <img src="images/57584.png" style="height: 81px; width: 102px"/></div>
    </div>
    
    <div class="atencion-container">
        <div class="atencion">
        <img src="images/logo_atencion.png" style="height: 81px; width: 102px"/>
        </div>
        <div class="texto_atencion">
        Si tiene algún problema no dude en reportarlo. ¡En nuestro Centro de Soporte estamos deseando poder ayudarte!
        </div>
    </div>
    

    
</div>

   </asp:Content>
