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
    
    public partial class flag
    {
        public flag()
        {
            this.household = new HashSet<household>();
        }
    
        public long ID { get; set; }
        public Nullable<long> FlagTypeID { get; set; }
        public string FlagInfo { get; set; }
        public Nullable<System.DateTime> DateStamp { get; set; }
    
        public virtual flagtype flagtype { get; set; }
        public virtual ICollection<household> household { get; set; }
    }
}
