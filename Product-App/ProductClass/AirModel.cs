//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProductClass
{
    using System;
    using System.Collections.Generic;
    
    public partial class AirModel
    {
        public int ID { get; set; }
        public string AirName { get; set; }
        public Nullable<int> AirPrice { get; set; }
        public string AirArrivalDate { get; set; }
        public string AirArrivalTime { get; set; }
        public string AirDepartureDate { get; set; }
        public string AirDepartureTime { get; set; }
        public string AirSource { get; set; }
        public string AirDestination { get; set; }
        public string isBooked { get; set; }
        public string isSaved { get; set; }
    }
}
