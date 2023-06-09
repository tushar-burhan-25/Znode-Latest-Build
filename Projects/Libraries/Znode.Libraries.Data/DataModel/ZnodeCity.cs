//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Znode.Libraries.Data.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class ZnodeCity : ZnodeEntityBaseModel
    {
        public int CityID { get; set; }
        public string CityName { get; set; }
        public string CityType { get; set; }
        public string ZIP { get; set; }
        public string ZIPType { get; set; }
        public string CountyCode { get; set; }
        public string CountryCode { get; set; }
        public string StateCode { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string CountyFIPS { get; set; }
        public string StateFIPS { get; set; }
        public string MSACode { get; set; }
        public string TimeZone { get; set; }
        public Nullable<decimal> UTC { get; set; }
        public string DST { get; set; }
        public int CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int ModifiedBy { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
