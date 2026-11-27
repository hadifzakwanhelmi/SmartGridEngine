using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FreeSql.DataAnnotations;

namespace SmartGridEngine.Data
{
    public class PowerSourceRecord
    {
        [Column(IsPrimary = true)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string SourceType { get; set; }   // "Solar" | "Wind" | "Battery"
        public double CapacityKw { get; set; }
        public double CurrentOutputKw { get; set; }
        public bool IsActive { get; set; }

        // Solar only
        public double? PanelEfficiency { get; set; }
        public double? SunlightLux { get; set; }
        // Wind only
        public double? WindSpeedKms { get; set; }
        public double? BladeLengthM { get; set; }
        // Battery only
        public double? MaxCapacityKwh { get; set; }
        public double? CurrentCharge { get; set; }
    }
}