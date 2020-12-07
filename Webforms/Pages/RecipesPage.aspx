<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RecipesPage.aspx.cs" Inherits="Webforms.WebForm2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    
    <div class="jumbotron">
        <h1 class="display-4">Receitas</h1>
        <p class="lead">Veja as melhores e mais saborosas receitas</p>
        <asp:TextBox ID="SearchRecipe" runat="server" placeholder="Nome Receita" style="padding-right: 200px;"></asp:TextBox>
        <button class="btn btn-secondary my-2 mx-2" type="submit">Pesquisar</button>
        
    </div>
    
        
            
    


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
