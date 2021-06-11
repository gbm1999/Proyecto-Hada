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
                     
                     <img src="images/logo-blanco.png" />
                </div>

            </div>

            <div class="rigth-container">
                <div class="campos-left">
                    <div class="campo">
                        <div class="texto">
                            Nombre: <br />
                            
                            <asp:Label ID="errorname" runat="server"  class="errortext" Text=""/>
                                
                                <asp:TextBox ID="name" CssClass="input-estilo" runat="server"/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="name"></asp:RequiredFieldValidator>
                        </div>                        
                    </div>

                    <div class="campo">
                        <div class="texto">
                            NIF:<br />
                            <asp:Label ID="errornif" runat="server"  class="errortext" Text=""/>

                                <asp:TextBox ID="NIF" CssClass="input-estilo" runat="server"/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="NIF"></asp:RequiredFieldValidator>
                                
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Contraseña:<br />
                            <asp:Label ID="errorpass" runat="server"  class="errortext" Text=""/>
                            
                            <asp:TextBox ID="password" CssClass="input-estilo" type="password" runat="server" ValidateRequestMode="Enabled"/>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="password"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Edad:<br />
                            <asp:Label ID="errorage" runat="server"  class="errortext" Text=""/>
                                <asp:TextBox ID="age" CssClass="input-estilo" runat="server"/>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="age"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                </div>

                
                <div class="campos-right">
                    <div class="campo">
                        <div class="texto">
                            Administrador:<br />
                            <asp:Label ID="erroradmin" runat="server"  class="errortext" Text=""/>
                                <asp:TextBox ID="Admin" runat="server" CssClass="input-estilo" type="password"/>
                                <asp:CheckBox id="Admincheck" runat="server"  OnCheckedChanged="Admincheck_CheckedChanged" AutoPostBack="true"/>
                        </div>

                    </div>

                    <div class="campo">
                        <div class="texto">
                            Teléfono:<br />
                            <asp:Label ID="errortlf" runat="server"  class="errortext" Text=""/>
                            <asp:TextBox ID="phone" CssClass="input-estilo" runat="server"/>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="phone"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Repetir contraseña:<br />
                            <asp:Label ID="errorcpass" runat="server"  class="errortext" Text=""/>
                            <asp:TextBox ID="password2" CssClass="input-estilo" runat="server" type="password"/>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="password2"></asp:RequiredFieldValidator>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Email:<br />
                            <asp:Label ID="erroremail" runat="server"  class="errortext" Text=""/>
                            <asp:TextBox ID="email" CssClass="input-estilo" runat="server"/>
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ErrorMessage="Campo obligatorio*" ControlToValidate="email"></asp:RequiredFieldValidator>
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

