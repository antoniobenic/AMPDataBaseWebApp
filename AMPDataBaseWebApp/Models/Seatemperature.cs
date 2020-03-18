using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class Seatemperature
    {
        public DateTime? Date { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal? Avg { get; set; }
        public decimal? Current { get; set; }
        public long Id { get; set; }
        public short? FkStationId { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
