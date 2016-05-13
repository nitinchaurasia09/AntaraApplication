<%@ Page Language="C#"  AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="ShowAllAnswers.aspx.cs" Inherits="AntaraApplication.BlogModule.ShowAllAnswers" %>

<asp:content id="BodyContent" contentplaceholderid="MainContent" runat="server">
    <!-- Page Content -->
    
    <div id="page-content-wrapper"><h3>Manage Answer</h3><hr />
        <div class="container-fluid">
            <div class="row">
                <div><a href="ManageAnswer.aspx?blogId=<%=Request.QueryString["blogId"] %>" class="btn btn-primary btn-sm pull-right">Create new Answer</a></div>
            </div><p></p>
            <div class="row">
                <div class="col-lg-12">
                    <div class="table-responsive">
                        <asp:GridView ID="grdAnswer" runat="server" CssClass="table table-bordered table-hover table-striped" GridLines="None"
                            AutoGenerateColumns="False" OnRowCommand="grdAnswer_RowCommand" OnRowDeleting="grdAnswer_RowDeleting" ShowHeaderWhenEmpty="True" EmptyDataText="No records Found" PageSize="20" AllowPaging="true" OnPageIndexChanging="grdAnswer_PageIndexChanging">
                            <Columns>
                                <asp:TemplateField ItemStyle-CssClass="hide" HeaderStyle-CssClass="hide">
                                    <ItemTemplate>
                                        <asp:HiddenField ID ="hdnGUID" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "Id") %>'/>
                                    </ItemTemplate>
                                </asp:TemplateField>
                                <asp:BoundField DataField="Answer" HeaderText="Answer" />
                                <asp:BoundField DataField="AnswerDate" HeaderText="Answer Date" />
                                
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
</asp:content>
