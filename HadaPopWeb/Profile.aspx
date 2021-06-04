<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HadaPopWeb.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/Profile.css" />
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
        <div class ="CuadroExt ">
            <div class="divimgdatos ">
                    <div class="img_profileDiv ">
                      
                        <asp:Image ID="ImageUser" runat="server" CssClass="img_profile borde"/>                   
                        <asp:Label ID="Controltarget" runat="server"  Text=""></asp:Label>
                       
                        
                    </div>
               
                    <div class="ventComp ">
                        <asp:Label ID="NumVenta" runat="server" Text=""></asp:Label>
                        <label>Ventas</label>
                        <asp:Label ID="NumCompra" runat="server" Text=""></asp:Label>
                        <label>Compras</label>
                    </div>
                <!-- COMIENZO DATOS USU -->
                <div class="datosusu" runat ="server">

                    <div class = "labtext"> <!-- Nombre -->
                        <label class="labels">Nombre: </label>
                        <asp:TextBox ID="TBNombre" class="textboxes" runat="server"></asp:TextBox>
                        <asp:Label ID="ErrorNombre" runat="server" class="ErrorNombre" Text=""></asp:Label>
                    </div>

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Email -->
                        <label class="labels">Email: </label>
                        <asp:TextBox ID="TBEmail" class="textboxes" runat="server"></asp:TextBox>
                         <asp:Label ID="ErrorEmail" runat="server" class="ErrorEmail" Text=""></asp:Label>
                    </div>  

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- NIF -->
                        <label class="labels">NIF: </label>
                        <asp:TextBox ID="TBNif" class="textboxes" runat="server"></asp:TextBox>
                         <asp:Label ID="ErrorNif" runat="server" class="ErrorNif" Text=""></asp:Label>
                    </div> 

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Edad -->
                        <label class="labels">Edad: </label>
                        <asp:TextBox ID="TBEdad" class="textboxes" runat="server"></asp:TextBox>
                         <asp:Label ID="ErrorEdad" runat="server" class="ErrorEdad" Text=""></asp:Label>
                    </div> 

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Tlfno -->
                        <label class="labels">Teléfono: </label>
                        <asp:TextBox ID="TBTelefono" class="textboxes" runat="server"></asp:TextBox>
                         <asp:Label ID="ErrorTelefono" runat="server" class="ErrorTelefono" Text=""></asp:Label>
                    </div>
                    
                    <div class="separadorvert"></div>

                    <div class="labtext">
                            <label class="labels">Imagen: </label>
                            <asp:FileUpload ID="photo" class="FileUpload" runat="server" />
                        </div>
                    <!-- FIN DATOSUSU -->
                    <div class="separadorvert"></div>
            
                    <asp:Button ID="Butt_Edit" runat="server" class= "butteditar" Text="Editar" OnClick = "Editar" />

                    <asp:Button ID="Butt_Env" runat="server" class= "butteditar" Text="Enviar" OnClick ="Enviar"/>

                </div>
        </div>
<!-- Por el momento y dado que es solo la interfaz, hemos puesto ejemplos de prueba sobre como se verían algunas funciones-->
            <div class ="ComentArticulos ">
                <div class="Articulos ">
                    <h2>Artículos del usuario: </h2>
                    <div class="Articulo">
                        <asp:ImageButton ID="Articulo" runat="server" class="imagenArticulo" OnClick="imgArticle1_Click" ImageUrl="~/images/no-foto.jpg" />
                        <br>
                        <asp:Label ID="LabelArticulo1" runat="server" class="nombreArticulo"> </asp:Label>
                    </div>
                    <div>
                        <asp:Button ID="PrevButton" Text="Anterior" runat="server"  OnClick="Prev_Click" class="boton_ArticuloPrev"></asp:Button>
                        <asp:Button ID="NextButton" Text="Siguiente" runat="server" OnClick="Next_Click" class="boton_ArticuloNext"></asp:Button>
                    </div>
                </div>
                <div class="Comentarios">   
                    <h2>Comentarios del Usuario:</h2>
                    <div>
                        <asp:ListBox ID="Comentarios" runat="server" Class="comentarios-box" height="70%" width="100%"></asp:ListBox>
                    </div>
                    </div>
            </div>
        </div>
    </div>
</asp:Content>
