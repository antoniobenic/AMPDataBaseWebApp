using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class RadiationParsing
    {
        public short Id { get; set; }
        public int[] Global { get; set; }
        public int[] Uvb { get; set; }
        public int[] Diffuse { get; set; }
        public int[] SunDuration { get; set; }
        public short FkStationId { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
