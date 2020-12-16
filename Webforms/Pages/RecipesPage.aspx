<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RecipesPage.aspx.cs" Inherits="Webforms.WebForm2" %>

<%@ Import Namespace="PRE.Model.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="jumbotron">
        <h1 class="display-4">Receitas</h1>
        <p class="lead">Veja as melhores e mais saborosas receitas</p>
        <asp:TextBox ID="SearchRecipeTxt" runat="server" placeholder="Nome da Receita" Style="padding-right: 200px;"></asp:TextBox>
        <asp:Button ID="SearchRecipeBtn" CssClass="btn btn-primary btn-sm" runat="server" Text="Procurar" OnClick="SearchRecipeBtn_Click" />
    </div>

    <section class="mt-5 mb-5">
        <div class="row mt-3">

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-md-4 mt-3">
                        <div class="card">
                            <%--<h1><%# DataBinder.Eval(Container.DataItem, "IdRecipe") %></h1>--%>
                            <div class="card-header"><%# DataBinder.Eval(Container.DataItem, "Category") %></div>
                            <div class="card-body">
                                <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem, "Name") %></h5>
                                <p class="card-text"><%# DataBinder.Eval(Container.DataItem, "Description") %></p>
                                <%-- QueryString name = ItemID --%>
                                <a href='<%# "RecipeShow.aspx?ItemID=" + Eval("IdRecipe").ToString() %>' id="ShowRecipeBtn" runat="server" class="btn btn-info btn-sm">Ver Mais</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </section>

    <%--<% foreach (Recipe recipe in recipes) %> 
            <% { %>
            <div class="col-md-4">
                    <div class="card">
                        <div class="card-header"><%: recipe.Category %></div>
                            <div class="card-body">
                                <h5 class="card-title"><%: recipe.Name %></h5>
                                <p class="card-text"><%: recipe.Description %></p>
                                <asp:Button ID="ShowRecipeBtn" CssClass="btn btn-primary btn-sm"  runat="server" Text="Ver Mais" />
                            </div>
                    </div>
            </div>
            <% } %>--%>






</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
