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
    
    public partial class Tbl_Applicant_Reference
    {
        public int AppId { get; set; }
        public int ReferenceId { get; set; }
        public int LocID { get; set; }
        public string RefName { get; set; }
        public string RefCName { get; set; }
        public string RefTitle { get; set; }
        public Nullable<decimal> RefPhone { get; set; }
        public string RefMail { get; set; }
        public Nullable<bool> ActivedBy { get; set; }
        public Nullable<bool> DeletedBy { get; set; }
        public Nullable<int> ResumeID { get; set; }
        public string Statuse { get; set; }
    }
}