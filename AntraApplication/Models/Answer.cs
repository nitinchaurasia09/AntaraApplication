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
    public class AnswerMaster
    {
        private Guid id;
        private string Answer1;
        private string CreatedBy;
        private string BlogId;

        public Guid ID
        {
            get;
            set;
        }
        public string ANSWER
        {
            get;
            set;
        }

        public Guid CREATEDBY
        {
            get;
            set;
        }

        public Guid BLOGID
        {
            get;
            set;
        }
        
        public DataTable getAllAnswer()
        {
            DbParameter[] parameters = new DbParameter[1];
            //parameters = null;
            DataTable dtAnswer = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@blogId", BLOGID);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                dtAnswer = Ado.ExecuteStoredProcedure("sp_GetAllAnswer", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
                dtAnswer.Dispose();
            }
            return dtAnswer;
        }

        public DataTable getAnswerByAnswerId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            DataTable dtAnswer = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                dtAnswer = Ado.ExecuteStoredProcedure("sp_GetAllAnswer", parameters);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                parameters = null;
                dtAnswer.Dispose();
            }
            return dtAnswer;
        }

        public void deleteAnswerByAnswerId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                Ado.ExecuteNonQueryStoredProcedure("sp_DeleteAnswer", parameters);
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

        public void saveAnswer()
        {
            DbParameter[] parameters = new DbParameter[3];
            try
            {
                parameters[0] = new SqlParameter("@Answer", ANSWER);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.String;

                parameters[1] = new SqlParameter("@CreatedBy", CREATEDBY);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.Guid;

                parameters[2] = new SqlParameter("@BlogId", BLOGID);
                parameters[2].Direction = ParameterDirection.Input;
                parameters[2].DbType = DbType.Guid;

                Ado.ExecuteNonQueryStoredProcedure("sp_AddNewAnswer", parameters);
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

        public void updateAnswer()
        {
            DbParameter[] parameters = new DbParameter[2];
            try
            {
                parameters[0] = new SqlParameter("@guid", ID);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;

                parameters[1] = new SqlParameter("@Answer", ANSWER);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.String;

                Ado.ExecuteNonQueryStoredProcedure("sp_UpdateAnswer", parameters);
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