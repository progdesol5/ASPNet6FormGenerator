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
    
    public partial class MODULE_MST
    {
        public int TenentID { get; set; }
        public int Module_Id { get; set; }
        public string MYSYSNAME { get; set; }
        public string Module_Name { get; set; }
        public string Module_NameO { get; set; }
        public string Module_NameT { get; set; }
        public string Module_Desc { get; set; }
        public Nullable<int> Parent_Module_id { get; set; }
        public Nullable<int> Module_Order { get; set; }
        public string ACTIVE_FLAG { get; set; }
        public long CRUP_ID { get; set; }
        public string Module_Location { get; set; }
        public Nullable<bool> ACTIVEMODULE { get; set; }
        public Nullable<System.DateTime> MODULEDATE { get; set; }
        public string AppVer { get; set; }
        public Nullable<System.DateTime> AppVerDate { get; set; }
        public string DBVer { get; set; }
        public Nullable<System.DateTime> DBVerDate { get; set; }
        public string AppDownLoadURL { get; set; }
        public string ConStr { get; set; }
    }
}
