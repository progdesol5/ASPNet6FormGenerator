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
    
    public partial class tblCourierImport
    {
        public int ID { get; set; }
        public string HAWB { get; set; }
        public string ShipmentType { get; set; }
        public string ShipperName { get; set; }
        public string ShipperCompany { get; set; }
        public string ShipperContact_Department { get; set; }
        public string ShipperAddressType { get; set; }
        public string ShipperCountry { get; set; }
        public string ShipperArea { get; set; }
        public string ShipperCity { get; set; }
        public string ShipperBlock { get; set; }
        public string ShipperStreet { get; set; }
        public string ShipperAvenue { get; set; }
        public string ShipperHouse_No { get; set; }
        public string Shipper_EMail { get; set; }
        public string ShipperPostCode { get; set; }
        public string ShipperPACINumber { get; set; }
        public string ShipperMobileNumber1 { get; set; }
        public string ShipperMobileNumber2 { get; set; }
        public string ReceiverName { get; set; }
        public string ReceiverCompany { get; set; }
        public string ReceiverContact_Department { get; set; }
        public string ReceiverAddressType { get; set; }
        public string ReceiverCountry { get; set; }
        public string ReceiverArea { get; set; }
        public string ReceiverCity { get; set; }
        public string ReceiverBlock { get; set; }
        public string ReceiverStreet { get; set; }
        public string ReceiverAvenue { get; set; }
        public string ReceiverHouse_No { get; set; }
        public string Receiver_EMail { get; set; }
        public string ReceiverPostCode { get; set; }
        public string ReceiverPACINumber { get; set; }
        public string ReceiverMobileNumber1 { get; set; }
        public string ReceiverMobileNumber2 { get; set; }
        public string ShipmentContent { get; set; }
        public string PackagingType { get; set; }
        public string Packaging { get; set; }
        public string Quantity { get; set; }
        public string Weights { get; set; }
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string Packaging2 { get; set; }
        public string Quantity2 { get; set; }
        public string Length2 { get; set; }
        public string Weight2 { get; set; }
        public string Height2 { get; set; }
        public string Packaging3 { get; set; }
        public string Quantity3 { get; set; }
        public string Length3 { get; set; }
        public string Weight3 { get; set; }
        public string Height3 { get; set; }
        public string Invoice { get; set; }
        public string Value { get; set; }
        public string COD_Amount { get; set; }
        public string Other_Charges { get; set; }
        public string Total_Charges { get; set; }
        public string Prefered_Schedule_Type { get; set; }
        public string Preferred_Pickup_Window { get; set; }
        public string Preferred_Delivery_Window { get; set; }
        public Nullable<System.DateTime> ImportDate { get; set; }
        public string Status { get; set; }
        public string Error { get; set; }
        public Nullable<int> CreatedBy { get; set; }
    }
}
