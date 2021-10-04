using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Infrastructure
{
    public class Country
    {
        public CountryStatesInfo countryStatesInfo {get; set;}

        public Country(CountryStatesInfo countryStatesInfo)
        {
            this.countryStatesInfo = countryStatesInfo;
        }
    }
}
