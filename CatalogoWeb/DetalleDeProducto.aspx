<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="DetalleDeProducto.aspx.cs" Inherits="CatalogoWeb.DetalleDeProducto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/DetalleDeProducto.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="row justify-content-center">
        <div class="col-6 ">
            <section class="d-flex justify-content-center align-items-center">
                <asp:Repeater runat="server" ID="repetidor">
                    <ItemTemplate>
                        <div class="card" >
                            <div class="row p-3 g-0">
                                <div class="col-md-4">
                                    <img src="<%#Eval("ImagenUrl") %>" class="img-fluid rounded-start" alt="<%#Eval("Nombre") %>">
                                </div>
                                <div class="col-md-8 ">
                                    <div class="card-body card-container">
                                        <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                        <p class="card-text"><%#Eval("Descripcion") %></p>
                                        <div>
                                            <asp:Button Text="Agregar a Favoritos" runat="server" CssClass="btn btn-primary" />
                                            <asp:Button Text="Volver" CssClass="btn btn-primary" runat="server" ID="BtnVolverAlHome" OnClick="BtnVolverAlHome_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </section>
        </div>
    </section>
</asp:Content>
