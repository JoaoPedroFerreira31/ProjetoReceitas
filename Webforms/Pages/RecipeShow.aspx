<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RecipeShow.aspx.cs" Inherits="Webforms.WebForm8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="jumbotron">
        <h1 class="display-4">Receitas de <%: recipe.Name  %></h1>
        <p class="lead">A dificuldade desta receita é <%: recipe.Difficulty %></p>
    </div>

    <h1>Preparação</h1>
    <p><%: recipe.Description %></p>


    <div>
        <asp:TextBox ID="CommentTxt" runat="server" TextMode="SingleLine" placeholder="Comente Aqui!" Rows="3" Style="padding-right: 500px;"></asp:TextBox>
        <br />

        <a class="btn btn-success btn-sm mt-2">Adicionar Comentario</a>
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
