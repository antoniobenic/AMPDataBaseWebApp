using System;
using System.Collections.Generic;

namespace AMPDataBaseWebApp.Models
{
    public partial class AtmPressParsing
    {
        public short Id { get; set; }
        public int[] Max { get; set; }
        public int[] Min { get; set; }
        public int[] Current { get; set; }
        public int[] MaxTime { get; set; }
        public int[] MinTime { get; set; }
        public string Extension { get; set; }
    }
}
