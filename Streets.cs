using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Streets
    {
        public string StreetName { get; set; }
        public int StreetNumber { get; set; }

        public Streets(string streetName, int streetNumber)
        {
            StreetName = streetName;
            StreetNumber = streetNumber;
        }
    }
}