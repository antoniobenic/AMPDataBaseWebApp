using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class Precipitation
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public decimal? Sum { get; set; }
        public decimal? FirstFiveMin { get; set; }
        public decimal? SecondFiveMin { get; set; }
        public bool? IsStationWorking { get; set; }
        public short FkStationId { get; set; }
        public long Id { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
