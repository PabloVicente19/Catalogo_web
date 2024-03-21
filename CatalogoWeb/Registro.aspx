﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Registro.aspx.cs" Inherits="CatalogoWeb.Registro" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Registro.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="mb-5 register-container ">
        <h1 class="pb-5 text-center">Registrate</h1>
        <section class="col-6 mx-auto border rounded p-4">
            <div class="d-flex gap-4">
                <div class="mb-3 w-50">
                    <label for="exampleFormControlInput1" class="form-label">Nombre</label>
                    <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" />
                </div>
                <div class="mb-3 w-50">
                    <label for="exampleFormControlInput1" class="form-label">Apellido</label>
                    <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" />
                </div>
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Email</label>
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Email" />
            </div>
            <div class="mb-3">
                <label for="exampleFormControlInput1" class="form-label">Contraseña</label>
                <asp:TextBox runat="server" CssClass="form-control" TextMode="Password" />
            </div>
            <div class="col-6 mx-auto">
                <div class="d-flex justify-content-center">
                    <asp:Button Text="Crear Cuenta" runat="server" CssClass="btn btn-primary" />
                </div>
            </div>
        </section>
    </section>
</asp:Content>
