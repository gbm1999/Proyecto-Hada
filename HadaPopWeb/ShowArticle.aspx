<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ShowArticle.aspx.cs" Inherits="HadaPopWeb.ShowArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/ShowArticle.css" />

     <div class="center-container">
         
         <div class="foto">
             <img src="images/depositphotos_324611040-stock-illustration-no-image-vector-icon-no.jpg" />
         </div>

         <div class="debajo-imagen">
             
             <div class="campos-izq">
                 NOMBRE:
                 <asp:TextBox id="nombre" runat="server"></asp:TextBox>
             </div>

             <div class="campos-izq">
                 CIUDAD:
                 
                 <asp:TextBox name="Ciudad" id="Ciudad" runat="server"></asp:TextBox>

             </div>
         </div>

         <div class="descripcion">
             <asp:TextBox name="Descripcion" id="Descripcion" runat="server" TextMode="MultiLine" Height="218px" Width="317px"></asp:TextBox>
         </div>

         <div class="vendedor">
                 VENDEDOR:
                <asp:ImageButton id="contacto" runat="server" ImageUrl="images/contact.png" Height="62px" Width="72px"/>

                <asp:TextBox id="vendedor" runat="server"></asp:TextBox>
                <asp:TextBox id="numero" runat="server"></asp:TextBox>
        </div>

        <div class="precio">

            PRECIO:
            <asp:TextBox name="Precio" id="Precio" runat="server"></asp:TextBox>
        </div>
         
         <div class="modificar">
             <asp:Button runat="server" Text="MODIFICAR" ID="modificar" OnClick="modificar_Click"/>
         </div>
         
    </div>
    <div class="texto_modificado">
        <asp:Label ID="Label1" runat="server" Text="" backcolor="white"></asp:Label>

    </div>
</asp:Content>

