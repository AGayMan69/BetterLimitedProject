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
    
    public partial class replenishment
    {
        public replenishment()
        {
            this.replenishment_product = new HashSet<replenishment_product>();
        }
    
        public int delivery_ID { get; set; }
        public int salesID { get; set; }
        public int store_ID { get; set; }
        public Nullable<System.DateTime> request_date { get; set; }
    
        public virtual delivery delivery { get; set; }
        public virtual ICollection<replenishment_product> replenishment_product { get; set; }
        public virtual staff staff { get; set; }
        public virtual retail_store retail_store { get; set; }
    }
}
