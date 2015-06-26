using AntaraApplication.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntaraApplication.PageModule
{
    public partial class DynamicPageImages : System.Web.UI.Page
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
                try
                {
                    if (Request.Params["guid"] != null)
                    {
                        DataTable dt = objPage.getPageDescription(new Guid(Request.Params["guid"]));
                        if (dt.Rows.Count > 0)
                        {
                            imgPage.Visible = true;
                            imgPage.ImageUrl = dt.Rows[0]["ImageUrl"].ToString();
                            txtImageText.Text = dt.Rows[0]["ImageText"].ToString();
                            txtImageControl.Text = dt.Rows[0]["ImageControl"].ToString();
                            txtLabelControl.Text = dt.Rows[0]["LabelControl"].ToString();
                            hdnPageId.Value = dt.Rows[0]["PageId"].ToString();
                        }
                    }
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

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Request.Params["guid"] != null)
            {
                PageImage objPageImg = new PageImage();
                objPageImg.GUID = new Guid(Request.Params["guid"]);
                objPageImg.IMAGECONTROL = txtImageControl.Text;
                objPageImg.IMAGETEXT = txtImageText.Text;
                if (flPageImage.FileName != "")
                {
                    String path = Server.MapPath(imgPage.ImageUrl.Replace(ConfigurationManager.AppSettings["ImageUrl"].ToString(), ""));
                    if (System.IO.File.Exists(path)) { System.IO.File.Delete(path); }

                    string fileName = Path.GetFileName(flPageImage.PostedFile.FileName);
                    flPageImage.PostedFile.SaveAs(Server.MapPath("~/Images/") + fileName);
                    objPageImg.IMAGEURL = ConfigurationManager.AppSettings["ImageUrl"].ToString() + "Images/" + flPageImage.FileName;
                }
                else
                    objPageImg.IMAGEURL = imgPage.ImageUrl == "" ? ConfigurationManager.AppSettings["ImageUrl"].ToString() + "Images/" + "noimage.png" : imgPage.ImageUrl;



                objPageImg.LABELCONTROL = txtLabelControl.Text;
                objPageImg.PAGEID = new Guid(hdnPageId.Value);
                objPageImg.saveUser();

                DataTable dt = objPageImg.getPageDescription(new Guid(Request.Params["guid"]));
                if (dt.Rows.Count > 0)
                {
                    imgPage.Visible = true;
                    imgPage.ImageUrl = dt.Rows[0]["ImageUrl"].ToString();
                    txtImageText.Text = dt.Rows[0]["ImageText"].ToString();
                    txtImageControl.Text = dt.Rows[0]["ImageControl"].ToString();
                    txtLabelControl.Text = dt.Rows[0]["LabelControl"].ToString();
                    hdnPageId.Value = dt.Rows[0]["PageId"].ToString();
                }
            }
        }


    }
}