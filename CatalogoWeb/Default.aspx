<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <section class="filter-content">
            <h2>Productos</h2>
            <asp:DropDownList runat="server">
                <asp:ListItem Text="Precio mas Bajo" />
                <asp:ListItem Text="Precio mas Alto" />
            </asp:DropDownList>
        </section>
        <section class="card-group">
            <asp:Repeater runat="server" ID="repeat">
                <ItemTemplate>
                    <div class="card w-100">
                        <img class="card-img-top" src="<%#Eval("ImagenUrl") %>" alt="Alternate Text" />
                        <div class="card-body">
                            <h3 class="card-title"><%#Eval("Nombre") %></h3>
                            <h4 class="card-text"><%#Eval("Descripcion") %></h4>
                            <h4 class="text-body-secondary"><%#Eval("Precio") %></h4>
                            <div class="d-flex">
                                <asp:Button Text="Agregar" runat="server" CssClass="btn btn-primary" />
                                <asp:Button Text="Ver Detalle" runat="server" CssClass="btn btn-primary" />
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>
    </div>
</asp:Content>
