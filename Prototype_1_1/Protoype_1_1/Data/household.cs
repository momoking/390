//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prototype1_1.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class household
    {
        public household()
        {
            this.client = new HashSet<client>();
            this.flag = new HashSet<flag>();
            this.note = new HashSet<note>();
            this.slot = new HashSet<slot>();
        }
    
        public long HouseholdID { get; set; }
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string AppartmentNumber { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<System.DateTime> FirstVisit { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
        public Nullable<System.DateTime> NextUpdate { get; set; }
        public Nullable<decimal> HouseholdIncome { get; set; }
    
        public virtual ICollection<client> client { get; set; }
        public virtual ICollection<flag> flag { get; set; }
        public virtual ICollection<note> note { get; set; }
        public virtual ICollection<slot> slot { get; set; }
    }
}