<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HadaPopWeb.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Profile.css" />
    <div class="body">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

        <ajaxToolkit:ModalPopupExtender ID="PopupNoLogin" runat="server" Enabled="true" TargetControlID="Controltarget" PopupControlID="PanelPopUpNoLogin" BackgroundCssClass="fondoPopup"></ajaxToolkit:ModalPopupExtender>
                   
        <asp:Panel ID="PanelPopUpNoLogin" runat="server" stile="display: none;background-color: white;width: auto;height: auto">
                        
            <div class="modal-header">
                <h5 class="modal-title" id="PopupTitleNoLogin">Error, no se puede operar de ninguna forma sin iniciar sesion.</h5>
                    </div>
                        <div class="modal-body">
                            Por favor inicie sesion para poder acceder a esta parte.
                        </div>
                        <div class="modal-footer">
                            <asp:Button class="btn PopupAceptar" runat="server" Text="Login" OnClick="PopUpLogin"></asp:Button>
                        </div>               
        </asp:Panel>
        <div class ="CuadroExt">
            <div class="divimgdatos">
                <div class = "imgperfbox">
                    <div class="img">
                        <asp:Image ID="ImageUser" runat="server"/>
                        <asp:Label ID="Controltarget" runat="server" Text=""></asp:Label>
                        <asp:Label ID="NumVenta" runat="server" Text=""></asp:Label>
                        <label>Ventas</label>
                        <asp:Label ID="NumCompra" runat="server" Text=""></asp:Label>
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
                        <asp:ListBox ID="Comentarios" runat="server" Class="Comentarios" height="70%" width="100%"></asp:ListBox>
                       
                        <label class="TitleUsu">Usuario1:</label>
                       <label class="TitleAccion">Vendió: </label><br />
                        <asp:Label ID="articulos" runat="server"></asp:Label>
                    </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
