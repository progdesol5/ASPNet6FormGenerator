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
    
    public partial class country
    {
        public int id { get; set; }
        public string name { get; set; }
        public string iso3 { get; set; }
        public string numeric_code { get; set; }
        public string iso2 { get; set; }
        public string phonecode { get; set; }
        public string capital { get; set; }
        public string currency { get; set; }
        public string currency_symbol { get; set; }
        public string tld { get; set; }
        public string native { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
        public string timezones { get; set; }
        public string translations { get; set; }
        public Nullable<decimal> latitude { get; set; }
        public Nullable<decimal> longitude { get; set; }
        public Nullable<int> state_id { get; set; }
        public string emoji { get; set; }
        public string emojiU { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
        public Nullable<System.DateTime> updated_at { get; set; }
        public Nullable<int> flag { get; set; }
        public string wikiDataId { get; set; }
    }
}
