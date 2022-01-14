using System;


namespace Infrastructure
{
    public class Global
    {
        public GlobalCountryInfo globalCountryInfo {get; set;}
        public GlobalWorldInfo globalWorldInfo {get; set;}

        public Global(GlobalCountryInfo globalCountryInfo, GlobalWorldInfo globalWorldInfo)
        {
            this.globalCountryInfo = globalCountryInfo;
            this.globalWorldInfo = globalWorldInfo;
        }
    } 
}
