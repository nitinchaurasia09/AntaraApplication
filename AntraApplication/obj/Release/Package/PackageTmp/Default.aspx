<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AntaraApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <div id="navbar-example" role="navigation" class="navbar navbar-default navbar-fixed-top">
            <div class="container">
                <div class="navbar-header">
                    <a href="../" class="navbar-brand">Antara Control Panel</a>
                </div>
                <div class="navbar-collapse navbar-responsive-collapse collapse" aria-expanded="false" style="height: 1px;">
                </div>
            </div>
        </div>
    </header>
    <div id="page-content-wrapper">
        <div class="container-fluid">
            <div class="alert alert-danger" id="lblError" runat="server" visible="false">
            </div>
        </div>
    </div>
    <div id="wrapper">
        <div class="container">
            <div class="row">
                <div class="col-md-offset-5 col-md-3">
                    <div class="form-login">
                        <h4>Welcome to Antara.</h4>
                        <asp:Label ID="lblUName" runat="server" Text="User Email"></asp:Label>
                        <asp:TextBox ID="txtUserName" runat="server" CssClass="form-control input-sm chat-input"></asp:TextBox>
                        <br>
                        <asp:Label ID="lblPass" runat="server" Text="User Password"></asp:Label>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control input-sm chat-input"></asp:TextBox>
                        <br>
                        <div class="wrapper">
                            <span class="group-btn">
                                <asp:LinkButton ID="lbtnLogin" runat="server" CssClass="btn btn-primary btn-md" OnClick="lbtnLogin_Click">login <i class="fa fa-sign-in"></i></asp:LinkButton>
                            </span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            $("#menu-toggle").hide();
            $("#sidebar-wrapper").hide();
        });
</script>
</asp:Content>
