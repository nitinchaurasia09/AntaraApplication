//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AntaraAPI.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class user_master
    {
        public string GUID { get; set; }
        public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserLocation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public short IsAdmin { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public short DeleteStatus { get; set; }
        public short UserStatus { get; set; }
        public string UserImage { get; set; }
    }
}
