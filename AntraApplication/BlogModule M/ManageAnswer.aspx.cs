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
    public partial class ManageAnswer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AnswerMaster objAns = new AnswerMaster();
                try
                {
                    if (Request.QueryString["guid"] != null)
                    {
                        DataTable dt = objAns.getAnswerByAnswerId(new Guid(Request.QueryString["guid"]));
                        txtAnswer.Text = dt.Rows[0]["Answer"].ToString();
                    }

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    objAns = null;
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            AnswerMaster objAns = new AnswerMaster();
            objAns.ANSWER = txtAnswer.Text;
            if (Request.QueryString["guid"] != null && Request.QueryString["blogId"] != null)
            {
                objAns.BLOGID = new Guid(Request.QueryString["blogId"]);
                objAns.CREATEDBY = new Guid(HttpContext.Current.Session["User"].ToString());
                objAns.ID = new Guid(Request.QueryString["guid"]);
                objAns.updateAnswer();
            }
            else if (Request.QueryString["blogId"] != null)
            {
                objAns.BLOGID = new Guid(Request.QueryString["blogId"]);
                objAns.CREATEDBY = new Guid(HttpContext.Current.Session["User"].ToString());
                objAns.saveAnswer();
            }
        }
    }
}