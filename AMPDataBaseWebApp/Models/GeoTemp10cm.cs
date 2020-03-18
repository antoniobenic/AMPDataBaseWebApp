using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class GeoTemp10cm
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public decimal? Max { get; set; }
        public decimal? Avg { get; set; }
        public decimal? Min { get; set; }
        public decimal? Current { get; set; }
        public TimeSpan? MaxTime { get; set; }
        public TimeSpan? MinTime { get; set; }
        public short? FkStationId { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
