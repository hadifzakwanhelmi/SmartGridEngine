using System.Collections.Generic;
using System.Linq;
using SmartGridEngine.Models;

namespace SmartGridEngine.Services
{
    public class GridController
    {
        private readonly List<PowerSource> sources = new List<PowerSource>();
        private double totalLoadDemandKw = 300.0;

        public List<PowerSource> Sources => sources;
        public double TotalLoadDemandKw 
        { 
            get => totalLoadDemandKw; 
            set => totalLoadDemandKw = value; 
        }

        public void RegisterSource(PowerSource source)
        {
            sources.Add(source);
        }

        public double GetTotalGeneration()
        {
            return sources.Where(s => s.IsActive).Sum(s => s.CurrentOutputKw);
        }

        public bool EvaluateGridStability()
        {
            return GetTotalGeneration() >= totalLoadDemandKw;
        }
    }
}