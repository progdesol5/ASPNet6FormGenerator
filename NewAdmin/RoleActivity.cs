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
    
    public partial class RoleActivity
    {
        public long ActivityID { get; set; }
        public int Role_ID { get; set; }
        public int Node_ID { get; set; }
        public bool ActivityAdd { get; set; }
        public bool ActivityUpdate { get; set; }
        public bool ActivityDelete { get; set; }
        public bool ActivityView { get; set; }
        public bool ActivityPrint { get; set; }
        public int User_ID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> TenentID { get; set; }
    }
}
