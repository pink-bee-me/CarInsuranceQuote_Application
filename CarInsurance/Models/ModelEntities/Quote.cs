//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance.Models.ModelEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Quote
    {
        public int Quote_Id { get; set; }
        public int Insuree_Id { get; set; }
        public decimal BaseRate { get; set; }
        public Nullable<decimal> AgeUnder18 { get; set; }
        public Nullable<decimal> AgeBetween19and25 { get; set; }
        public Nullable<decimal> AgeOver25 { get; set; }
        public Nullable<decimal> VehicleYear_Before2000 { get; set; }
        public Nullable<decimal> VehicleYear_After2015 { get; set; }
        public Nullable<decimal> VehicleMake_Porsche { get; set; }
        public Nullable<decimal> VehicleModel_Carrera { get; set; }
        public Nullable<decimal> DUI { get; set; }
        public Nullable<decimal> SpeedingTickets { get; set; }
        public Nullable<decimal> CoverageType { get; set; }
        public Nullable<decimal> QuoteMonthlyRate { get; set; }
        public Nullable<decimal> QuoteYearlyRate { get; set; }
    }
}
