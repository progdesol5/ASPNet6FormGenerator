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
    
    public partial class tbl_Category
    {
        public int CategoryID { get; set; }
        public Nullable<int> AppID { get; set; }
        public string CategoryText { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
