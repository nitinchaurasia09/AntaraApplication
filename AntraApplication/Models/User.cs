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
    public class User
    {
        private Guid guid;
        private string userName;
        private string userEmail;
        private string userPhone;
        private string userLocation;
        private string firstName;
        private string lastName;
        private string password;
        private string userImage;
        private int isAdmin;
        private DateTime createdDate;
        private int deleteStatus;
        private int userStatus;

        public Guid GUID
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }

        public string UserImage
        {
            get;
            set;
        }

        public string UserEmail
        {
            get;
            set;
        }

        public string UserPhone
        {
            get;
            set;
        }

        public string UserLocation
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Password
        {
            get;
            set;
        }

        public int IsAdmin
        {
            get;
            set;
        }

        public DateTime CreatedDate
        {
            get;
            set;
        }

        public int DeleteStatus
        {
            get;
            set;
        }

        public int UserStatus
        {
            get;
            set;
        }

        public DataTable getAllUsers()
        {
            DbParameter[] parameters = new DbParameter[1];
            //parameters = null;
            DataTable dtUser = new DataTable();
            try
            {                
                parameters[0] = new SqlParameter("@guid", null);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;

                dtUser = Ado.ExecuteStoredProcedure("sp_GetAllUsers", parameters);
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

        public DataTable getUsersByUserId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            DataTable dtUser = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                dtUser = Ado.ExecuteStoredProcedure("sp_GetAllUsers", parameters);
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

        public void deleteUserByUserId(Guid guid)
        {
            DbParameter[] parameters = new DbParameter[1];
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;
                Ado.ExecuteNonQueryStoredProcedure("sp_DeleteUser", parameters);
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

        public void saveUser()
        {
            DbParameter[] parameters = new DbParameter[10];
            try
            {
                parameters[0] = new SqlParameter("@userName", UserName);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.String;

                parameters[1] = new SqlParameter("@userEmail", UserEmail);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.String;

                parameters[2] = new SqlParameter("@userPhone", UserPhone);
                parameters[2].Direction = ParameterDirection.Input;
                parameters[2].DbType = DbType.String;

                parameters[3] = new SqlParameter("@userLocation", UserLocation);
                parameters[3].Direction = ParameterDirection.Input;
                parameters[3].DbType = DbType.String;

                parameters[4] = new SqlParameter("@firstName", FirstName);
                parameters[4].Direction = ParameterDirection.Input;
                parameters[4].DbType = DbType.String;

                parameters[5] = new SqlParameter("@lastName", LastName);
                parameters[5].Direction = ParameterDirection.Input;
                parameters[5].DbType = DbType.String;

                parameters[6] = new SqlParameter("@password", Password);
                parameters[6].Direction = ParameterDirection.Input;
                parameters[6].DbType = DbType.String;

                parameters[7] = new SqlParameter("@isAdmin", IsAdmin);
                parameters[7].Direction = ParameterDirection.Input;
                parameters[7].DbType = DbType.Int32;

                parameters[8] = new SqlParameter("@userStatus", UserStatus);
                parameters[8].Direction = ParameterDirection.Input;
                parameters[8].DbType = DbType.Int32;

                parameters[9] = new SqlParameter("@userImage", UserImage);
                parameters[9].Direction = ParameterDirection.Input;
                parameters[9].DbType = DbType.String;

                Ado.ExecuteNonQueryStoredProcedure("sp_AddNewUser", parameters);
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

        public void updateUser()
        {
            DbParameter[] parameters = new DbParameter[10];
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;

                parameters[1] = new SqlParameter("@userName", userName);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.String;

                parameters[2] = new SqlParameter("@userEmail", userEmail);
                parameters[2].Direction = ParameterDirection.Input;
                parameters[2].DbType = DbType.String;

                parameters[3] = new SqlParameter("@userPhone", userPhone);
                parameters[3].Direction = ParameterDirection.Input;
                parameters[3].DbType = DbType.String;

                parameters[4] = new SqlParameter("@userLocation", userLocation);
                parameters[4].Direction = ParameterDirection.Input;
                parameters[4].DbType = DbType.String;

                parameters[5] = new SqlParameter("@firstName", firstName);
                parameters[5].Direction = ParameterDirection.Input;
                parameters[5].DbType = DbType.String;

                parameters[6] = new SqlParameter("@lastName", lastName);
                parameters[6].Direction = ParameterDirection.Input;
                parameters[6].DbType = DbType.String;

                parameters[7] = new SqlParameter("@password", password);
                parameters[7].Direction = ParameterDirection.Input;
                parameters[7].DbType = DbType.String;

                parameters[8] = new SqlParameter("@isAdmin", isAdmin);
                parameters[8].Direction = ParameterDirection.Input;
                parameters[8].DbType = DbType.Int32;

                parameters[9] = new SqlParameter("@userStatus", userStatus);
                parameters[9].Direction = ParameterDirection.Input;
                parameters[9].DbType = DbType.Int32;
                
                Ado.ExecuteNonQueryStoredProcedure("sp_UpdateUser", parameters);
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
        
        public DataTable getUsersForLogin(string userName)
        {
            DbParameter[] parameters = new DbParameter[1];
            DataTable dtUser = new DataTable();
            try
            {
                parameters[0] = new SqlParameter("@userName", userName);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.String;
                dtUser = Ado.ExecuteStoredProcedure("sp_GetUsersForLogin", parameters);
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

        public void updatePassword(string OldPassword)
        {
            DbParameter[] parameters = new DbParameter[3];
            try
            {
                parameters[0] = new SqlParameter("@guid", guid);
                parameters[0].Direction = ParameterDirection.Input;
                parameters[0].DbType = DbType.Guid;

                parameters[1] = new SqlParameter("@password", password);
                parameters[1].Direction = ParameterDirection.Input;
                parameters[1].DbType = DbType.String;

                parameters[2] = new SqlParameter("@oldpassword", OldPassword);
                parameters[2].Direction = ParameterDirection.Input;
                parameters[2].DbType = DbType.String;

                Ado.ExecuteNonQueryStoredProcedure("sp_UpdatePassword", parameters);
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