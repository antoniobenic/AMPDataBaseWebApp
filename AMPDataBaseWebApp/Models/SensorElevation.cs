using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class SensorElevation
    {
        public short FkStationId { get; set; }
        public int? WindLvl1 { get; set; }
        public int? WindLvl2 { get; set; }
        public int? AirTemp2m { get; set; }
        public int? AirTemp5cm { get; set; }
        public int? GeoTemp5cm { get; set; }
        public int? GeoTemp10cm { get; set; }
        public int? GeoTemp20cm { get; set; }
        public int? AtmPressure { get; set; }
        public int? GenericElevation { get; set; }
        public short Id { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
