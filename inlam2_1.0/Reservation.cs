//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace inlam2_1._0
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        public int ReservationID { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int CustomerID { get; set; }
        public int ReservationRoomsID { get; set; }
        public int PaymentID { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Payment Payment { get; set; }
        public virtual ReservationRoom ReservationRoom { get; set; }
    }
}
