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
    
    public partial class replenishment_product
    {
        public int product_ID { get; set; }
        public int delivery_ID { get; set; }
        public int qty { get; set; }
    
        public virtual product product { get; set; }
        public virtual replenishment replenishment { get; set; }
    }
}
