using AntaraApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntaraApplication.PageModule
{
    public partial class ManageDynamicPages : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated && Session["User"] == null)
            {
                Response.Redirect("~/Default.aspx?ReturnUrl=~" + Server.UrlEncode(Request.RawUrl));
            }
            if (!IsPostBack)
            {
                PageImage objPage = new PageImage();
                ddlPageName.DataSource = objPage.getAllPage();
                ddlPageName.DataBind();
                ddlPageName.Items.Insert(0, new ListItem("Select", Guid.Empty.ToString(), true));
            }
        }
        protected void ddlPageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageImage objPage = new PageImage();
            try
            {
                grdPages.DataSource = objPage.getPageByGuid(new Guid(ddlPageName.SelectedValue));
                grdPages.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objPage = null;
            }
        }


        protected void grdPages_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName.Equals("Delete"))
                {
                    PageImage objPage = new PageImage();
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdPages.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    objPage.deletePageImage(new Guid(hdnField.Value.ToString()));
                }
                if (e.CommandName.Equals("Edit"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdPages.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    Response.Redirect("DynamicPageImages.aspx?guid=" + new Guid(hdnField.Value.ToString()));
                }
                if (e.CommandName.Equals("Description"))
                {
                    int index = Convert.ToInt32(e.CommandArgument);
                    GridViewRow row = grdPages.Rows[index];
                    HiddenField hdnField = (HiddenField)row.FindControl("hdnGUID");
                    Response.Redirect("ChangeDescription.aspx?guid=" + new Guid(hdnField.Value.ToString()));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}