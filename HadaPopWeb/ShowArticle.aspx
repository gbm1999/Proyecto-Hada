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
         <div class="foto">
             <img src="images/depositphotos_324611040-stock-illustration-no-image-vector-icon-no.jpg" />
         </div>

         <div class="debajo-imagen">
             <div class="campos-izq">
                 PRECIO:
                 <input type="text" class="parametro-introducido" name="Precio" id="Precio"/>

             </div>

             <div class="campos-izq">
                 CIUDAD:
                 <input type="text" class="parametro-introducido" name="Ciudad" id="Ciudad"/>

             </div>

         </div>

         <div class="descripcion">
             <textarea  class="AddDescription text-cuadro" name="description" id="description"> </textarea>
         </div>

         <div class="vendedor">
             <div class="campos-izq">
                 VENDEDOR:
                 <input type="text" class="parametro-introducido" name="Vendedor" id="Vendedor"/>

             </div>

         </div>
        

     </div>

</asp:Content>

