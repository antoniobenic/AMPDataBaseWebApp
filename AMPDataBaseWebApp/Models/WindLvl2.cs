using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class WindLvl2
    {
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public TimeSpan? MaxSpeedTime { get; set; }
        public short FkStationId { get; set; }
        public decimal? MaxSpeed { get; set; }
        public decimal? AvgSpeed { get; set; }
        public decimal? CurrentSpeed { get; set; }
        public int? MaxDirection { get; set; }
        public int? AvgDirection { get; set; }
        public int? CurrentDirection { get; set; }
        public long Id { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
