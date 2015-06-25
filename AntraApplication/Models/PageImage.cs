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
        private Guid guid;
        private Guid PageId;
        private string ImageUrl;
        private string ImageText;
        private string ImageControl;
        private string LabelControl;

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
    }
}