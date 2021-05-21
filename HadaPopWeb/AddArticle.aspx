﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="HadaPopWeb.AddArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Controltarget" runat="server" Text=""></asp:Label>
            <link rel="stylesheet" href="AddArticle.css" />
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
                            <asp:Button class="PopupAceptar" runat="server" Text="Login" OnClick="PopUpLogin"></asp:Button>
                        </div>               
        </asp:Panel>
            <div class="centro">
                <div class="titulo">
                    AÑADIR PRODUCTO
                </div>

                <div class="container-abajo">
                    <div class="parametros-izq">
                        <div class="texto">
                            NOMBRE:
                            <asp:TextBox ID="name" runat="server" CssClass="input" name="name" />

                            

                        </div>

                        <div class="texto">
                            CIUDAD:
                            <asp:TextBox ID="ciudad" runat="server" class="input" name="ciudad" />
                            

                        </div>

                        <div class="texto">
                            DESCRIPCIÓN:
                           
                        </div>

                         <div class="areaDesc">
                            <asp:TextBox runat="server"  class="AddDescription text-cuadro" name="description" id="description"> </asp:TextBox>
                        

                        </div>
                </div>
                
                    
               <div class="parametros-der">
                   <div class="texto">
                            PRECIO:
                            <asp:TextBox ID="precio" class="input" runat="server" name="precio" />

                        </div>

                   <div class="texto">
                            CATEGORÍA:
                            <asp:TextBox ID="categoria" class="input" runat="server" name="categoria" />

                        </div>

                   

                        <div class="texto">
                            FOTO:
                            
                            <asp:FileUpload ID="photo" runat="server" />
                        </div>

                  <div>
                      <asp:Label runat="server" ID="Label1"></asp:Label>
                  </div>

                        
                   
              </div>

                    


                    

            </div>

                 <div class="esp-boton">
                         <asp:Button id="create"
                           Text="Create"
                           CommandName="Submit"
                           class="boton"
                           runat="server" OnClick="create_Click"/>
                    </div>
              
                
           
                 

           </div>
           
           
                 
                          
               

</asp:Content>
