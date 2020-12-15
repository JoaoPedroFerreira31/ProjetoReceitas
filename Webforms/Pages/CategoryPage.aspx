<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="CategoryPage.aspx.cs" Inherits="Webforms.WebForm3" %>

<%@ Import Namespace="PRE.Model.Model" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <div class="jumbotron">
        <h1 class="display-4">Receitas de <%: categoryName  %></h1>
        <p class="lead">Veja as melhores receitas na categoria <%: categoryName %></p>
    </div>

    <section class="mt-5 mb-5">
        <div class="row">

            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <div class="col-md-4">
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

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
