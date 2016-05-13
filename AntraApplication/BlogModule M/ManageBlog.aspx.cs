using AntaraApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntaraApplication.BlogModule
{
    public partial class ManageBlog : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated && Session["User"] == null)
            {
                Response.Redirect("~/Default.aspx?ReturnUrl=~" + Server.UrlEncode(Request.RawUrl));
            }
            if (!IsPostBack)
            {
                lblError.Visible = false;
                lblError.InnerHtml = "";
                //divPassword.Visible = true;
                if (Request.QueryString["guid"] != null)
                {
                    Blog blog = new Blog();
                    try
                    {
                        txtBlogName.Enabled = false;
                        DataTable dt = blog.getBlogsByBlogId(new Guid(Request.QueryString["guid"].ToString()));
                        if (dt.Rows.Count > 0)
                        {
                            txtBlogName.Text = dt.Rows[0]["BlogName"].ToString();
                            txtDescribeFor.Text = dt.Rows[0]["DescribeFor"].ToString();
                            txtDescription.Text = dt.Rows[0]["Description"].ToString();                        
                        }
                    }
                    catch (Exception ex)
                    {

                    }
                    finally
                    {
                        blog = null;
                    }
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Blog objAddNewBlog = new Blog();
            try
            {
                if (string.IsNullOrWhiteSpace(txtBlogName.Text))
                {
                    lblError.Visible = true;
                    lblError.InnerHtml = "Please enter Blog Name";
                }
                else if (string.IsNullOrWhiteSpace(txtDescribeFor.Text))
                {
                    lblError.Visible = true;
                    lblError.InnerHtml = "Please enter Describe For";
                }
                else if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    lblError.Visible = true;
                    lblError.InnerHtml = "Please enter Description";
                }
                else
                {
                    if (Request.QueryString["guid"] == null)
                    {
                        objAddNewBlog.BLOGNAME= txtBlogName.Text;
                        objAddNewBlog.DESCRIBEFOR = txtDescribeFor.Text;
                        objAddNewBlog.DESCRIPTION = txtDescription.Text;
                        objAddNewBlog.CREATEDBY = new Guid(HttpContext.Current.Session["User"].ToString());
                        objAddNewBlog.saveBlog();
                        lblError.Visible = true;
                        lblError.InnerHtml = "Blog created successfully";
                    }
                    else
                    {
                        objAddNewBlog.ID = new Guid(Request.QueryString["guid"].ToString());
                        objAddNewBlog.BLOGNAME = txtBlogName.Text;
                        objAddNewBlog.DESCRIBEFOR = txtDescribeFor.Text;
                        objAddNewBlog.DESCRIPTION = txtDescription.Text;
                        objAddNewBlog.updateBlog();
                        lblError.Visible = true;
                        lblError.InnerHtml = "Blog updated successfully";                        
                    }
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.InnerHtml = ex.Message;
            }
            finally
            {
                objAddNewBlog = null;
            }
        }
    }
}