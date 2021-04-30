<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="HadaPopWeb.AddArticle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .Precio {
            height: 21px;
            width: 85px;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
            <link rel="stylesheet" href="AddArticle.css" />
            <div class="centro">
                <div class="titulo">
                    AÑADIR PRODUCTO
                </div>

                <div class="container-abajo">
                    <div class="parametros-izq">
                        <div class="texto">
                            NOMBRE:
                            <input type="text" class="input" name="nombre" id="nombre"/>

                        </div>

                        <div class="texto">
                            CIUDAD:
                            <input type="text" class="input" name="ciudad1" id="ciudad1"/>
                            

                        </div>

                        <div class="texto">
                            DESCRIPCIÓN:
                           
                        </div>

                         <div class="areaDesc">
                            <textarea  class="AddDescription text-cuadro" name="description" id="description"> </textarea>
                        

                        </div>
                </div>
                
                    
               <div class="parametros-der">
                   <div class="texto">
                            PRECIO:
                            <input type="text" class="input" name="precio" id="precio"/>

                        </div>

                   <div class="texto">
                            CATEGORÍA:
                            <input type="text" class="input" name="categoria" id="categoria"/>

                        </div>

                  

                        <div class="texto">
                            FOTO:
                            <input type="file" class="inputPhoto" name="file" id="file" />
                           
                        </div>

                        

              </div>

            </div>
              
                
           
                <div class="Create">
                    <button type="submit" class="boton">Create</button>
                </div>   

                  </div>

</asp:Content>
