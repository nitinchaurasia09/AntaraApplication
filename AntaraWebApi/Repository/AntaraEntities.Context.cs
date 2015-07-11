﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntaraWebApi.Repository
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AntaraEntities : DbContext
    {
        public AntaraEntities()
            : base("name=AntaraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<user_master> user_master { get; set; }
        public virtual DbSet<page_image_text_master> page_image_text_master { get; set; }
        public virtual DbSet<page_master> page_master { get; set; }
        public virtual DbSet<youtube_master> youtube_master { get; set; }
    
        public virtual int DeleteYouTubeUrls()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteYouTubeUrls");
        }
    
        public virtual int sp_AddNewUser(string userName, string userEmail, string userPhone, string userLocation, string firstName, string lastName, string password, Nullable<short> isAdmin, string userImage, Nullable<short> userStatus)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userPhoneParameter = userPhone != null ?
                new ObjectParameter("userPhone", userPhone) :
                new ObjectParameter("userPhone", typeof(string));
    
            var userLocationParameter = userLocation != null ?
                new ObjectParameter("userLocation", userLocation) :
                new ObjectParameter("userLocation", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("isAdmin", isAdmin) :
                new ObjectParameter("isAdmin", typeof(short));
    
            var userImageParameter = userImage != null ?
                new ObjectParameter("userImage", userImage) :
                new ObjectParameter("userImage", typeof(string));
    
            var userStatusParameter = userStatus.HasValue ?
                new ObjectParameter("userStatus", userStatus) :
                new ObjectParameter("userStatus", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_AddNewUser", userNameParameter, userEmailParameter, userPhoneParameter, userLocationParameter, firstNameParameter, lastNameParameter, passwordParameter, isAdminParameter, userImageParameter, userStatusParameter);
        }
    
        public virtual int sp_DeleteUser(Nullable<System.Guid> guid)
        {
            var guidParameter = guid.HasValue ?
                new ObjectParameter("guid", guid) :
                new ObjectParameter("guid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteUser", guidParameter);
        }
    
        public virtual ObjectResult<string> sp_generate_inserts(string table_name, string target_table, Nullable<bool> include_column_list, string from, Nullable<bool> include_timestamp, Nullable<bool> debug_mode, string owner, Nullable<bool> ommit_images, Nullable<bool> ommit_identity, Nullable<int> top, string cols_to_include, string cols_to_exclude, Nullable<bool> disable_constraints, Nullable<bool> ommit_computed_cols)
        {
            var table_nameParameter = table_name != null ?
                new ObjectParameter("table_name", table_name) :
                new ObjectParameter("table_name", typeof(string));
    
            var target_tableParameter = target_table != null ?
                new ObjectParameter("target_table", target_table) :
                new ObjectParameter("target_table", typeof(string));
    
            var include_column_listParameter = include_column_list.HasValue ?
                new ObjectParameter("include_column_list", include_column_list) :
                new ObjectParameter("include_column_list", typeof(bool));
    
            var fromParameter = from != null ?
                new ObjectParameter("from", from) :
                new ObjectParameter("from", typeof(string));
    
            var include_timestampParameter = include_timestamp.HasValue ?
                new ObjectParameter("include_timestamp", include_timestamp) :
                new ObjectParameter("include_timestamp", typeof(bool));
    
            var debug_modeParameter = debug_mode.HasValue ?
                new ObjectParameter("debug_mode", debug_mode) :
                new ObjectParameter("debug_mode", typeof(bool));
    
            var ownerParameter = owner != null ?
                new ObjectParameter("owner", owner) :
                new ObjectParameter("owner", typeof(string));
    
            var ommit_imagesParameter = ommit_images.HasValue ?
                new ObjectParameter("ommit_images", ommit_images) :
                new ObjectParameter("ommit_images", typeof(bool));
    
            var ommit_identityParameter = ommit_identity.HasValue ?
                new ObjectParameter("ommit_identity", ommit_identity) :
                new ObjectParameter("ommit_identity", typeof(bool));
    
            var topParameter = top.HasValue ?
                new ObjectParameter("top", top) :
                new ObjectParameter("top", typeof(int));
    
            var cols_to_includeParameter = cols_to_include != null ?
                new ObjectParameter("cols_to_include", cols_to_include) :
                new ObjectParameter("cols_to_include", typeof(string));
    
            var cols_to_excludeParameter = cols_to_exclude != null ?
                new ObjectParameter("cols_to_exclude", cols_to_exclude) :
                new ObjectParameter("cols_to_exclude", typeof(string));
    
            var disable_constraintsParameter = disable_constraints.HasValue ?
                new ObjectParameter("disable_constraints", disable_constraints) :
                new ObjectParameter("disable_constraints", typeof(bool));
    
            var ommit_computed_colsParameter = ommit_computed_cols.HasValue ?
                new ObjectParameter("ommit_computed_cols", ommit_computed_cols) :
                new ObjectParameter("ommit_computed_cols", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("sp_generate_inserts", table_nameParameter, target_tableParameter, include_column_listParameter, fromParameter, include_timestampParameter, debug_modeParameter, ownerParameter, ommit_imagesParameter, ommit_identityParameter, topParameter, cols_to_includeParameter, cols_to_excludeParameter, disable_constraintsParameter, ommit_computed_colsParameter);
        }
    
        public virtual ObjectResult<sp_GetAllPageImages_Result> sp_GetAllPageImages(Nullable<System.Guid> guid)
        {
            var guidParameter = guid.HasValue ?
                new ObjectParameter("guid", guid) :
                new ObjectParameter("guid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllPageImages_Result>("sp_GetAllPageImages", guidParameter);
        }
    
        public virtual ObjectResult<sp_GetAllUsers_Result> sp_GetAllUsers(Nullable<System.Guid> guid)
        {
            var guidParameter = guid.HasValue ?
                new ObjectParameter("guid", guid) :
                new ObjectParameter("guid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllUsers_Result>("sp_GetAllUsers", guidParameter);
        }
    
        public virtual ObjectResult<sp_GetAllYTlinks_Result> sp_GetAllYTlinks(Nullable<System.Guid> guid)
        {
            var guidParameter = guid.HasValue ?
                new ObjectParameter("guid", guid) :
                new ObjectParameter("guid", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetAllYTlinks_Result>("sp_GetAllYTlinks", guidParameter);
        }
    
        public virtual ObjectResult<sp_GetUsersForLogin_Result> sp_GetUsersForLogin(string userName)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_GetUsersForLogin_Result>("sp_GetUsersForLogin", userNameParameter);
        }
    
        public virtual int sp_UpdateUser(Nullable<System.Guid> guid, string userName, string userEmail, string userPhone, string userLocation, string firstName, string lastName, string password, Nullable<short> isAdmin, Nullable<short> userStatus)
        {
            var guidParameter = guid.HasValue ?
                new ObjectParameter("guid", guid) :
                new ObjectParameter("guid", typeof(System.Guid));
    
            var userNameParameter = userName != null ?
                new ObjectParameter("userName", userName) :
                new ObjectParameter("userName", typeof(string));
    
            var userEmailParameter = userEmail != null ?
                new ObjectParameter("userEmail", userEmail) :
                new ObjectParameter("userEmail", typeof(string));
    
            var userPhoneParameter = userPhone != null ?
                new ObjectParameter("userPhone", userPhone) :
                new ObjectParameter("userPhone", typeof(string));
    
            var userLocationParameter = userLocation != null ?
                new ObjectParameter("userLocation", userLocation) :
                new ObjectParameter("userLocation", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            var isAdminParameter = isAdmin.HasValue ?
                new ObjectParameter("isAdmin", isAdmin) :
                new ObjectParameter("isAdmin", typeof(short));
    
            var userStatusParameter = userStatus.HasValue ?
                new ObjectParameter("userStatus", userStatus) :
                new ObjectParameter("userStatus", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateUser", guidParameter, userNameParameter, userEmailParameter, userPhoneParameter, userLocationParameter, firstNameParameter, lastNameParameter, passwordParameter, isAdminParameter, userStatusParameter);
        }
    
        public virtual int UpdateYouTubeUrls(string youTubeLink, Nullable<short> numberOfTimeExecuted, string youTubeText)
        {
            var youTubeLinkParameter = youTubeLink != null ?
                new ObjectParameter("YouTubeLink", youTubeLink) :
                new ObjectParameter("YouTubeLink", typeof(string));
    
            var numberOfTimeExecutedParameter = numberOfTimeExecuted.HasValue ?
                new ObjectParameter("NumberOfTimeExecuted", numberOfTimeExecuted) :
                new ObjectParameter("NumberOfTimeExecuted", typeof(short));
    
            var youTubeTextParameter = youTubeText != null ?
                new ObjectParameter("YouTubeText", youTubeText) :
                new ObjectParameter("YouTubeText", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateYouTubeUrls", youTubeLinkParameter, numberOfTimeExecutedParameter, youTubeTextParameter);
        }
    }
}
