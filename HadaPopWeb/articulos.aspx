<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="articulos.aspx.cs" Inherits="HadaPopWeb.articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="estilos/categoria-articulos.css" />
    <div class="centro">
        <div class="titulo">
            ARTICULOS
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem>Select</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="nombreArt" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" onClick="BtnBuscar_Click"/>

        </div>

        <div class="tabla">
            <div class="Columna1">
    <asp:ImageButton ID="ImageButton0" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle0_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton>
                <br>
            <asp:Label ID="Label0"
           runat="server">
            </asp:Label><br><br>
    <asp:ImageButton ID="ImageButton1" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle1_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label1"
           runat="server">
            </asp:Label><br><br>
    <asp:ImageButton ID="ImageButton2" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle2_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label2"
           runat="server">
            </asp:Label><br><br>
            </div><div class="RestoColumnas">
            <asp:ImageButton ID="ImageButton3" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle3_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label3"
           runat="server">
            </asp:Label><br><br>
           <asp:ImageButton ID="ImageButton4" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle4_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label4"
           runat="server">
            </asp:Label><br><br>
                <asp:ImageButton ID="ImageButton5" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle5_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label5"
           runat="server">
            </asp:Label><br><br>
            </div><div class="RestoColumnas"> 
                <asp:ImageButton ID="ImageButton6" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle6_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label6"
           runat="server">
            </asp:Label><br><br>
                    <asp:ImageButton ID="ImageButton7" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle7_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label7"
           runat="server">
            </asp:Label><br><br>
                    <asp:ImageButton ID="ImageButton8" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle8_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label8"
           runat="server">
            </asp:Label><br><br>
            </div><div class="RestoColumnas"> 
                <asp:ImageButton ID="ImageButton9" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle9_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label9"
           runat="server">
            </asp:Label><br><br>
                    <asp:ImageButton ID="ImageButton10" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle10_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label10"
           runat="server">
            </asp:Label><br><br>
                    <asp:ImageButton ID="ImageButton11" CssClass="img-circle img img-rounded" runat="server" Height="53px" Width="108px"  OnClick="imgArticle11_Click" ImageUrl="~/images/no-foto.jpg"></asp:ImageButton> <br>
            <asp:Label ID="Label11"
           runat="server">
            </asp:Label><br><br>
            </div>
            <div style="width:300px; float:left;" >
            <asp:Button ID="PrevButton" Text="Anterior" runat="server"  OnClick="Prev_Click" Width="70px"></asp:Button>
            <asp:Button ID="NextButton" Text="Siguiente" runat="server" OnClick="Next_Click" Width="70px"></asp:Button>
            </div>
        </div>
    </div><div class="plus">
        <a href="AddArticle.aspx" rel="create">
        <img src="images/add.png" /> </a></div></asp:Content>