<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site1.Master" CodeBehind="Login.aspx.cs" Inherits="HadaPopWeb.WebForm1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link rel="stylesheet" href="estilos/Login.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                           OnClick ="Register_Click"
                           runat="server"/>
                        
                        
                    </div>

                </div>

                <div class="lateral-div-izq">
                    <div class="Welcome">
                        Welcome
                    </div>
                    <div class="logo">
                        <img src="images/logo-negro.png" />
                    </div>

                    <div class="div-parametros">
                        <div class="div-parametro">
                            <div class="texto">
                               Email
                            </div>
                           <div class="separadorvertical"></div>
                            <div class="errorbox">
                                <label id="errorname" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                            </div>
                             

                            <asp:TextBox ID="email" runat="server" TextMode="Email" name="email" class="input"/>
                        </div>
                        <div class="separadorvertical"></div>
                        <div class="div-parametro">
                            <div class="texto">
                               Password
                            </div>
                            <div class="separadorvertical"></div>
                            <div class="errorbox">
                                <label id="errorpass" runat ="server" class="errortext">Esto no deberías poder verlo :(</label>
                            </div>

                              <asp:TextBox ID="password" runat="server" TextMode="Password" name="password" class="input"/>


                        </div>

                       

                    </div>

                    

                    <asp:Button id="login"
                           Text="Login"
                           class="boton-login"
                           CommandName="Submit"
                           OnClick="Login_Click"
                           runat="server" />

                </div>

            </div>

        </div>
</asp:Content>
