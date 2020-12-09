<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="CategoryPage.aspx.cs" Inherits="Webforms.WebForm3" %>
<%@ Import Namespace="PRE.Model.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="jumbotron">
        <h1 class="display-4">Nome da Categoria (Automatico)</h1>
        <p class="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
    </div>

    <% Recipe recipe = recipeService.GetById(3); %>
    <% { %>
    <div class="col-md-4">
        <div class="card">
            <div class="card-header"><%: recipe.Category %></div>
            <div class="card-body">
                <h5 class="card-title"><%: recipe.Name %></h5>
                <p class="card-text"><%: recipe.Description %></p>
                <asp:button href="~/Pages/RecipeShow.aspx" CssClass="btn btn-sm-primary" text="Ver mais" runat="server" onclick="recipeShowBtn"></asp:button>
            </div>
        </div>
    </div>
    <% } %>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
