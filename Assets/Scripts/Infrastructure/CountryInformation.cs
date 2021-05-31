using System;


namespace Infrastructure
{
    public class CountryInformation
    {
        public StateInformation[] statesChildren{get; set;}
        public int totalDeaths {get; set;}
        public int totalTested {get; set;}
        public int totalPositives {get; set;}
    } 
}
