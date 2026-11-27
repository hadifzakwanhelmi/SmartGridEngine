using SmartGridEngine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SmartGridEngine.Data
{
    public static class GridRepository
    {
        // PowerSource -> database row
        public static void SaveSource(PowerSource source)
        {
            var rec = new PowerSourceRecord
            {
                Id = source.Id,
                Name = source.Name,
                CapacityKw = source.CapacityKw,
                CurrentOutputKw = source.CurrentOutputKw,
                IsActive = source.IsActive
            };

            var solar = source as SolarPanel;
            var wind = source as WindTurbine;
            var battery = source as BatteryStorageSystem;
            if (solar != null)
            {
                rec.SourceType = "Solar";
                rec.PanelEfficiency = solar.PanelEfficiency;
                rec.SunlightLux = solar.SunlightLux;
            }
            else if (wind != null)
            {
                rec.SourceType = "Wind";
                rec.WindSpeedKms = wind.WindSpeedKms;
                rec.BladeLengthM = wind.BladeLengthM;
            }
            else if (battery != null)
            {
                rec.SourceType = "Battery";
                rec.MaxCapacityKwh = battery.MaxCapacityKwh;
                rec.CurrentCharge = battery.CurrentCharge;
            }

            SmartGridDb.Instance.InsertOrUpdate<PowerSourceRecord>().SetSource(rec).ExecuteAffrows();
        }

        public static void DeleteSource(string id)
        {
            SmartGridDb.Instance.Delete<PowerSourceRecord>().Where(r => r.Id == id).ExecuteAffrows();
        }

        // database rows -> PowerSource objects (rebuilds the correct subclass)
        public static List<PowerSource> LoadAllSources()
        {
            var rows = SmartGridDb.Instance.Select<PowerSourceRecord>().ToList();
            var result = new List<PowerSource>();
            foreach (var r in rows)
            {
                PowerSource s = null;
                if (r.SourceType == "Solar")
                    s = new SolarPanel(r.Id, r.Name, r.CapacityKw, r.PanelEfficiency ?? 0);
                else if (r.SourceType == "Wind")
                    s = new WindTurbine(r.Id, r.Name, r.CapacityKw, r.BladeLengthM ?? 0);
                else if (r.SourceType == "Battery")
                    s = new BatteryStorageSystem(r.Id, r.Name, r.CapacityKw, r.MaxCapacityKwh ?? 0);

                if (s != null)
                {
                    if (r.IsActive) s.StartGeneration();
                    result.Add(s);
                }
            }
            return result;
        }

        public static void SaveReading(double totalKw, double demandKw, bool stable)
        {
            SmartGridDb.Instance.Insert(new ReadingLog
            {
                Timestamp = System.DateTime.Now,
                TotalGenerationKw = totalKw,
                DemandKw = demandKw,
                IsStable = stable
            }).ExecuteAffrows();
        }
    }
}