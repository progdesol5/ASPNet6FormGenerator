//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ShipmentItems
    {
        public int Id { get; set; }
        public Nullable<int> TenentID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string AirwayBillNo { get; set; }
        public Nullable<int> PackageRawID { get; set; }
        public Nullable<int> PackagingTypes { get; set; }
        public Nullable<int> PackageType { get; set; }
        public string ItemId { get; set; }
        public string Commodity { get; set; }
        public Nullable<int> Manufactured { get; set; }
        public string PackageDetails { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> myheight { get; set; }
        public Nullable<int> mywidth { get; set; }
        public Nullable<int> mypackagelength { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
