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
    
    public partial class EmailTemplate
    {
        public int Id { get; set; }
        public string TemplateTitle { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
    }
}
