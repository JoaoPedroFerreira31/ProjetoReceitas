<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Webforms.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">

    <section class="m-5">
        <div class="container">
           <center>

            <h1 class="mb-3">Login Page</h1>
            <asp:Login ID="Login2" runat="server" DestinationPageUrl="~/Default.aspx"></asp:Login>

           </center>
         </div>  
    </section>

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
