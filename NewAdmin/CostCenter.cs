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
    
    public partial class CostCenter
    {
        public int TenentID { get; set; }
        public int locationID { get; set; }
        public int CostCenterID { get; set; }
        public Nullable<int> CostCenterNumber { get; set; }
        public string CostCenterName { get; set; }
        public string ArabicCostCenterName { get; set; }
        public string OtherCostCenterName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<long> crupid { get; set; }
    }
}
