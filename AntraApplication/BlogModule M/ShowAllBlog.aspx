<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master"  CodeBehind="ShowAllBlog.aspx.cs" Inherits="AntaraApplication.BlogModule.ShowAllBlog" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!-- Page Content -->
    
    <div id="page-content-wrapper"><h3>Manage Blog</h3><hr />
        <div class="container-fluid">
            <div class="row">
                <div><a href="ManageBlog.aspx" class="btn btn-primary btn-sm pull-right">Create new Blog</a></div>
            </div><p></p>
            <div class="row">
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <asp:GridView ID="grdBlog" runat="server" CssClass="table table-bordered table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False" OnRowCommand="grdBlog_RowCommand" OnRowDeleting="grdBlog_RowDeleting" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found" PageSize="20" AllowPaging="true" OnPageIndexChanging="grdBlog_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField ItemStyle-CssClass="hide" HeaderStyle-CssClass="hide">
                                                <ItemTemplate>
                                                    <asp:HiddenField ID ="hdnGUID" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "Id") %>'/>
                                                </ItemTemplate>
                                            </asp:TemplateField>
                                <asp:BoundField DataField="BlogName" HeaderText="Blog Name" />
                                <asp:BoundField DataField="Description" HeaderText="Description" />
                                <asp:BoundField DataField="DescribeFor" HeaderText="Describe For" />
                                <asp:BoundField DataField="CreatedDate" HeaderText="Created Date" />
                  
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton CssClass="btn btn-primary btn-xs" CommandName="Edit" Text="Edit" runat="server" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
                                        <asp:LinkButton CssClass="btn btn-primary btn-xs" CommandName="Delete" Text="Delete" runat="server" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
                                        <asp:LinkButton CssClass="btn btn-primary btn-xs" CommandName="ManageAnswer" Text="Manage Answer" runat="server" CommandArgument="<%# Container.DataItemIndex %>"></asp:LinkButton>
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
