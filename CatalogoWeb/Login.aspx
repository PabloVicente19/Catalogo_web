<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CatalogoWeb.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="row justify-content-center">
        <div class="col-6 d-flex justify-content-center">
            <div class="mb-3 w-50">
                <label for="exampleFormControlInput1" class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" />
            </div>
            <div class="mb-3 w-50">
                <label for="exampleFormControlInput1" class="form-label">Nombre</label>
                <asp:TextBox runat="server" CssClass="form-control" TextMode="SingleLine" />
            </div>
        </div>
    </section>
</asp:Content>
