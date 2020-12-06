<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webforms.WebForm1" %>

<%@ Import Namespace="PRE.Model.Model" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="jumbotron">
        <h1 class="display-4">Hello, world!</h1>
        <p class="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
        <hr class="my-4">
        <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
        <a class="btn btn-primary btn-lg" href="~/Accounts/Login.aspx" runat="server" role="button">Login</a>
        <a class="btn btn-primary btn-lg" href="~/Accounts/Register.aspx" runat="server" role="button">Register</a>
    </div>

    <%-- //Chamar recipes (Name, etc..) ver source --%>
    <%--<div id="div1">
        <% foreach (Recipe recipe in recipes)
            { %>
        <div>
            <%: recipe.Name %>
        </div>
        <% } //foreach %>
    </div>--%>


    <section id="Receitas" class="mt-5 mb-5">
        <div class="row">

            <% foreach (Recipe recipe in recipes) %> 
            <% { %>
            <div class="col-md-4">
                    <div class="card">
                        <div class="card-header"></div>
                            <div class="card-body">
                                <h5 class="card-title"><%: recipe.Name %></h5>
                                <p class="card-text"><%: recipe.Description %></p>
                                <a href="~/Pages/RecipePage.aspx" class="btn btn-primary" onclick="recipeShowBtn">Ver mais</a>
                            </div>
                    </div>
            </div>
            <% } %>
            

         </div>
    </section>



</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>


