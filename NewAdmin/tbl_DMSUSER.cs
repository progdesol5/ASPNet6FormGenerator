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
    
    public partial class tbl_DMSUSER
    {
        public int DMS_USER_ID { get; set; }
        public Nullable<int> COMP_ID { get; set; }
        public Nullable<bool> ADMIN { get; set; }
        public string SIGNATUREFILE { get; set; }
        public Nullable<bool> SIGNATURY { get; set; }
        public Nullable<int> GROUP_ID { get; set; }
        public Nullable<int> TenentID { get; set; }
        public string USER_ID { get; set; }
        public Nullable<int> MU_ID { get; set; }
        public Nullable<bool> IssueAlow { get; set; }
        public Nullable<bool> ReceivedAllow { get; set; }
        public Nullable<bool> Default { get; set; }
        public string ShortName { get; set; }
        public Nullable<bool> TransferAllow { get; set; }
    }
}
