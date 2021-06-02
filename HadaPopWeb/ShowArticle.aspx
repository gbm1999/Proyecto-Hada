<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowArticle.aspx.cs" Inherits="HadaPopWeb.ShowArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/ShowArticle.css" />
     <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@100&display=swap" rel="stylesheet">
    <link rel="preconnect" href="https://fonts.gstatic.com">
    <link href="https://fonts.googleapis.com/css2?family=Poppins&family=Roboto:wght@100&display=swap" rel="stylesheet">   

     <div class="center-container">
         
         <div class="foto">
             <img src="images/depositphotos_324611040-stock-illustration-no-image-vector-icon-no.jpg" />
         </div>

         <div class="debajo-imagen">
             
             <div class="campos-izq">
                 NOMBRE:
                 <asp:TextBox id="nombre" CssClass="input-d" runat="server"></asp:TextBox>
             </div>

             <div class="campos-izq">
                 CIUDAD:
                 
                 <asp:TextBox name="Ciudad" id="Ciudad" CssClass="input-d" runat="server"></asp:TextBox>

             </div>

             <div class="campos-izq">
                 PRECIO:
                 <asp:TextBox name="Precio" id="Precio" CssClass="input-d" runat="server"></asp:TextBox>

             </div>
         </div>

         <div class="descripcion">
             <asp:TextBox name="Descripcion" id="Descripcion" runat="server" CssClass="desc" TextMode="MultiLine" Height="218px" Width="317px"></asp:TextBox>
         </div>
         

         <div class="vendedor">
                 DATOS DEL VENDEDOR

                
                <asp:TextBox id="vendedor" CssClass="input-t" runat="server"></asp:TextBox>
                <asp:TextBox id="numero" CsScLASS="input-t" runat="server"></asp:TextBox>
        </div>

       
         
          
         <div class="modificar">
             <asp:Button runat="server" Text="MODIFICAR" ID="modificar" CssClass="dis-boton" OnClick="modificar_Click"/>
             <asp:Button runat="server" Text="BORRAR" CssClass="dis-boton" ID="Button2" />
         </div>
         
    </div>
    <div class="texto_modificado">
        <asp:Label ID="Label1" runat="server" Text="" backcolor="white"></asp:Label>

    </div>
</asp:Content>

