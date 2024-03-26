<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Default.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row">
        <div class="col filter-container">
            <h2 class="title">Productos</h2>
            <div>
                <span>Ordernar Por:</span>
                <asp:DropDownList runat="server" ID="DdlFiltro">
                    <asp:ListItem Text="Menor Precio" />
                    <asp:ListItem Text="Mayor Precio" />
                </asp:DropDownList>
            </div>
        </div>
    </div>
    <div class="row mb-5">
        <div class="col">
            <div class="cards-container">
                <asp:Repeater runat="server" ID="repeater">
                    <ItemTemplate>
                        <div class="card flex-row align-content-between flex-wrap text-center" style="width: 15rem;">
                            <img src="<%#Eval("ImagenUrl") %>" class="card-img-top p-3" alt="<%#Eval("Nombre") %>">
                            <div class="card-body">
                                <h5 class="card-title"><%#Eval("Nombre") %></h5>
                                <p class="card-text"><%#Eval("Descripcion") %></p>
                                <p class="card-text">$: <%#Eval("Precio") %></p>
                                <asp:Button Text="Ver Detalle" runat="server" CssClass="btn btn-primary" ID="btnVerProducto" CommandArgument='<%#Eval("Id") %>' CommandName="verProducto" OnClick="btnVerProducto_Click" AutoPostBack="false" />
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
