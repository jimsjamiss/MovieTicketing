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
    
    public partial class movieShows
    {
        public movieShows()
        {
            this.movieTicketing = new HashSet<movieTicketing>();
        }
    
        public int movieId { get; set; }
        public string moviName { get; set; }
        public string movieType { get; set; }
        public string movieDate { get; set; }
        public string movieHour { get; set; }
        public Nullable<decimal> moviePrice { get; set; }
    
        public virtual ICollection<movieTicketing> movieTicketing { get; set; }
    }
}
