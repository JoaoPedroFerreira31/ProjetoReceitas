<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="Webforms.WebForm6" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    
    <div class="form-group">
        <label for="exampleFormControlInput1">First Name</label>
        <asp:TextBox ID="FirstNameTxt" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <label for="exampleInputPassword1">Last Name</label>
        <asp:TextBox ID="LastNameTxt" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
    <label for="exampleFormControlSelect1">Example select</label>
    <select class="form-control" id="exampleFormControlSelect1">
      <option>1</option>
      <option>2</option>
      <option>3</option>
      <option>4</option>
      <option>5</option>
    </select>
  </div>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
