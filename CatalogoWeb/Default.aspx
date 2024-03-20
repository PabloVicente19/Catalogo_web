<%@ Page Title="" Language="C#" MasterPageFile="~/MiMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CatalogoWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <section class="cards-container">
            <asp:Repeater runat="server" ID="repeat">
                <ItemTemplate>
                    <div class="card">
                        <img class="card-img" src="<%#Eval("ImagenUrl") %>" alt="Alternate Text" />
                        <h3 class="card-title"><%#Eval("Nombre") %></h3>
                        <h4 class="card-description"><%#Eval("Descripcion") %></h4>
                        <h4 class="card-price"><%#Eval("Precio") %></h4>
                        <div class="card-btn-content">
                            <asp:Button Text="Agregar" runat="server" CssClass="card-btn" />
                            <asp:Button Text="Ver Detalle" runat="server" CssClass="card-btn"/>
                        </div>

                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </section>
</asp:Content>
