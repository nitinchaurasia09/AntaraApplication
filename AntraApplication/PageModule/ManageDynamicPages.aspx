<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageDynamicPages.aspx.cs" Inherits="AntaraApplication.PageModule.ManageDynamicPages" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Content -->

    <div id="page-content-wrapper">
        <h3>Manage Dynamic Pages</h3>
        <hr />
        <div class="container-fluid">
            <div class="row">
                <div class="form-group clearfix">
                    <label for="inputName" class="col-lg-3 control-label">Page Name *</label>
                    <div class="col-lg-9">
                        <asp:DropDownList ID="ddlPageName" runat="server" DataTextField="PageName" DataValueField="GUID" Width="280px" CssClass="form-control" AutoPostBack="true" OnSelectedIndexChanged="ddlPageName_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <asp:GridView ID="grdPages" runat="server" CssClass="table table-bordered table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found" OnRowCommand="grdPages_RowCommand">
                            <Columns>
                                <asp:TemplateField ItemStyle-CssClass="hide" HeaderStyle-CssClass="hide">
                                    <ItemTemplate>
                                        <asp:HiddenField ID="hdnGUID" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "GUID") %>' />
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="ImageText" HeaderText="Image Text" />                                
                                <asp:ImageField DataImageUrlField="ImageUrl" HeaderText="Image Url" ControlStyle-Width="100" ControlStyle-Height="100"/>
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton CssClass="btn btn-primary btn-xs" CommandName="Edit" Text="Edit" runat="server" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
                                        <asp:LinkButton CssClass="btn btn-primary btn-xs" CommandName="Delete" Text="Delete" runat="server" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>                                        
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                            <RowStyle CssClass="cursor-pointer" />
                        </asp:GridView>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- /#page-content-wrapper -->

</asp:Content>
