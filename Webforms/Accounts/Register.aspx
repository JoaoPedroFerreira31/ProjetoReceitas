<%@ Page Title="" Language="C#" MasterPageFile="~/SiteMaster.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Webforms.WebForm5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <center>
    <h1 class="my-4">Criar conta</h1>
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" ContinueDestinationPageUrl="~/Default.aspx" OnCreatedUser="CreateUserWizard1_CreatedUser">
        <WizardSteps>
            <asp:WizardStep runat="server" Title="NewUser">
                <div class="form-group">
                    <label for="exampleFormControlInput1">Primeiro nome</label>
                    <asp:TextBox ID="FirstNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Ultimo nome</label>
                    <asp:TextBox ID="LastNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Data de nascimento</label>
                    <div class="row">
                        <div class="col-4">
                            <asp:TextBox ID="DayTxt" runat="server" CssClass="form-control" placeholder="Dia"></asp:TextBox></div>
                        <div class="col-4">
                            <asp:TextBox ID="MonthTxt" runat="server" CssClass="form-control" placeholder="Mês"></asp:TextBox></div>
                        <div class="col-4">
                            <asp:TextBox ID="YearTxt" runat="server" CssClass="form-control" placeholder="Ano"></asp:TextBox></div>
                    </div>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">Genero</label>
                    <asp:DropDownList ID="UserGender" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">NA</asp:ListItem>
                        <asp:ListItem Value="1">Masculino</asp:ListItem>
                        <asp:ListItem Value="2">Feminino</asp:ListItem>
                        <asp:ListItem Value="3">Outro</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Email</label>
                    <asp:TextBox ID="EmailTxt" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                </div>
                <%--<asp:Button ID="RegisterBtn" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="RegisterBtn_Click" />--%>
            </asp:WizardStep>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
            </asp:CompleteWizardStep>
        </WizardSteps>
    </asp:CreateUserWizard>
    </center>
    
    
    <%--<div class="container">            
            <h1 class="my-3">Criar conta</h1>   
            
                <div class="form-group">
                    <label for="exampleFormControlInput1">Primeiro nome</label>
                    <asp:TextBox ID="FirstNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Ultimo nome</label>
                    <asp:TextBox ID="LastNameTxt" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Data de nascimento</label>
                    <div class="row">
                       <div class="col-4"><asp:TextBox ID="DayTxt" runat="server" CssClass="form-control" placeholder="Dia"></asp:TextBox></div>
                       <div class="col-4"><asp:TextBox ID="MonthTxt" runat="server" CssClass="form-control" placeholder="Mês"></asp:TextBox></div>
                       <div class="col-4"><asp:TextBox ID="YearTxt" runat="server" CssClass="form-control" placeholder="Ano"></asp:TextBox></div>                       
                    </div>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect2">Genero</label>
                    <asp:DropDownList ID="UserGender" runat="server" CssClass="form-control">
                        <asp:ListItem Value="0">NA</asp:ListItem>
                        <asp:ListItem Value="1">Masculino</asp:ListItem>
                        <asp:ListItem Value="2">Feminino</asp:ListItem>
                        <asp:ListItem Value="3">Outro</asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="form-group">
                    <label for="exampleFormControlSelect1">Email</label>
                    <asp:TextBox ID="EmailTxt" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                </div>
                <asp:Button ID="RegisterBtn" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="RegisterBtn_Click" />
         </div> --%>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="FooterPlaceHolder" runat="server">
</asp:Content>
