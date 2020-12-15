<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="PersonalArea.aspx.cs" Inherits="Webforms.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <header class="jumbotron" id="HeaderDefaultPage">
		<div class="container">
			<h1>Bem-Vindo <asp:LoginName ID="LoginName1" runat="server" /></h1>
			<p>Veja as nossas receitas!</p>		
		</div>
	</header>

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
