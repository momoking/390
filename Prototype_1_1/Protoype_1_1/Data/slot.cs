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
    
    public partial class slot
    {
        public slot()
        {
            this.@event = new HashSet<@event>();
            this.household = new HashSet<household>();
        }
    
        public long SlotID { get; set; }
        public Nullable<long> Capacity { get; set; }
        public Nullable<long> Booked { get; set; }
        public Nullable<long> Duration { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
    
        public virtual ICollection<@event> @event { get; set; }
        public virtual ICollection<household> household { get; set; }

        public override string ToString()
        {
            DateTime endTime = StartTime.Value.AddMinutes(Duration.Value);
            return StartTime.Value.Hour + ":" + StartTime.Value.Minute + " - " + endTime.Hour + ":" + endTime.Minute + ". Capacity: " + Capacity + ". Booked: " + Booked;
        }
    }
}
