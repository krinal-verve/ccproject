//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CottageCareOnlinePricing.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class PostalCode
    {
        public long ID { get; set; }
        public string City { get; set; }
        public string StateName { get; set; }
        public string Code { get; set; }
        public string Country { get; set; }
        public Nullable<decimal> TaxRate1 { get; set; }
        public Nullable<decimal> TaxRate2 { get; set; }
        public Nullable<decimal> TaxRate3 { get; set; }
        public Nullable<bool> Service { get; set; }
        public Nullable<bool> AdditionalMilage { get; set; }
        public Nullable<decimal> AdditionalMilageAmount { get; set; }
        public Nullable<decimal> ServiceCenter { get; set; }
        public long CompanyID { get; set; }
    }
}
