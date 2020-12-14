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

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
