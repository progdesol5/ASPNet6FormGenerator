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
    
    public partial class tblAirWayMain
    {
        public int TranID { get; set; }
        public string TranNo { get; set; }
        public System.DateTime TranDate { get; set; }
        public string TranType { get; set; }
        public int CustomerKey { get; set; }
        public string CompanyName { get; set; }
        public Nullable<int> DepartmentKey { get; set; }
        public int AddressKey { get; set; }
        public int ReciverKey { get; set; }
        public string ReciverKeyCompanyName { get; set; }
        public Nullable<int> ReciverDepartmentKey { get; set; }
        public int ReciverAddressKey { get; set; }
        public Nullable<int> PackingTypeKey { get; set; }
        public string InvoiceType { get; set; }
        public string Attachment1 { get; set; }
        public string Attachment2 { get; set; }
        public string ShipmentDescription { get; set; }
        public string ShipmentPurpose { get; set; }
        public string ShipmentRefrence { get; set; }
        public string ExportType { get; set; }
        public string ReasonForExport { get; set; }
        public string PlaceOfDestination { get; set; }
        public Nullable<int> CustomerOfTrade { get; set; }
        public string PaymentTerms { get; set; }
        public string PickupType { get; set; }
        public string PickupWindow { get; set; }
        public string Deliverytype { get; set; }
        public string DeliveryWindow { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<int> ModifiedBy { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        public int CompanyID { get; set; }
        public Nullable<int> VendorKey { get; set; }
        public Nullable<int> DriverKey { get; set; }
        public Nullable<int> ID { get; set; }
        public Nullable<int> VehicleKey { get; set; }
    }
}
