<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="RecipeShow.aspx.cs" Inherits="Webforms.WebForm8" %>

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
        
            <asp:TextBox ID="CommentTxt" runat="server" TextMode="SingleLine" placeholder="Comente Aqui!" Rows="3" Style="padding-right: 500px;"></asp:TextBox>
            <br />

            <button class="btn btn-success btn-sm mt-2" onclick="addCommentBtn_Click">Adicionar Comentario</button>
            <asp:Button Id="btnAddFavList" runat="server" class="btn btn-warning btn-sm mt-2 ml-2" onclick="addToFavListBtn_Click" Text="Adicionar aos favoritos"></asp:Button>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
    </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
