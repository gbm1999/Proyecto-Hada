<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowArticle.aspx.cs" Inherits="HadaPopWeb.ShowArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/ShowArticle.css" />

     <div class="center-container">
         
         <div class="foto borde">
             <img src="images/depositphotos_324611040-stock-illustration-no-image-vector-icon-no.jpg" />
         </div>

         <div class="debajo-imagen borde">
             
             <div class="campos-izq">
                 NOMBRE:
                 <asp:TextBox id="nombre" CssClass="parametros" runat="server"></asp:TextBox>
             </div>

             <div class="campos-izq">
                 CIUDAD:
                 <asp:TextBox name="Ciudad" id="Ciudad" CssClass="parametros" runat="server"></asp:TextBox>
             </div>

             <div class ="campos-izq">
                PRECIO:
                <asp:TextBox name="Precio" id="Precio" CssClass="parametros" runat="server"></asp:TextBox>

             </div>
         </div>

         <div class="descripcion">
             <asp:TextBox name="Descripcion" CssClass="AddDescription" id="Descripcion" runat="server" TextMode="MultiLine" Height="218px" Width="317px"></asp:TextBox>
         </div>

         <div class="vendedor borde">
                 DATOS DEL VENDEDOR:
                

                <asp:TextBox id="vendedor" CssClass="vendedor-parametros" runat="server"></asp:TextBox>
                <asp:TextBox id="numero" CssClass="vendedor-parametros" runat="server"></asp:TextBox>
        </div>

        
         
         <div class="modificar borde">
             <asp:Button runat="server" CssClass="modificar-boton" Text="MODIFICAR" ID="modificar" OnClick="modificar_Click"/>
             <asp:Button runat="server" CssClass="modificar-boton" Text="BORRAR" ID="borrar" />
         </div>
         
    </div>
    <div class="texto_modificado">
        <asp:Label ID="Label1" runat="server" Text="" backcolor="white"></asp:Label>

    </div>
</asp:Content>

