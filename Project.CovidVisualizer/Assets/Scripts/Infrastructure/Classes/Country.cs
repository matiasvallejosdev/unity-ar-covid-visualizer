using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Infrastructure
{
    public class Country
    {
        public States statesData {get; set;}

        public Country(States countryStatesInfo)
        {
            this.statesData = countryStatesInfo;
        }
    }
}
