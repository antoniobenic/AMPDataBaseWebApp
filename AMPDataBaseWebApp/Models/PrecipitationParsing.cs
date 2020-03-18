using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class PrecipitationParsing
    {
        public short Id { get; set; }
        public int[] Sum { get; set; }
        public int[] FirstFiveMin { get; set; }
        public int[] SecondFiveMin { get; set; }
    }
}
