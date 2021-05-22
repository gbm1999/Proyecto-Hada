<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="404Error.aspx.cs" Inherits="HadaPopWeb._404Error" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="404Error.css" />
    <div class="body">
       
        <div class = "imgbutt">
            <asp:Image ID="Image1" CssClass="imglogo" runat="server" ImageUrl="~/images/RobotError.png"/>
            <br />
            <div class="text">
                <h2>
                Oh No! Esta página no existe :(
             </h2>
            <p> Pero siempre puedes volver y mirar otros productos :D </p>
            </div>
            <asp:Button ID="Button1" CssClass="button" runat="server" Text="Ver Productos" />
        </div>
    </div>
        
</asp:Content>
