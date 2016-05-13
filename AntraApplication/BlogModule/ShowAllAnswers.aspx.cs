using AntaraApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntaraApplication.BlogModule
{
    public partial class ShowAllAnswers : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated && Session["User"] == null)
            {
                Response.Redirect("~/Default.aspx?ReturnUrl=~" + Server.UrlEncode(Request.RawUrl));
            }
            if (!IsPostBack)
                bindAnswers();
        }

        protected void grdAnswer_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Delete"))
                {
                    AnswerMaster blog = new AnswerMaster();
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdAnswer.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    blog.deleteAnswerByAnswerId(new Guid(hdnField.Value.ToString()));
                    bindAnswers();
                }
                if (e.CommandName.Equals("Edit"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdAnswer.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    Response.Redirect("ManageAnswer.aspx?guid=" + new Guid(hdnField.Value.ToString()) + "&blogId=" + new Guid(Request.QueryString["blogId"].ToString()));
                }               
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        protected void grdAnswer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

        protected void grdAnswer_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdAnswer.PageIndex = e.NewPageIndex;
            grdAnswer.DataBind();
            bindAnswers();
        }

        private void bindAnswers()
        {
            AnswerMaster blog = new AnswerMaster();
            try
            {
                blog.BLOGID = new Guid(Request.QueryString["blogId"]);
                grdAnswer.DataSource = blog.getAllAnswer();
                grdAnswer.DataBind();
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