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
    
    public partial class tblWishList
    {
        public int WL_ID { get; set; }
        public Nullable<int> WL_UserID { get; set; }
        public Nullable<int> WL_Name { get; set; }
        public string WL_Description { get; set; }
        public Nullable<System.DateTime> WL_DateTimeAdded { get; set; }
        public Nullable<System.DateTime> WL_LastUpdated { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
    }
}