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
    
    public partial class warehouse_product
    {
        public int product_ID { get; set; }
        public int warehouse_ID { get; set; }
        public int sector_ID { get; set; }
        public int qty { get; set; }
        public System.DateTime store_date { get; set; }
    
        public virtual product product { get; set; }
        public virtual warehouse warehouse { get; set; }
    }
}
