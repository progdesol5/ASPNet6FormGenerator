//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_UserLogin
    {
        public int ID { get; set; }
        public int TenentID { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        public string Password3 { get; set; }
        public string ForgottenPassword { get; set; }
        public Nullable<bool> Blocked { get; set; }
        public Nullable<int> Attempts { get; set; }
        public string OTP { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
