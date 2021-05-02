<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="HadaPopWeb.Registro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Register</title>
    <link rel="stylesheet" href="Registro.css" />
</head>
<body>
    <form id="form1" runat="server">
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
                            Nombre:
                         
                                <asp:TextBox ID="name" runat="server" name="name" />
                           
                        </div>

                    </div>

                    <div class="campo">
                        <div class="texto">
                            NIF:
                                <asp:TextBox ID="NIF" runat="server" name="nif" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Contraseña:
                                <asp:TextBox ID="password" runat="server" name="password" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Edad:
                                <asp:TextBox ID="age" runat="server" name="age" />
                        </div>
                    </div>

                </div>

                
                <div class="campos-right">
                    <div class="campo">
                        <div class="texto">
                            Admin:
                            <asp:TextBox ID="admin" runat="server" name="admin" />
                        </div>

                    </div>

                    <div class="campo">
                        <div class="texto">
                            Teléfono:
                            <asp:TextBox ID="phone" runat="server" name="phone" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Confirmar contraseña:
                            <asp:TextBox ID="password2" runat="server" name="password2" />
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            email:
                            <asp:TextBox ID="email" runat="server" name="email" />
                        </div>
                    </div>

                </div> 

                <div class="register">
                   

                     <asp:Button id="register"
                           Text="Register"
                           class="boton"
                           CommandName="Submit"
                           
                           runat="server"/>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
