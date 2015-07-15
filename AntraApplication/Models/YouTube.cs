using BusinessWrapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AntaraApplication.Models
{
    public class YouTube
    {
        private Guid guid;
        private string YouTubeLink;
        private int NumberOfTimeExecuted;
        private string YouTubeText;

        public Guid GUID
        {
            get;
            set;
        }

        public string YOUTUBELINK
        {
            get;
            set;
        }

        public int NUMBEROFTIMEEXECUTED
        {
            get;
            set;
        }

        public string YOUTUBETEXT
        {
            get;
            set;
        }


        public DataTable getAllYouTubeLink()
        {
            DbParameter[] parameters = new DbParameter[1];
            //parameters = null;
            DataTable dtUser = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@guid", null);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                dtUser = Ado.ExecuteStoredProcedure("sp_GetAllYTlinks", parameters);
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

        public void updateYouTube(List<YouTube> youtubes)
        {
            DbParameter[] parameters = new DbParameter[3];
            try
            {
                Ado.ExecuteNonQueryStoredProcedure("DeleteYouTubeUrls", null);
                foreach (YouTube yt in youtubes)
                {
                    parameters[0] = new SqlParameter("@YouTubeLink", yt.YOUTUBELINK);
                    parameters[0].Direction = ParameterDirection.Input;
                    parameters[0].DbType = DbType.String;


                    parameters[1] = new SqlParameter("@NumberOfTimeExecuted", yt.NUMBEROFTIMEEXECUTED);
                    parameters[1].Direction = ParameterDirection.Input;
                    parameters[1].DbType = DbType.Int16;


                    parameters[2] = new SqlParameter("@YouTubeText", yt.YOUTUBETEXT);
                    parameters[2].Direction = ParameterDirection.Input;
                    parameters[2].DbType = DbType.String;

                    Ado.ExecuteNonQueryStoredProcedure("UpdateYouTubeUrls", parameters);
                    //lblError.Visible = true;
                    //lblError.Text = "Updated Successfully";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
            }
        }
    }
}