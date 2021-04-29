<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="HadaPopWeb.Profile" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="Profile.css" />

    <div class ="CuadroExt">
            <div class="divimgdatos">
                <div class = "imgperfbox">
                    <div class="img">
                        <img src="images/sinperfil.png"/>
                
                        &nbsp
                        <label id ="NumVentas" runat ="server">0</label>
                        &nbsp
                        <label>Ventas</label>
                        &nbsp&nbsp
                        <label id ="NumCompras" runat ="server">0</label>
                        &nbsp
                        <label>Compras</label>
                    </div>
                </div>
                <!-- COMIENZO DATOS USU -->
                <div class="datosusu" runat ="server">

                    <div class = "labtext"> <!-- Nombre -->
                        <label class="labels">Nombre: </label>
                        <input ID="TBNombre" type="text" runat="server" class="textboxes" />
                    </div>

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Email -->
                        <label class="labels">Email: </label>
                        <input id="TBEmail" type="text" runat="server" class="textboxes" />
                    </div>  

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- NIF -->
                        <label class="labels">NIF: </label>
                        <input id="TBNif" type="text" runat="server" class="textboxes" />
                    </div> 

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Edad -->
                        <label class="labels">Edad: </label>
                        <input id="TBEdad" runat="server" type="text" class="textboxes" />
                    </div> 

                    <div class="separadorvert"></div>

                     <div class = "labtext"> <!-- Tlfno -->
                        <label class="labels">Teléfono: </label>
                        <input id="TBTelefono" runat="server" type="text" class="textboxes" />
                    </div> 
                    <!-- FIN DATOSUSU -->
                    <div class="separadorvert"></div>
            
                    <asp:Button ID="Butt_Edit" runat="server" class= "butteditar" Text="Editar" OnClick = "Editar" />

                    <asp:Button ID="Butt_Env" runat="server" class= "butteditar" Text="Enviar" OnClick ="Enviar"/>

                </div>
        </div>
            
            <div class ="Articulos">
                
            </div>
    </div>
</asp:Content>
