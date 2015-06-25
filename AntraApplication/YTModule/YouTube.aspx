<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="YouTube.aspx.cs" Inherits="AntaraApplication.YTModule.YouTube" EnableEventValidation="false" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:PlaceHolder ID="plcHolder" runat="server">
        <!-- Page Content -->
        <div id="page-content-wrapper">
            <div class="container-fluid">
                <h3>Edit Youtube Urls</h3>
                <hr />
                <div class="alert alert-success" id="lblError" runat="server">
                </div>

                <div class="modal-body">
                    <form class="form-horizontal ">
                        <fieldset>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <b>URL</b>
                                </div>
                                <div class="col-lg-4">
                                    <b>TEXT</b>
                                </div>
                            </div>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYoutubeUrl0" runat="server" CssClass="form-control" MaxLength="250"></asp:TextBox>
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYouTubeText0" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYoutubeUrl1" runat="server" CssClass="form-control" MaxLength="250"></asp:TextBox>
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYouTubeText1" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYoutubeUrl2" runat="server" CssClass="form-control" MaxLength="250"></asp:TextBox>
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYouTubeText2" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYoutubeUrl3" runat="server" CssClass="form-control" MaxLength="250"></asp:TextBox>
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYouTubeText3" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYoutubeUrl4" runat="server" CssClass="form-control" MaxLength="250"></asp:TextBox>
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYouTubeText4" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group clearfix">
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYoutubeUrl5" runat="server" CssClass="form-control" MaxLength="250"></asp:TextBox>
                                </div>
                                <div class="col-lg-4">
                                    <asp:TextBox ID="txtYouTubeText5" runat="server" CssClass="form-control" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                        </fieldset>
                    </form>
                </div>
                <div class="modal-footer">
                    <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                </div>
            </div>
        </div>
        <!-- /#page-content-wrapper -->
        <script>
            $(document).ready(function () {
                $('#MainContent_btnSave').click(function () {
                    //if ($('#MainContent_txtUserName').val().trim() == '') {
                    //    alert('Please select User Name');
                    //    return false;
                    //}

                });
            });
        </script>
    </asp:PlaceHolder>
</asp:Content>
