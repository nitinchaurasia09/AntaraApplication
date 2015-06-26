<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DynamicPageImages.aspx.cs" Inherits="AntaraApplication.PageModule.DynamicPageImages" EnableEventValidation="false" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Content -->
    <div id="page-content-wrapper">
        <div class="container-fluid">
            <h3>Add/Edit Page</h3>
            <hr />
            <div class="alert alert-success" id="lblError" runat="server" visible="false">
            </div>

            <div class="modal-body">
                <asp:HiddenField ID="hdnPageId" runat="server" />
                <fieldset>
                    <div class="form-group clearfix">
                        <label for="inputName" class="col-lg-3 control-label">Image *</label>
                        <div class="col-lg-9">
                            <asp:FileUpload ID="flPageImage" runat="server" ViewStateMode="Disabled" />
                        </div>
                    </div>
                    <div class="form-group clearfix">
                        <label for="inputName" class="col-lg-3 control-label"></label>
                        <div class="col-lg-9">
                            <asp:Image ID="imgPage" runat="server" Width="100" Height="100" Visible="false" />
                        </div>
                    </div>
                    <div class="form-group clearfix">
                        <label for="inputName" class="col-lg-3 control-label">Image Text *</label>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtImageText" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group clearfix">
                        <label for="inputName" class="col-lg-3 control-label">Image Control *</label>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtImageControl" runat="server" CssClass="form-control" MaxLength="50" Enabled="false"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group clearfix">
                        <label for="inputName" class="col-lg-3 control-label">Label Control *</label>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtLabelControl" runat="server" CssClass="form-control" MaxLength="50" Enabled="false"></asp:TextBox>
                        </div>
                    </div>
                </fieldset>
            </div>
            <div class="modal-footer">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
            </div>
        </div>
    </div>
</asp:Content>
