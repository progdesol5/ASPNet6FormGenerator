//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewAdmin
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_PublishDoc
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public int PublishID { get; set; }
        public Nullable<int> DMSID { get; set; }
        public string Topic { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public Nullable<bool> PublishAdmin { get; set; }
        public Nullable<bool> PublishSupervisior { get; set; }
        public Nullable<bool> PublishAllEmp { get; set; }
        public Nullable<System.DateTime> PublishDate { get; set; }
        public string Status { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
        public Nullable<int> crupid { get; set; }
    }
}
