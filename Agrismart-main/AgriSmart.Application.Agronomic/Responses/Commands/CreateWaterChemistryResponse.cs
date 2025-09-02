﻿namespace AgriSmart.Application.Agronomic.Responses.Commands
{
    public record CreateWaterChemistryResponse
    {
        public int Id { get; set; }
        public int WaterId { get; set; }
        public double Ca { get; set; }
        public double K { get; set; }
        public double Mg { get; set; }
        public double Na { get; set; }
        public double NH4 { get; set; }
        public double Fe { get; set; }
        public double Cu { get; set; }
        public double Mn { get; set; }
        public double Zn { get; set; }
        public double NO3 { get; set; }
        public double SO4 { get; set; }
        public double Cl { get; set; }
        public double B { get; set; }
        public double H2PO4 { get; set; }
        public double HCO3 { get; set; }
        public double BO4 { get; set; }
        public double MOO4 { get; set; }
        public double EC { get; set; }
        public double pH { get; set; }
        public DateTime AnalysisDate { get; set; }
        public bool Active { get; set; }
    }
}