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
    
    public partial class customer
    {
        public customer()
        {
            this.buyorders = new HashSet<buyorder>();
            this.reservations = new HashSet<reservation>();
        }
    
        public int user_ID { get; set; }
        public string name { get; set; }
        public int phone_No { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> create_date { get; set; }
    
        public virtual ICollection<buyorder> buyorders { get; set; }
        public virtual ICollection<reservation> reservations { get; set; }
    }
}
