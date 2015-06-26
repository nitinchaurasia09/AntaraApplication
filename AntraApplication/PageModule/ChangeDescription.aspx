<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChangeDescription.aspx.cs" Inherits="AntaraApplication.PageModule.ChangeDescription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Content -->
    <div id="page-content-wrapper">
        <div class="container-fluid">
            <h3>Edit Page Description</h3>
            <hr />
            <div class="alert alert-success" id="lblError" runat="server" visible="false">
            </div>

            <div class="modal-body">
                <fieldset>
                    <div class="form-group clearfix">
                        <label for="inputName" class="col-lg-3 control-label">Description</label>
                        <div class="col-lg-9">
                            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine" Width="640" Height="330"></asp:TextBox>
                        </div>
                    </div>
                </fieldset>
            </div>
            <div class="modal-footer">
                <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="btn btn-primary"/>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="tiny_mce/tiny_mce.js"></script>
    <script type="text/javascript" language="javascript">
        tinyMCE.init({
            mode: "textareas",
            theme: "advanced",
            plugins: "pagebreak,style,layer,table,save,advhr,advimage,advlink,emotions,iespell,inlinepopups",

        });
    </script>
</asp:Content>
