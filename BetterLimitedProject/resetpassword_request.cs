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
    
    public partial class resetpassword_request
    {
        public string request_code { get; set; }
        public int staff_ID { get; set; }
        public System.DateTime request_time { get; set; }
    
        public virtual staff staff { get; set; }
    }
}
