<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Credit.aspx.cs" Inherits="HadaPopWeb.Credit" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
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
                    <asp:Label id = "Balance" runat ="server" class="Title"> 00.00€</asp:Label>

                    <ajaxToolkit:ModalPopupExtender ID="PopupNoLogin" runat="server" Enabled="true" TargetControlID="Balance" PopupControlID="PanelPopUpNoLogin" BackgroundCssClass="fondoPopup"></ajaxToolkit:ModalPopupExtender>
                   
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
                <asp:Label ID="ErrorTransacciones" runat="server"></asp:Label>
                <div class ="divBotones">
                    <asp:Button class="Botones" ID="Depositar" runat="server" Text="Depositar" />

                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    
                    <ajaxToolkit:ModalPopupExtender ID="PopupDepositar" runat="server" Enabled="true" TargetControlID="Depositar" PopupControlID="PanelPopUpDepositar" BackgroundCssClass="fondoPopup"></ajaxToolkit:ModalPopupExtender>
                   
                    <asp:Panel ID="PanelPopUpDepositar" runat="server" stile="display: none;background-color: white;width: auto;height: auto">
                        
                        <div class="modal-header">
                          <h5 class="modal-title" id="PopupTitleDepositar">Ingrese el importe que quiera ingresar en su cuenta</h5>
                            <asp:Button type="button" class="close" data-dismiss="modal" runat="server" Text="X">
                            </asp:Button>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="DepositarLabel" runat="server" Text="Ingrese la cantidad"></asp:Label>
                            <asp:TextBox ID="DepositarTextBox" runat="server"></asp:TextBox>
                        </div>
                        <div class="modal-footer">
                          <asp:Button class="btn PopupCerrar" data-dismiss="modal" runat="server" Text="Close"></asp:Button>
                          <asp:Button class="btn PopupAceptar" runat="server" Text="Aceptar" OnClick="PopUpAceptarDepositar"></asp:Button>
                        </div>
                   
                    </asp:Panel>
                    
                    <asp:Button class="Botones" ID="Retirar" runat="server" Text="Retirar" />

                    <ajaxToolkit:ModalPopupExtender ID="PopupRetirar" runat="server" Enabled="true" TargetControlID="Retirar" PopupControlID="PanelPopUpRetirar" BackgroundCssClass="fondoPopup"></ajaxToolkit:ModalPopupExtender>
                   
                    <asp:Panel ID="PanelPopUpRetirar" runat="server" stile="display: none;background-color: white;width: auto;height: auto">
                        
                        <div class="modal-header">
                          <h5 class="modal-title" id="PopupTitleRetirar">Ingrese el importe que quiera retirar en su cuenta</h5>
                            <asp:Button type="button" class="close" data-dismiss="modal" runat="server" Text="X">
                            </asp:Button>
                        </div>
                        <div class="modal-body">
                            <asp:Label ID="RetirarLabel" runat="server" Text="Ingrese la cantidad"></asp:Label>
                            <asp:TextBox ID="RetirarTextBox" runat="server"></asp:TextBox>
                        </div>
                        <div class="modal-footer">
                          <asp:Button class="btn PopupCerrar" data-dismiss="modal" runat="server" Text="Close"></asp:Button>
                          <asp:Button class="btn PopupAceptar" runat="server" Text="Aceptar" OnClick="PopUpAceptarRetirar"></asp:Button>
                        </div>
                   
                    </asp:Panel>
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
                                 <asp:TextBox ID="TBNombre" runat="server" CssClass="textboxes"></asp:TextBox>
                            </div>
                            <div class="separador"></div>
                            <div class ="InfoCuentas">
                                 <label class="labels">Nº Cuenta: </label>
                                 <asp:TextBox ID="Cuenta1" runat="server" CssClass="textboxes"></asp:TextBox>

                            </div>
                            <div class ="separador"></div>
                            <div class ="divBotonesCuentas">
                                <asp:Button class="BotonesCuentas" ID="EditarC1" runat="server" Text="Editar" />
                                <asp:Button class="BotonesCuentas" ID="EditarC2" runat="server" Text="Eliminar" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
