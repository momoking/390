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
    
    public partial class slottemplate
    {
        public slottemplate()
        {
            this.eventtemplate = new HashSet<eventtemplate>();
        }
    
        public long SlotID { get; set; }
        public Nullable<long> Capacity { get; set; }
        public Nullable<long> Booked { get; set; }
        public Nullable<long> Duration { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
    
        public virtual ICollection<eventtemplate> eventtemplate { get; set; }
    }
}
