using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class SeatemperatureParsing
    {
        public short Id { get; set; }
        public int[] Avg { get; set; }
        public int[] Current { get; set; }
        public short? FkStationId { get; set; }
        public string StartName { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
