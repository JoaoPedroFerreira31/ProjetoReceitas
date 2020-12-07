<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Webforms.WebForm1" %>

<%@ Import Namespace="PRE.Model.Model" %>


<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <header class="jumbotron" id="HeaderDefaultPage">
		<div class="container">
			<h1>Bem-Vindo ao Receitas Estrelares</h1>
			<p>Veja as nossas receitas!</p>	
			<a href="#" class="btn btn-info btn-sm" >Adicionar Receitas</a>
		</div>
	</header>

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
                        <div class="card-header"><%: recipe.Category %></div>
                            <div class="card-body">
                                <h5 class="card-title"><%: recipe.Name %></h5>
                                <p class="card-text"><%: recipe.Description %></p>
                                <a href="~/Pages/RecipeShow.aspx" class="btn btn-sm-primary" runat="server" onclick="recipeShowBtn">Ver mais</a>
                            </div>
                    </div>
            </div>
            <% } %>
            

         </div>
    </section>



</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>


