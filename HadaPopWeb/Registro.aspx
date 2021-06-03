<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Registro.aspx.cs" Inherits="HadaPopWeb.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Register</title>
    <link rel="stylesheet" href="estilos/Registro.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div class="center-container">
            <div class="left-container">
                <div class="texto-logo">
                    Welcome
                    <br />
                    to<br />
                    HadaPop</div>

                <div class="texto-min">
                    Bienvenido a la página lider en compra y venta de productos online. Unete a la familia.</div>

                <div class="logo">
                     
                     <img src="images/logo_small.png" />
                </div>

            </div>

            <div class="rigth-container">
                <div class="campos-left">
                    <div class="campo">
                        <div class="texto">
                            Nombre: <br />
                            <label id="errorname" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                                
                                <asp:TextBox ID="name" runat="server" name="name" />
                           
                        </div>                        
                         

                    </div>

                    <div class="campo">
                        <div class="texto">
                            NIF:<br />
                            <label id="errornif" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                                <asp:TextBox ID="NIF" runat="server" name="nif" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Contraseña:<br />
                            <label id="errorpass" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                            <asp:TextBox ID="password" type="password" runat="server" name="password" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Edad:<br />
                            <label id="errorage" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                                <asp:TextBox ID="age" runat="server" name="age" />
                        </div>
                    </div>

                </div>

                
                <div class="campos-right">
                    <div class="campo">
                        <div class="texto">
                            Administrador:<br />
                            <label id="erroradmin" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                                <asp:TextBox ID="Admin" runat="server" type="password" name="age" />
                                <asp:CheckBox id="Admincheck" runat="server" OnCheckedChanged="Admincheck_CheckedChanged" AutoPostBack="true"/>
                        </div>

                    </div>

                    <div class="campo">
                        <div class="texto">
                            Teléfono:<br />
                            <label id="errortlf" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                            <asp:TextBox ID="phone" runat="server" name="phone" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Confirmar contraseña:<br />
                            <label id="errorcpass" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                            <asp:TextBox ID="password2" runat="server" type="password" name="password2" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Email:<br />
                            <label id="erroremail" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                            <asp:TextBox ID="email" runat="server" name="email" />
                        </div>
                    </div>

                </div> 

                <div class="register">
                   
                     
                     <asp:Button id="register"
                           Text="Register"
                           class="boton"
                           OnClick="register_Click"
                           
                           runat="server"/>
                         
                         

                </div>
            </div>
        </div>
</asp:Content>

