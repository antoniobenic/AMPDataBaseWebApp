using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class WindLvl2Parsing
    {
        public int[] MaxSpeed { get; set; }
        public int[] AvgSpeed { get; set; }
        public int[] CurrentSpeed { get; set; }
        public int[] MaxDirection { get; set; }
        public int[] AvgDirection { get; set; }
        public int[] CurrentDirection { get; set; }
        public int[] MaxSpeedTime { get; set; }
        public short Id { get; set; }
        public string Extension { get; set; }
        public short FkStationId { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
