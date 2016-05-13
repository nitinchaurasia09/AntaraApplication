<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  ValidateRequest="false" CodeBehind="ManageAnswer.aspx.cs" Inherits="AntaraApplication.BlogModule.ManageAnswer" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <!-- Page Content -->
    <div id="page-content-wrapper">
        <div class="container-fluid">
            <h3>Add/Edit Answer</h3>
            <hr />
            <div class="alert alert-success" id="lblError" runat="server">
            </div>

            <div class="modal-body">
                <form class="form-horizontal ">
                    <fieldset>
                        <div class="form-group clearfix">
                            <label for="inputName" class="col-lg-3 control-label">Answer *</label>
                            <div class="col-lg-9">
                                <asp:TextBox ID="txtAnswer" TextMode="MultiLine" Rows="9" Columns="3" runat="server" CssClass="form-control" MaxLength="50"></asp:TextBox>
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
                //if ($('#MainContent_txtAnswer').val().trim() == '') {
                //    alert('Please enter Answer');
                //    return false;
                //}
            });
        });

    </script>
     <script type="text/javascript" src="tiny_mce/tiny_mce.js"></script>
    <script type="text/javascript" language="javascript">
        tinyMCE.init({
            mode: "textareas",
            theme: "advanced",
            plugins: "pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups",

        });
    </script>


</asp:Content>