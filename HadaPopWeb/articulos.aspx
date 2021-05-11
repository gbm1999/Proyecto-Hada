<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="articulos.aspx.cs" Inherits="HadaPopWeb.articulos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="categoria-articulos.css" />
    <div class="centro">
        <div class="titulo">
            ARTICULOS
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox ID="nombreArt" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" onClick="BtnBuscar_Click"/>

        </div>

        <div class="tabla">
            <div style="width:106px; float:left;">
            <img id="Image1" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/>
                <br>
            <asp:Label ID="Label0"
           Text="Article1:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <img id="Img1" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label1"
           Text="Article2:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button2" runat="server" Text="Button" OnClick="Button2_Click" />
                <img id="Img2" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label2"
           Text="Article3:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button3" runat="server" Text="Button" OnClick="Button3_Click" />
            </div><div style="width:106px; float:left; margin-left: 56px;"><img id="Img3" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label3"
           Text="Article4:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button4" runat="server" Text="Button" OnClick="Button4_Click" />
                <img id="Img4" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label4"
           Text="Article5:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button5" runat="server" Text="Button" OnClick="Button5_Click" />
                <img id="Img5" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label5"
           Text="Article6:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button6" runat="server" Text="Button" OnClick="Button6_Click"/>
            </div><div style="width:106px; float:left; margin-left: 56px;"><img id="Img6" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label6"
           Text="Article7:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button7" runat="server" Text="Button" OnClick="Button7_Click" />
                <img id="Img7" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label7"
           Text="Article8:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button8" runat="server" Text="Button" OnClick="Button8_Click" />
                <img id="Img8" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label8"
           Text="Article9:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button9" runat="server" Text="Button" OnClick="Button9_Click" />
            </div><div style="width:106px; float:left; margin-left: 56px;"><img id="Img9" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label9"
           Text="Article10:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button10" runat="server" Text="Button" OnClick="Button10_Click" />
                <img id="Img10" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label10"
           Text="Article11:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button11" runat="server" Text="Button" OnClick="Button11_Click" />
                <img id="Img11" alt="" src="" runat="server" style="height: 53px; width: 108px; margin-left: 0px"/> <br>
            <asp:Label ID="Label11"
           Text="Article12:"
           runat="server">
            </asp:Label><br>
                <asp:Button ID="Button12" runat="server" Text="Button" OnClick="Button12_Click" />
            </div></div></div><div class="plus">
        <a href="AddArticle.aspx" rel="create">
        <img src="images/add.png" /> </a></div></asp:Content>