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
    
    public partial class tbl_route_Dtl
    {
        public int TenentID { get; set; }
        public int LocationID { get; set; }
        public string RouteID { get; set; }
        public int SeqNo { get; set; }
        public string SeqName1 { get; set; }
        public string SeqName2 { get; set; }
        public string SeqName3 { get; set; }
        public int NextSeqNo { get; set; }
        public int CompID { get; set; }
        public string EmpID { get; set; }
        public string DeptID { get; set; }
        public string SubmitGroup { get; set; }
        public string SubmitBy { get; set; }
        public Nullable<System.DateTime> Submitdate { get; set; }
        public string SignGroup { get; set; }
        public string SignBy { get; set; }
        public Nullable<System.DateTime> Signdate { get; set; }
        public string RecGroup { get; set; }
        public string RecBy { get; set; }
        public Nullable<System.DateTime> Recdate { get; set; }
        public string RecSignGroup { get; set; }
        public string RecSignBy { get; set; }
        public Nullable<System.DateTime> RecSigndate { get; set; }
        public int ACTIVITYCODE { get; set; }
        public int Days2Complete { get; set; }
        public Nullable<bool> Active { get; set; }
        public string FieldID { get; set; }
        public string Version { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> CrupId { get; set; }
        public string MyStatus { get; set; }
        public Nullable<int> User { get; set; }
        public Nullable<bool> PrintSignYes { get; set; }
        public Nullable<int> PrintSignSeq { get; set; }
        public Nullable<bool> RecYes { get; set; }
        public string FieldName { get; set; }
        public string ScreenName { get; set; }
        public string DefaultValue { get; set; }
        public Nullable<int> FromColumn { get; set; }
        public Nullable<int> ToColumn { get; set; }
        public Nullable<int> REFFID { get; set; }
        public Nullable<int> recCompid { get; set; }
    }
}