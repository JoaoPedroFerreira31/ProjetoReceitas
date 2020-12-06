<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Webforms.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <h1>Register</h1>
   
            
                <div class="form-group">
                    <label for="exampleFormControlInput1">First Name</label>
                    <asp:TextBox ID="FirstNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Last Name</label>
                    <asp:TextBox ID="LastNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <label for="exampleFormControlSelect1">Data Nascimento</label>
                <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
                <asp:Button ID="RegisterBtn" runat="server" Text="Submit" OnClick="RegisterBtn_Click" />
          
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
