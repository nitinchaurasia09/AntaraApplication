using AntaraApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntaraApplication.BlogModule
{
    public partial class ShowAllBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated && Session["User"] == null)
            {
                Response.Redirect("~/Default.aspx?ReturnUrl=~" + Server.UrlEncode(Request.RawUrl));
            }
            if (!IsPostBack)
                bindBlogs();
        }

        protected void grdBlog_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Delete"))
                {
                    Blog blog = new Blog();
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdBlog.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    blog.deleteBlogByBlogId(new Guid(hdnField.Value.ToString()));
                    bindBlogs();
                }
                if (e.CommandName.Equals("Edit"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdBlog.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    Response.Redirect("ManageBlog.aspx?guid=" + new Guid(hdnField.Value.ToString()));
                }
                if (e.CommandName.Equals("ManageAnswer"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdBlog.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    Response.Redirect("ShowAllAnswers.aspx?blogId=" + new Guid(hdnField.Value.ToString()));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void grdBlog_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdBlog_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdBlog.PageIndex = e.NewPageIndex;
            grdBlog.DataBind();
            bindBlogs();
        }

        private void bindBlogs()
        {
            Blog blog = new Blog();
            try
            {
                grdBlog.DataSource = blog.getAllBlogs();
                grdBlog.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                blog = null;
            }
        }
    }
}