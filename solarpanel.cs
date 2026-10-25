using SmartGridEngine.Models;

namespace SmartGridEngine.Models
{
    public class SolarPanel : PowerSource
    {
        public double PanelEfficiency { get; set; }
        public double SunlightLux { get; set; }

        public SolarPanel(string id, string name, double capacityKw, double panelEfficiency) 
            : base(id, name, capacityKw)
        {
            PanelEfficiency = panelEfficiency;
            SunlightLux = 55000;
        }

        public override double CalculateEfficiency()
        {
            return PanelEfficiency * (SunlightLux / 100000.0);
        }
    }
}