<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AddRecipe.aspx.cs" Inherits="Webforms.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="container">
        <h1 class="my-4">Adicionar Receita</h1>
        <asp:Label ID="Label1" runat="server" Text="Label" Visible="False"></asp:Label>
        <div class="form-group">
            <label for="exampleFormControlInput1">Titulo</label>
            <asp:TextBox ID="NameTxt" runat="server" CssClass="form-control" placeholder="Nome da Receita"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Descrição</label>
            <asp:TextBox ID="DesriptionTxt" TextMode="multiLine" Columns="50" Rows="5" runat="server" CssClass="form-control p-5" placeholder="Descrição"></asp:TextBox>
        </div>

        <div class="row">

            <div class="col-4">

                <div class="form-group">
                    <label for="exampleFormControlSelect2">Dificuldade</label>
                    <asp:DropDownList ID="DifficultyDropdown" runat="server" CssClass="form-control" placeholder="Dificuldade">
                        <asp:ListItem Value="0">Muito Fácil</asp:ListItem>
                        <asp:ListItem Value="1">Fácil</asp:ListItem>
                        <asp:ListItem Value="2">Médio</asp:ListItem>
                        <asp:ListItem Value="3">Difícil</asp:ListItem>
                        <asp:ListItem Value="4">Muito Difícil</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

            <div class="col-4">
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Duração</label>
                    <asp:TextBox ID="DurationTxt" runat="server" CssClass="form-control" placeholder="Minutos" TextMode="Time"></asp:TextBox>
                </div>
            </div>

            <div class="col-4">
                <div class="form-group">
                    <label for="exampleFormControlSelect2">Categoria</label>
                    <asp:DropDownList ID="CategoryDropdown" runat="server" CssClass="form-control" placeholder="Categoria">
                        <asp:ListItem Value="0">Vegan</asp:ListItem>
                        <asp:ListItem Value="1">Alimentação Saudavel</asp:ListItem>
                        <asp:ListItem Value="2">Sopas</asp:ListItem>
                        <asp:ListItem Value="3">Carnes</asp:ListItem>
                        <asp:ListItem Value="4">Aves</asp:ListItem>
                        <asp:ListItem Value="5">Peixes</asp:ListItem>
                        <asp:ListItem Value="6">Massas</asp:ListItem>
                        <asp:ListItem Value="7">Bebidas</asp:ListItem>
                        <asp:ListItem Value="8">Sobremesas</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </div>

        </div>

        <div class="row mt-3">
            <h5>Ingredientes</h5>
            <div class="col-4">
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Nome ingrediente</label>
                    <asp:TextBox ID="nameIngrTxt" runat="server" CssClass="form-control" placeholder="Nome ingrediente" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
            <div class="col-4">
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Quantidade</label>
                    <asp:TextBox ID="quantityIngrTxt" runat="server" CssClass="form-control" placeholder="Quantidade ingrediente" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
            <div class="col-4">
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Unidade</label>
                    <asp:TextBox ID="UnitIngrTxt" runat="server" CssClass="form-control" placeholder="Unidade" TextMode="SingleLine"></asp:TextBox>
                </div>
            </div>
        </div>

        <asp:Button ID="AddRecipeBtn" CssClass="btn btn-primary" runat="server" Text="Adicionar" OnClick="AddRecipeBtn_Click" />
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
