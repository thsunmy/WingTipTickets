//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tenant.Mvc.Core.Contexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class TicketLevel
    {
        public int TicketLevelId { get; set; }
        public string TicketLevel1 { get; set; }
        public string Description { get; set; }
        public Nullable<int> SeatSectionId { get; set; }
        public Nullable<int> ConcertId { get; set; }
        public Nullable<decimal> TicketPrice { get; set; }
    }
}
