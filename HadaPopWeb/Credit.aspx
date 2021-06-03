<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Credit.aspx.cs" Inherits="HadaPopWeb.Credit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2"  ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <link rel="stylesheet" href="estilos/Credit.css" />
    <div class="body">
        <div class ="contentbody">
            <div class ="Balance">
                <div class="DineroBalance">
                    <label class ="Title">Balance Total:</label>
                    <br />
                    <asp:Label id = "Balance" runat ="server" class="Title"> 00.00€</asp:Label>

                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                    <ajaxToolkit:ModalPopupExtender ID="PopupNoLogin" runat="server" Enabled="true" TargetControlID="Controltarget" PopupControlID="PanelPopUpNoLogin" BackgroundCssClass="fondoPopup"></ajaxToolkit:ModalPopupExtender>
                   
                    <asp:Panel ID="PanelPopUpNoLogin" runat="server" stile="display: none;background-color: white;width: auto;height: auto">
                        
                        <div class="modal-header">
                          <h5 class="modal-title" id="PopupTitleNoLogin">Error, no se puede operar de ninguna forma sin iniciar sesion.</h5>
                        </div>
                        <div class="modal-body">
                            Por favor inicie sesion para poder acceder a esta parte.
                        </div>
                        <div class="modal-footer">
                          <asp:Button class="btn PopupAceptar" runat="server" Text="Login" OnClick="PopUpLogin"></asp:Button>
                        </div>
                   
                    </asp:Panel>
                    
                </div>
                <Label ID="ErrorTransaccione" runat="server" Class="ErrorTransaciones" ForeColor="red">Invisible</Label>
                <label ID="ErrorTarjeta"  runat="server" Class="ErrorTarjetas" ForeColor="red">Invisible</label>
                <asp:Label ID="Controltarget" runat="server" Text=""></asp:Label>

            </div>
            <div class ="TransyCuentas">
                <div class="Transacciones">
                    <label class ="Title2"> Historial de Transacciones: </label>
                    <asp:ListBox ID="Historial" runat="server" Class="Historial" height="70%" width="100%"></asp:ListBox>
                </div>
                <div class ="divCuentas">
                    <label class=" Title"> Cuentas / Tarjetas Asociadas: </label>
                    <div class ="Cuentas">
                        <div class ="Cuenta">
                            <asp:Label ID="Nombre_Usuario" runat="server" Text=""></asp:Label>
                            <div class="separador"></div>
                            <div class ="InfoCuentas">
                                 <label class="labels">Nº Tarjeta: </label>
                                <asp:TextBox ID="TBTarjeta" runat="server" Class="textboxes">
                                </asp:TextBox>
                            </div>
                            <div class="separador"></div>
                            <div class ="InfoCuentas">
                                 <label class="labels">Contraseña: </label>
                                 <asp:TextBox ID="Contraseña" runat="server" TextMode="Password" Class="textboxes"></asp:TextBox>

                            </div>
                            <div class="separador"></div>
                            <div class ="InfoCuentas">
                                 <label class="labels">Dinero: </label>
                                 <asp:TextBox ID="TBDinero" runat="server" Class="textboxes"></asp:TextBox>

                            </div>
                            <div class ="divBotonesCuentas">
                                <asp:Button class="BotonesCuentas" ID="EditarC1" runat="server" Text="Añadir" OnClick="Añadir" />
                                <asp:Button class="BotonesCuentas" ID="EditarC2" runat="server" Text="Eliminar" OnClick="Eliminar" />
                                <asp:Button class="BotonesCuentas" ID="Depositar" runat="server" Text="Depositar" OnClick="Depositar_dinero" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
