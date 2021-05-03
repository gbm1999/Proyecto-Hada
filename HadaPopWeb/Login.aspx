<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HadaPopWeb.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="Login.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="central">
                <div class="lateral-div-der">
                    <div class="lateral-izq-texto">
                        <label>
                            ¿Todavía no perteneces a nuestra gran familia? 
                        <br />
                        <br />
                        ¡¡Puedes empezar a ser uno de nosotros ya mismo!!
                        </label>

                        
                            
                        <asp:Button id="register"
                           Text="Register"
                           class="boton-register"
                           CommandName="Submit"
                           OnClick ="register_Click"
                           runat="server"/>
                        
                    </div>

                </div>

                <div class="lateral-div-izq">
                    <div class="Welcome">
                        Welcome
                    </div>
                    <div class="logo">
                        <img src="images/logo_small.png" />

                    </div>

                    <div class="div-parametros">
                        <div class="div-parametro">
                            <div class="texto">
                               Email
                            </div>
                              <asp:TextBox ID="email" runat="server" name="email" class="input"/>
                        </div>

                        <div class="div-parametro">
                            <div class="texto">
                               Password
                            </div>
                              <asp:TextBox ID="password" runat="server" name="password" class="input"/>


                        </div>

                       

                    </div>

                    

                    <asp:Button id="login"
                           Text="Login"
                           class="boton-login"
                           CommandName="Submit"
                           OnClick="register_Click"
                           runat="server" />

                </div>

            </div>

        </div>
    </form>
</body>
</html>
