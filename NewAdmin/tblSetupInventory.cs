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
    
    public partial class tblSetupInventory
    {
        public int TenentID { get; set; }
        public int locationID { get; set; }
        public string TransferOutTransType { get; set; }
        public string TransferOutTransSubType { get; set; }
        public string TransferInTransType { get; set; }
        public string TransferInTransSubType { get; set; }
        public string ConsumeTransType { get; set; }
        public string ConsumeTransSubType { get; set; }
        public Nullable<int> transidOut { get; set; }
        public Nullable<int> transsubidOut { get; set; }
        public Nullable<int> transidin { get; set; }
        public Nullable<int> transsubidIn { get; set; }
        public Nullable<int> transidConsume { get; set; }
        public Nullable<int> transsubidConsume { get; set; }
        public string MYSYSNAMEOut { get; set; }
        public string MYSYSNAMEIn { get; set; }
        public Nullable<bool> StockTeking { get; set; }
        public Nullable<bool> StockTakingPeriodBegin { get; set; }
        public Nullable<bool> StockTakingPeriodEnd { get; set; }
        public string StockTakingTransTypeIn { get; set; }
        public string StockTakingTransTypeOut { get; set; }
        public string StockTakingTransSubTypeIn { get; set; }
        public string StockTakingTransSubTypeOut { get; set; }
        public Nullable<int> StockTakingtransidInLast { get; set; }
        public Nullable<int> StockTakingtransidOutLast { get; set; }
        public Nullable<int> DefaultCUSTVENDID { get; set; }
        public Nullable<int> Created { get; set; }
        public Nullable<System.DateTime> DateTime { get; set; }
        public Nullable<bool> Active { get; set; }
        public Nullable<bool> Deleted { get; set; }
    }
}
