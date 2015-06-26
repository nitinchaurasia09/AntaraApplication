using BusinessWrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AntaraApplication.Models
{
    public class PageImage
    {
        public Guid GUID
        {
            get;
            set;
        }

        public Guid PAGEID
        {
            get;
            set;
        }

        public string IMAGEURL
        {
            get;
            set;
        }

        public string IMAGETEXT
        {
            get;
            set;
        }

        public string IMAGECONTROL
        {
            get;
            set;
        }

        public string LABELCONTROL
        {
            get;
            set;
        }

        public DataTable getAllPageImages()
        {
            DbParameter[] parameters = new DbParameter[1];
            parameters = null;
            DataTable dtUser = new DataTable();
            try
            {
                dtUser = Ado.ExecuteStoredProcedure("sp_GetAllPageImages", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
                dtUser.Dispose();
            }
            return dtUser;
        }

        public DataTable getPageImageByPageId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            DataTable dtUser = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                dtUser = Ado.ExecuteStoredProcedure("sp_GetAllPageImages", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
                dtUser.Dispose();
            }
            return dtUser;
        }

        public DataTable getAllPage()
        {
            DataTable dtPage = new DataTable();
            try
            {
                dtPage = Ado.ExecuteText("select * from [page_master]");
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

        public DataTable getPageByGuid(Guid guid)
        {
            DataTable dtPage = new DataTable();
            try
            {
                dtPage = Ado.ExecuteText("select pitm.GUID, pm.PageName, pitm.ImageUrl, pitm.ImageText from page_master pm, page_image_text_master pitm where pm.GUID = pitm.PageId and pitm.PageId = '" + guid + "'");
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

        public DataTable getPageDescription(Guid guid)
        {
            DataTable dtPage = new DataTable();
            try
            {
                dtPage = Ado.ExecuteText("select * from page_image_text_master where GUID = '" + guid + "'");
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

        public DataTable deletePageImage(Guid guid)
        {
            DataTable dtPage = new DataTable();
            try
            {
                dtPage = Ado.ExecuteText("delete from page_image_text_master where GUID = '" + guid + "'");
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

        public void saveUser()
        {
            try
            {
                Ado.ExecuteNoneQueryText("UPDATE [dbo].[page_image_text_master] SET [ImageUrl] = '" + IMAGEURL + "'    ,[ImageText] = '" + IMAGETEXT + "' ,[ImageControl] = '" + IMAGECONTROL + "' ,[LabelControl] = '" + LABELCONTROL + "' WHERE GUID = '" + GUID + "'");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
            }
        }
    }
}