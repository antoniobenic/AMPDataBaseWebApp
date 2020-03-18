using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class GeoHumidity
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan? MinTime { get; set; }
        public TimeSpan? MaxTime { get; set; }
        public int? Max { get; set; }
        public int? Avg { get; set; }
        public int? Min { get; set; }
        public int? Current { get; set; }
        public short FkStationId { get; set; }
        public long Id { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
