<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Categoriaconcrete.aspx.cs" Inherits="HadaPopWeb.Categoriaconcrete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Addcategoria.css" />
    <div class="centro">
        

        <div class="categoria">
                    <div class="nombre-categoria">
                        NOMBRE:
                        <asp:TextBox ID="nombre" runat="server" class="input-cat" name="nombre" />
                        <br />
                        <br />
                        DESCRIPCIÓN:
                    </div>
                    <div class="area-cat">
                            <asp:TextBox runat="server"  class="AddDescription text-cuadro" name="description" id="description"> </asp:TextBox>
                    </div>
       </div>

        
    </div>


    <div class="logos">
        <div class="borrar">
            <img  src="images/icons8-edit-64.png" role="button" onclick="editar_categoria">

        </div>"

        <div class="edit">
            <img src="images/delete.png" role="button" onclick="borrar_categoria" />
        </div>
        
           
        
            

       
    </div>

    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

    
</asp:Content>
