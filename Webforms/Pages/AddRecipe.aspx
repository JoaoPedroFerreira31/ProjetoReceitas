<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AddRecipe.aspx.cs" Inherits="Webforms.WebForm7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="container">
        <h1 class="my-3">Adicionar Receita</h1>

        <div class="form-group">
            <label for="exampleFormControlInput1">Titulo</label>
            <asp:TextBox ID="NameTxt" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <div class="form-group">
            <label for="exampleFormControlSelect1">Descrição</label>
            <asp:TextBox ID="DesriptionTxt" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group">
            <label for="exampleFormControlSelect1">Duração</label>

            <div class="row">

                <div class="col-4">
                    <asp:TextBox ID="DayTxt" runat="server" CssClass="form-control" placeholder="Dia (Opcional)"></asp:TextBox></div>
                <div class="col-4">
                    <asp:TextBox ID="HourTxt" runat="server" CssClass="form-control" placeholder="Horas (Opcional)"></asp:TextBox></div>
                <div class="col-4">
                    <asp:TextBox ID="MinuteTxt" runat="server" CssClass="form-control" placeholder="Minutos"></asp:TextBox></div>

            </div>
        </div>
        <div class="row">
        
        <div class="col-6">
        <div class="form-group">
            <label for="exampleFormControlSelect2">Dificuldade</label>
            <asp:DropDownList ID="DifficultyDropdown" runat="server" CssClass="form-control">
                <asp:ListItem Value="0">Muito Fácil</asp:ListItem>
                <asp:ListItem Value="1">Fácil</asp:ListItem>
                <asp:ListItem Value="2">Médio</asp:ListItem>
                <asp:ListItem Value="3">Difícil</asp:ListItem>
                <asp:ListItem Value="4">Muito Difícil</asp:ListItem>
            </asp:DropDownList>
        </div>
        </div>

        <div class="col-6">
        <div class="form-group">
            <label for="exampleFormControlSelect2">Categoria</label>
            <asp:DropDownList ID="CategoryDropdown" runat="server" CssClass="form-control">
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

        <asp:Button ID="AddRecipeBtn" CssClass="btn btn-primary" runat="server" Text="Adicionar" OnClick="AddRecipeBtn_Click" />
    </div>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
