<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Categoriaconcrete.aspx.cs" Inherits="HadaPopWeb.Categoriaconcrete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/categoria.css" />
    <div class="centro">
        <div class="titulo">
            AÑADIR CATEGORIA
        </div>

        <div class="categoria">
                    <div class="nombre-categoria">
                        NOMBRE:
                        <asp:TextBox ID="nombre" runat="server" class="input-cat" name="nombre" />
                        <br />
                        <br />
                        DESCRIPCIÓN:
                    </div>
                    <div class="area-cat">
                            <asp:TextBox runat="server" TextMode="MultiLine" class="AddDescription text-cuadro" name="description" id="description"> </asp:TextBox>
                    </div>

                    

                    
        </div>

        <div class="modificar ">
            <asp:Button id="edit"
                           Text="Modificar"
                           OnClick="editar_categoria"
                           class="boton"
                           runat="server"/>

        </div>

        <div class="borrar">
            <asp:Button id="delete"
                           Text="Borrar"
                           OnClick="borrar_categoria"
                           class="boton"
                           runat="server"/>
            

        </div>
        
        
    </div>
    

    <asp:Label ID="Label1" CssClass="mensaje" runat="server" Text=""></asp:Label>
            
    
</asp:Content>
