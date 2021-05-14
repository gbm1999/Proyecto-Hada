<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="AddCategoria.aspx.cs" Inherits="HadaPopWeb.AddCategoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <link rel="stylesheet" href="AddCategoria.css" />
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
                            <asp:TextBox runat="server"  class="AddDescription text-cuadro" name="description" id="description"> </asp:TextBox>
                        </div>
                </div>
                 <div class="esp-boton">
                         <asp:Button id="create"
                           Text="Create"
                           OnClick="boton_crear"
                           class="boton"
                           runat="server"/>
                    </div>
           </div>
              
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
              
       
           
</asp:Content>
