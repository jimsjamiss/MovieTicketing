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
    
    public partial class movieTicketing
    {
        public int tckId { get; set; }
        public int custId { get; set; }
        public int movieId { get; set; }
        public string Venue { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> total { get; set; }
    
        public virtual movieShows movieShows { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
