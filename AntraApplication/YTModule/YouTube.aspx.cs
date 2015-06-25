using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace AntaraApplication.YTModule
{
    public partial class YouTube : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.Identity.IsAuthenticated && Session["User"] == null)
            {
                Response.Redirect("~/Default.aspx?ReturnUrl=~" + Server.UrlEncode(Request.RawUrl));
            }
            if (!IsPostBack)
            {

                AntaraApplication.Models.YouTube ytObj = new AntaraApplication.Models.YouTube();
                lblError.Visible = false;
                try
                {
                    DataTable dt = ytObj.getAllYouTubeLink();
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        ((TextBox)plcHolder.FindControl("txtYoutubeUrl" + i)).Text = dt.Rows[i][1].ToString();
                        ((TextBox)plcHolder.FindControl("txtYouTubeText" + i)).Text = dt.Rows[i][3].ToString();
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string url = String.Empty;
            string text = String.Empty;
            List<AntaraApplication.Models.YouTube> objYTs = new List<AntaraApplication.Models.YouTube>();
            AntaraApplication.Models.YouTube objYT = new AntaraApplication.Models.YouTube();
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    url = ((TextBox)plcHolder.FindControl("txtYoutubeUrl" + i)).Text;
                    text = ((TextBox)plcHolder.FindControl("txtYouTubeText" + i)).Text;
                    if (url != "" && text != "")
                    {
                        objYTs.Add(new AntaraApplication.Models.YouTube() { YOUTUBELINK = url, YOUTUBETEXT = text, GUID = Guid.Empty, NUMBEROFTIMEEXECUTED = 0 });
                    }
                }
                objYT.updateYouTube(objYTs);
            }
            catch (Exception ex)
            {
                lblError.Visible = true;
                lblError.InnerHtml = ex.Message;
            }
            finally
            {
                objYTs = null;
                objYT = null;
            }
        }
    }
}