using AntaraApplication.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntaraApplication.PageModule
{
    public partial class ChangeDescription : System.Web.UI.Page
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            PageMaster objPageMaster = new PageMaster();
            objPageMaster.updatePageDescription(txtDescription.Text, new Guid(ddlPageName.SelectedValue));
        }

        protected void ddlPageName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PageMaster objPage = new PageMaster();
            try
            {
                DataTable dt = objPage.getPageDescription(new Guid(ddlPageName.SelectedValue));
                txtDescription.Text = dt.Rows[0]["PageDescription"].ToString();
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
    }
}