//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MovieTicketing.AppData
{
    using System;
    using System.Collections.Generic;
    
    public partial class customerInfo
    {
        public customerInfo()
        {
            this.payment = new HashSet<payment>();
        }
    
        public int custId { get; set; }
        public string custName { get; set; }
        public string custAddress { get; set; }
        public string custPhone { get; set; }
        public string custEmail { get; set; }
        public string custPass { get; set; }
    
        public virtual ICollection<payment> payment { get; set; }
    }
}
