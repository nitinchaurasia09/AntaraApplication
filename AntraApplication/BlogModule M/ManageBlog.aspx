<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/Site.Master"  CodeBehind="ManageBlog.aspx.cs" Inherits="AntaraApplication.BlogModule.ManageBlog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <!-- Page Content -->
    <div id="page-content-wrapper">
        <div class="container-fluid">
            <h3>Add/Edit User</h3>
            <hr />
            <div class="alert alert-success" id="lblError" runat="server">
            </div>

            <div class="modal-body">
                <form class="form-horizontal ">
                    <fieldset>
                        <div class="form-group clearfix">
                            <label for="inputName" class="col-lg-3 control-label">Blog Name *</label>
                            <div class="col-lg-9">
                                <asp:TextBox ID="txtBlogName" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group clearfix">
                            <label for="inputName" class="col-lg-3 control-label">Describe For *</label>
                            <div class="col-lg-9">
                                <asp:TextBox ID="txtDescribeFor" runat="server" Width="300px" Columns="2" Rows="2" CssClass="form-control" MaxLength="24"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group clearfix">
                            <label for="inputName" class="col-lg-3 control-label">Description *</label>
                            <div class="col-lg-9">
                                <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="300px" Columns="2" Rows="2" CssClass="form-control" MaxLength="300"></asp:TextBox>
                            </div>
                        </div>
                                                
                    </fieldset>
                </form>
            </div>
            <div class="modal-footer">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Back" CssClass="btn btn-warning" PostBackUrl="ShowAllBlog.aspx" />
            </div>
        </div>
    </div>
    <!-- /#page-content-wrapper -->
    <script>
        $(document).ready(function () {
            $('#MainContent_btnSave').click(function () {
                if ($('#MainContent_txtBlogName').val().trim() == '') {
                    alert('Please select User Name');
                    return false;
                }
                if ($('#MainContent_txtDescribeFor').val().trim() == '') {
                    alert('Please enter Describe For');
                    return false;
                } 
                if ($('#MainContent_txtDescription').val().trim() == '') {
                    alert('Please enter Description');
                    return false;
                }

            });
        });
       
    </script>


</asp:Content>