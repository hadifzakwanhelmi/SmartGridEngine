using SmartGridEngine.Models;

namespace SmartGridEngine.Models
{
    public class WindTurbine : PowerSource
    {
        public double WindSpeedKms { get; set; }
        public double BladeLengthM { get; set; }

        public WindTurbine(string id, string name, double capacityKw, double bladeLengthM) 
            : base(id, name, capacityKw)
        {
            BladeLengthM = bladeLengthM;
            WindSpeedKms = 12.5;
        }

        public override double CalculateEfficiency()
        {
            return (WindSpeedKms / 25.0) * (BladeLengthM / 50.0);
        }
    }
}