<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="categoria.aspx.cs" Inherits="HadaPopWeb.categoria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/categorias.css" />
    
         <div class="centro">
        <div class="titulo">
            CATEGORIAS
        </div>

        
            <div class="tabla">
            <asp:ListView ID="ListView1" runat="server"  DataSourceID="SqlDataSource1">
                
                
                
                
                <AlternatingItemTemplate>
                    <tr style="background-color: white;color: black;">
                        <td>
                            
                            <asp:linkbutton ID="NombreLabel" onClick="acceder_categoria" runat="server" Text='<%# Eval("Nombre") %>' />
                        </td>
                        <td>
                            <asp:Label ID="DescripcionLabel" runat="server" Text='<%# Eval("Descripcion") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                
                
                
                
                
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No existe ninguna categoría.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
              
          
   
                <ItemTemplate>
                    <tr style="background-color: white; color: black">
                        <td>
                           
                            <asp:linkbutton ID="NombreLabel"  runat="server"  onClick="acceder_categoria" Text='<%# Eval("Nombre") %>' />
                            


                        </td>
                        <td>
                            
                            <asp:Label ID="DescripcionLabel" runat="server" Text='<%# Eval("Descripcion") %>' />
                                
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF; position:absolute; width: 100%;  border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color:black ;color: white;">
                                        <th runat="server">Nombre</th>
                                        <th runat="server">Descripcion</th>
                                    </tr>
                                    <tr runat="server" id="itemPlaceholder">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: black;font-family: Verdana, Arial, Helvetica, sans-serif;color: white; position:absolute; width:100%; top: 80%" >
                                <asp:DataPager ID="DataPager1" runat="server">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color:black; color: #000080; font-weight: bold;">
                        <td>
                            
                            <asp:linkbutton ID="NombreLabel" runat="server" Text='<%# Eval("Nombre") %>' />
                                
                        </td>
                        <td>
                            <asp:Label ID="DescripcionLabel" runat="server" Text='<%# Eval("Descripcion") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>

            </asp:ListView>
                </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [Nombre], [Descripcion] FROM [Categoria]"></asp:SqlDataSource>

        </div>
    

       

        
            
   
    <div class="plus">
        <a href="AddCategoria.aspx" rel="create">
        <img src="images/add.png" />
            </a>
            
    </div>
   
</asp:Content>
