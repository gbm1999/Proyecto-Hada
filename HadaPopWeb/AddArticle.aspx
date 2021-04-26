<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddArticle.aspx.cs" Inherits="HadaPopWeb.AddArticle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Add Article</title>
    <link rel="stylesheet" href="AddArticle.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
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
                            FOTO:
                            <input type="file" class="inputPhoto" name="file" id="file" />
                           
                        </div>

                        

               </div>

                </div>
                
            </div>
        
    </form>
</body>
</html>
