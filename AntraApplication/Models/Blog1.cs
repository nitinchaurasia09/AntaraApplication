using BusinessWrapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using AntaraApplication.Models;
using MySql.Data.MySqlClient;


namespace AntaraApplication.Models
{
    public class Blog
    {
        private Guid id;
        private string BlogName;
        private string Description;
        private string DescribeFor;
        private string CreatedDate;
        private Guid CreatedBy;

        public Guid ID
        {
            get;
            set;
        }
        public string BLOGNAME
        {
            get;
            set;
        }

        public string DESCRIPTION
        {
            get;
            set;
        }

        public string DESCRIBEFOR
        {
            get;
            set;
        }

        public string CREATEDDATE
        {
            get;
            set;
        }

        public Guid CREATEDBY
        {
            get;
            set;
        }

        public DataTable getAllBlogs()
        {
            DbParameter[] parameters = new DbParameter[1];
            //parameters = null;
            DataTable dtBlog = new DataTable();
            try
            {                
                parameters[0] = new SqlParameter("@guid", null);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;

                dtBlog = Ado.ExecuteStoredProcedure("sp_GetAllBlogs", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
                dtBlog.Dispose();
            }
            return dtBlog;
        }

        public DataTable getBlogsByBlogId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            DataTable dtBlog = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                dtBlog = Ado.ExecuteStoredProcedure("sp_GetAllBlogs", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
                dtBlog.Dispose();
            }
            return dtBlog;
        }

        public void deleteBlogByBlogId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                Ado.ExecuteNonQueryStoredProcedure("sp_DeleteBlog", parameters);
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

        public void saveBlog()
        {
            DbParameter[] parameters = new DbParameter[4];
            try
            {
                parameters[0] = new SqlParameter("@BlogName", BLOGNAME);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.String;

                parameters[1] = new SqlParameter("@Description", DESCRIPTION);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.String;

                parameters[2] = new SqlParameter("@DescribeFor", DESCRIBEFOR);
                parameters[2].Direction = ParameterDirection.Input;
                parameters[2].DbType = DbType.String;

                parameters[3] = new SqlParameter("@CreatedBy", CREATEDBY);
                parameters[3].Direction = ParameterDirection.Input;
                parameters[3].DbType = DbType.Guid;

                Ado.ExecuteNonQueryStoredProcedure("sp_AddNewBlog", parameters);
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

        public void updateBlog()
        {
            DbParameter[] parameters = new DbParameter[4];
            try
            {
                parameters[0] = new SqlParameter("@guid", ID);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;

                parameters[1] = new SqlParameter("@BlogName", BLOGNAME);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.String;

                parameters[2] = new SqlParameter("@Description", DESCRIPTION);
                parameters[2].Direction = ParameterDirection.Input;
                parameters[2].DbType = DbType.String;

                parameters[3] = new SqlParameter("@DescribeFor", DESCRIBEFOR);
                parameters[3].Direction = ParameterDirection.Input;
                parameters[3].DbType = DbType.String;               

                Ado.ExecuteNonQueryStoredProcedure("sp_UpdateBlog", parameters);
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