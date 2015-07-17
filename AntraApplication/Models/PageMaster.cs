using BusinessWrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace AntaraApplication.Models
{
    public class PageMaster
    {
        public void updatePageDescription(string description, Guid guid)
        {
            try
            {
                Ado.ExecuteNoneQueryText("UPDATE page_master SET PageDescription = '" + description.Replace("'","''") + "' WHERE GUID = '" + guid + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }

        public DataTable getPageDescription(Guid guid)
        {
            DataTable dtPage = new DataTable();
            try
            {
                dtPage = Ado.ExecuteText("select PageDescription from page_master where GUID = '" + guid + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dtPage.Dispose();
            }
            return dtPage;
        }

    }
}