<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HadaPopWeb.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Profile.css" />
    <div class="body">
        <div class ="CuadroExt">
            <div class="divimgdatos">
                <div class = "imgperfbox">
                    <div class="img">
                        <img src="images/sinperfil.png"/>
                
                        <label id ="NumVentas" runat ="server">0</label>
                        <label>Ventas</label>
                        <label id ="NumCompras" runat ="server">0</label>
                        <label>Compras</label>
                    </div>
                </div>
                <!-- COMIENZO DATOS USU -->
                <div class="datosusu" runat ="server">

                    <div class = "labtext"> <!-- Nombre -->
                        <label class="labels">Nombre: </label>
                        <asp:TextBox ID="TBNombre" class="textboxes" runat="server"></asp:TextBox>
                    </div>

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Email -->
                        <label class="labels">Email: </label>
                        <asp:TextBox ID="TBEmail" class="textboxes" runat="server"></asp:TextBox>
                    </div>  

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- NIF -->
                        <label class="labels">NIF: </label>
                        <asp:TextBox ID="TBNif" class="textboxes" runat="server"></asp:TextBox>
                    </div> 

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Edad -->
                        <label class="labels">Edad: </label>
                        <asp:TextBox ID="TBEdad" class="textboxes" runat="server"></asp:TextBox>
                    </div> 

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Tlfno -->
                        <label class="labels">Teléfono: </label>
                        <asp:TextBox ID="TBTelefono" class="textboxes" runat="server"></asp:TextBox>
                    </div> 
                    <!-- FIN DATOSUSU -->
                    <div class="separadorvert"></div>
            
                    <asp:Button ID="Butt_Edit" runat="server" class= "butteditar" Text="Editar" OnClick = "Editar" />

                    <asp:Button ID="Butt_Env" runat="server" class= "butteditar" Text="Enviar" OnClick ="Enviar"/>

                </div>
        </div>
<!-- Por el momento y dado que es solo la interfaz, hemos puesto ejemplos de prueba sobre como se verían algunas funciones-->
            <div class ="ComentArticulos">
                <div class="Articulos">
                    <h2>Artículos del usuario: </h2>
                    <div class="Articulo">
                        <div class="ArtImgDiv">
                            <label class="TitleUsu"> Artículo1</label>
                            <asp:Image ID="Article1Img" CssClass="ImgArticle" ImageUrl="~/images/depositphotos_324611040-stock-illustration-no-image-vector-icon-no.jpg" runat="server" />
                        </div>
                            <p class="Coment">Esta es la descripción del Artículo</p>
                    </div>

                </div>
                <div class="Comentarios">   
                    <h2>Comentarios del Usuario:</h2>
                    <div>
                       <label class="TitleUsu">Usuario1:</label>
                       <label class="TitleAccion">Vendió [Artículo 1] [5/5]</label>
                       <p class="Coment">Esto es un comentario de Ejemplo Sobre como funcionan los comentarios en nuestra Web</p>
                    </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
