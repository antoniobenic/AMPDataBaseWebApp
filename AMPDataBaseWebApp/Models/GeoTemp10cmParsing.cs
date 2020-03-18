using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class GeoTemp10cmParsing
    {
        public short Id { get; set; }
        public short FkStationId { get; set; }
        public string Extension { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
