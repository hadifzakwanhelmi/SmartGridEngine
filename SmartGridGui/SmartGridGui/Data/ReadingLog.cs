using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FreeSql.DataAnnotations;

namespace SmartGridEngine.Data
{
    public class ReadingLog
    {
        [Column(IsIdentity = true, IsPrimary = true)]
        public int Id { get; set; }
        public DateTime Timestamp { get; set; }
        public double TotalGenerationKw { get; set; }
        public double DemandKw { get; set; }
        public bool IsStable { get; set; }
    }
}