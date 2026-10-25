using System;
using SmartGridEngine.Models;
using SmartGridEngine.Services;

namespace SmartGridEngine.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Smart Grid & Renewable Energy Monitoring Engine ===");

            GridController controller = new GridController { TotalLoadDemandKw = 250.0 };

            SolarPanel solar = new SolarPanel("SOL-001", "Rooftop Solar Array", 120.0, 0.92);
            WindTurbine wind = new WindTurbine("WND-001", "Offshore Turbine 1", 180.0, 45.0);
            BatteryStorageSystem battery = new BatteryStorageSystem("BAT-001", "Substation Battery Bank", 100.0, 500.0);

            controller.RegisterSource(solar);
            controller.RegisterSource(wind);
            controller.RegisterSource(battery);

            solar.StartGeneration();
            solar.ConnectToGrid();

            wind.StartGeneration();
            wind.ConnectToGrid();

            battery.StartGeneration();
            battery.ConnectToGrid();

            Console.WriteLine($"\nTarget Load Demand: {controller.TotalLoadDemandKw} kW");
            Console.WriteLine($"Total Active Generation: {controller.GetTotalGeneration():F2} kW");
            
            bool isStable = controller.EvaluateGridStability();
            Console.WriteLine($"Grid Status: {(isStable ? "STABLE [OK]" : "UNSTABLE [WARNING]")}");

            Console.WriteLine("\n---JSON text ---");
            foreach (var source in controller.Sources)
            {
                Console.WriteLine(source.GenerateJSON());
                Console.WriteLine($"Calculated Efficiency: {source.CalculateEfficiency() * 100:F2}%\n");
            }
        }
    }
}