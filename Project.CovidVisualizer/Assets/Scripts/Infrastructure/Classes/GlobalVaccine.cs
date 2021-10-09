using System;


namespace Infrastructure
{
    public class GlobalVaccine
    {
        public long worldTotalOneDosis {get; set;}
        public long worldTotalTwoDosis {get; set;}
        public float worldPercentagePopulation {get; set;}

        public long countryTotalOneDosis {get; set;}
        public long countryTotalTwoDosis {get; set;}
        public float countryPercentagePopulation {get; set;}
    } 
}
