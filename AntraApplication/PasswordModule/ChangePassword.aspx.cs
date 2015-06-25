using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AntaraApplication.Models;
using AntaraApplication.Models.Security;

namespace AntaraApplication.PasswordModule
{
    public partial class ChangePassword : AuthenticationBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated && Session["User"] == null)
            {
                Response.Redirect("~/Default.aspx?ReturnUrl=~" + Server.UrlEncode(Request.RawUrl));
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            User objUser = new User();
            try
            {
                if (txtOldPassword.Text == "")
                {
                    lblError.Visible = true;
                    lblError.InnerHtml = "Please enter old password";
                }
                else if (txtNewPassword.Text == "")
                {
                    lblError.Visible = true;
                    lblError.InnerHtml = "Please enter new password";
                }
                else if (txtConfirmPassword.Text != txtNewPassword.Text)
                {
                    lblError.Visible = true;
                    lblError.InnerHtml = "New password and confirm password should be same";
                }
                else
                {
                    objUser.GUID = new Guid(HttpContext.Current.Session["User"].ToString());
                    objUser.Password = PasswordHash.CreateHash(txtNewPassword.Text);
                    objUser.updatePassword(txtNewPassword.Text);
                    lblError.Visible = true;
                    lblError.InnerHtml = "Review added successfully";
                }
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.InnerHtml = ex.Message;
            }
            finally
            {
                objUser = null;
            }
        }
    }
}