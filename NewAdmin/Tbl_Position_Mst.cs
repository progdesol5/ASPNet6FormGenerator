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
    
    public partial class Tbl_Position_Mst
    {
        public int TenentID { get; set; }
        public int PositionID { get; set; }
        public string PositionName { get; set; }
        public string PositionNameAR { get; set; }
        public string PositionNameFR { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
    }
}
