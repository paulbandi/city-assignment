using System;
using System.Collections.Generic;
using System.Text;

namespace City
{
    class Buildings
    {
        public string BuildingName { get; set; }
        public string BuildingType { get; set; }
        public string BuildingDimensions{ get; set; }

        public Buildings(string buildingName, string buildingType, string buildingDimensions)
        {
            BuildingName = buildingName;
            BuildingType = buildingType;
            BuildingDimensions = buildingDimensions;
        }
    }
}