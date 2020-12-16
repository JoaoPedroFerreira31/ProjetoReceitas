<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RecipeShow.aspx.cs" Inherits="Webforms.WebForm8" %>
<%@ Import Namespace="PRE.Model.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="jumbotron">
        <h1 class="display-4">Receitas de <%: recipe.Name  %></h1>
        <p class="lead">A dificuldade desta receita é <%: recipe.Difficulty %></p>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>

    <h1>Preparação</h1>
    <p><%: recipe.Description %></p>


    <div class="row ml-1">
        <div>
            <% foreach (Comment comment in comments) %>
            <% { %>
            <div class="my-2">
                <div class="toast-body" style=""">
                    <%: comment.CommentText %>
                </div>
                <div class="toast-header">
                    <small><%: comment.Date %></small>
                </div>
            </div>
            <% } %>

            <asp:TextBox ID="CommentTxt" runat="server" TextMode="SingleLine" placeholder="Comente Aqui!" Rows="3" Style="padding-right: 500px;"></asp:TextBox>
            <br />

            <asp:Button ID="btnAddComment" runat="server" class="btn btn-success btn-sm mt-2" OnClick="addCommentBtn_Click" Text="Adicionar Comentario"></asp:Button>
            <asp:Button ID="btnAddFavList" runat="server" class="btn btn-warning btn-sm mt-2 ml-2" OnClick="addToFavListBtn_Click" Text="Adicionar aos favoritos"></asp:Button>
        </div>
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
