//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BetterLimitedProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class installation
    {
        public installation()
        {
            this.installation_assignment = new HashSet<installation_assignment>();
        }
    
        public int installation_ID { get; set; }
        public Nullable<int> installation_type { get; set; }
        public Nullable<System.DateTime> installation_date { get; set; }
        public int delivery_ID { get; set; }
        public int order_ID { get; set; }
        public Nullable<int> assignment_ID { get; set; }
    
        public virtual buyorder buyorder { get; set; }
        public virtual delivery delivery { get; set; }
        public virtual ICollection<installation_assignment> installation_assignment { get; set; }
    }
}
