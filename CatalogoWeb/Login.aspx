<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CatalogoWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Login.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="row justify-content-center">
                <div class="col-6 login-container">
                    <h3>Iniciar Sesion</h3>
                    <div class="mb-3 w-50">
                        <label for="txtEmail" class="form-label">Email</label>
                        <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" ID="txtEmail" />
                    </div>
                    <div class="mb-3 w-50">
                        <label for="txtContraseña" class="form-label">Contraseña</label>
                        <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" ID="txtContraseña" />
                    </div>
                    <div class="mb-3 btn-container">
                        <asp:Button Text="Inicar Sesion" CssClass="btn btn-primary btn-login" runat="server" ID="btnInicarSesion" OnClick="btnInicarSesion_Click" />
                    </div>
                </div>
    </section>
</asp:Content>
