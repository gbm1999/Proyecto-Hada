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
                         
                                <input type="text" class="parametro-introducido" name="name" id="name"/>
                           
                        </div>

                    </div>

                    <div class="campo">
                        <div class="texto">
                            NIF:
                                <input type="text" class="parametro-introducido" name="NIF" id="NIF"/>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Contraseña:
                                <input type="text" class="parametro-introducido" name="password" id="password"/>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Edad:
                                <input type="text" class="parametro-introducido" name="age" id="age"/>
                        </div>
                    </div>

                </div>

                
                <div class="campos-right">
                    <div class="campo">
                        <div class="texto">
                            Admin:
                            <input type="text" class="parametro-introducido" name="admin" id="admin"/>
                        </div>

                    </div>

                    <div class="campo">
                        <div class="texto">
                            Teléfono:
                            <input type="text" class="parametro-introducido" name="phone" id="phone"/>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            Confirmar contraseña:
                            <input type="text" class="parametro-introducido" name="c_password" id="c_password"/>
                        </div>
                    </div>

                    <div class="campo">
                        <div class="texto">
                            email:
                            <input type="text" class="parametro-introducido" name="email" id="email"/>
                        </div>
                    </div>

                </div> 

                <div class="register">
                    <button type="submit" class="boton">Register</button>

                </div>
            </div>
        </div>
    </form>
</body>
</html>
