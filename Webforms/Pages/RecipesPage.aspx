<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RecipesPage.aspx.cs" Inherits="Webforms.WebForm2" %>
<%@ Import namespace="PRE.Model.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    
    <div class="jumbotron">
        <h1 class="display-4">Receitas</h1>
        <p class="lead">Veja as melhores e mais saborosas receitas</p>
        <asp:TextBox ID="SearchRecipeTxt" runat="server" placeholder="Nome da Receita" style="padding-right: 200px;"></asp:TextBox>
        <asp:Button ID="SearchRecipeBtn" CssClass="btn btn-primary" runat="server" Text="Procurar" OnClick="SearchRecipeBtn_Click" />
    </div>
    
    <section id="Receitas" class="mt-5 mb-5">
        <div class="row">

            <% foreach (Recipe recipe in recipes) %> 
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
            <% } %>
            

         </div>
    </section>

        
            
    


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
