using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class RadiationMetaData
    {
        public short Id { get; set; }
        public short? FkStationId { get; set; }
        public string LocalisedName { get; set; }
        public string Extension { get; set; }
        public short? SensorHeight { get; set; }
        public string InputTable { get; set; }
        public string TargetTableName { get; set; }

        public virtual Station FkStation { get; set; }
    }
}
