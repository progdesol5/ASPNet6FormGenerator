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
    
    public partial class FASLAccount
    {
        public int TenentID { get; set; }
        public int LocationId { get; set; }
        public string GLAccountID { get; set; }
        public string SLAccountID { get; set; }
        public Nullable<bool> Header { get; set; }
        public string MasterAccountID { get; set; }
        public string PredAccountID { get; set; }
        public string ConsolidationType { get; set; }
        public string GLSLType { get; set; }
        public string ActGroupId { get; set; }
        public int InternalGroupId { get; set; }
        public string SLAccountName1 { get; set; }
        public string SLAccountName2 { get; set; }
        public string SLAccountName3 { get; set; }
        public int ActType { get; set; }
        public int ActSubType { get; set; }
        public int AnalysisType { get; set; }
        public string DefaultCC { get; set; }
        public int OPAmount { get; set; }
        public int OPDrCr { get; set; }
        public long OPPERIOD_CODE { get; set; }
        public string Reference { get; set; }
        public string Remarks { get; set; }
        public int COMPID { get; set; }
        public int ContactMyID { get; set; }
        public string SWITCH1 { get; set; }
        public string SWITCH2 { get; set; }
        public string SWITCH3 { get; set; }
        public string ACTIVE { get; set; }
        public Nullable<System.DateTime> SyncDate { get; set; }
        public Nullable<long> CRUP_ID { get; set; }
    }
}
