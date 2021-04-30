<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Credit.aspx.cs" Inherits="HadaPopWeb.Credit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="Credit.css" />
    <div class="body">
        <div class ="contentbody">
            <div class ="Balance">
                <div class="DineroBalance">
                    <label class ="Title">Balance Total:</label>
                    <br />
                    &nbsp&nbsp
                    <label id = Balance class="Title"> 00.00€</label>
                </div>
                <div class ="divBotones">
                    <asp:Button class="Botones" ID="Depositar" runat="server" Text="Depositar" />
                    &nbsp
                    <asp:Button class="Botones" ID="Retirar" runat="server" Text="Retirar" />
                </div>
            </div>
            <div class ="TransyCuentas">
                <div class="Transacciones">
                    <label class ="Title2"> Historial de Transacciones: </label>
                </div>
                <div class ="divCuentas">
                    <label class=" Title"> Cuentas / Tarjetas Asociadas: </label>
                    <div class ="Cuentas">
                        <div class ="Cuenta">
                            <label>Cuenta1</label>
                            <div class="separador"></div>
                            <div class ="InfoCuentas">
                                 <label class="labels">Nombre: </label>
                                 <input ID="NombreC1" type="text" runat="server" class="textboxes" />
                            </div>
                            <div class="separador"></div>
                            <div class ="InfoCuentas">
                                 <label class="labels">Nº Cuenta: </label>
                                 <input ID="Cuenta1" type="text" runat="server" class="textboxes" />
                            </div>
                            <div class ="separador"></div>
                            <div class ="divBotonesCuentas">
                                <asp:Button class="BotonesCuentas" ID="EditarC1" runat="server" Text="Editar" />
                                &nbsp
                                <asp:Button class="BotonesCuentas" ID="EditarC2" runat="server" Text="Eliminar" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
