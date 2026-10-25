using SmartGridEngine.Models;

namespace SmartGridEngine.Models
{
    public class BatteryStorageSystem : PowerSource
    {
        public double MaxCapacityKwh { get; set; }
        public double CurrentCharge { get; set; }

        public BatteryStorageSystem(string id, string name, double capacityKw, double maxCapacityKwh) 
            : base(id, name, capacityKw)
        {
            MaxCapacityKwh = maxCapacityKwh;
            CurrentCharge = maxCapacityKwh * 0.75;
        }

        public override double CalculateEfficiency()
        {
            return CurrentCharge / MaxCapacityKwh;
        }
    }
}