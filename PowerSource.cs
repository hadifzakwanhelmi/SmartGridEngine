using System;
using SmartGridEngine.Interfaces;

namespace SmartGridEngine.Models
{
    public abstract class PowerSource : ExportJson, GridConnection
    {
        protected string _id;
        protected string _name;
        protected double _capacityKw;
        protected double _currentOutputKw;
        protected bool _isActive;

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double CapacityKw { get => _capacityKw; set => _capacityKw = value; }
        public double CurrentOutputKw { get => _currentOutputKw; set => _currentOutputKw = value; }
        public bool IsActive { get => _isActive; set => _isActive = value; }

        public bool IsGridSynced { get; private set; }

        protected PowerSource(string id, string name, double capacityKw)
        {
            _id = id;
            _name = name;
            _capacityKw = capacityKw;
            _currentOutputKw = 0;
            _isActive = false;
            IsGridSynced = false;
        }

        public virtual void StartGeneration()
        {
            _isActive = true;
            _currentOutputKw = _capacityKw * 0.85;
        }

        public virtual void StopGeneration()
        {
            _isActive = false;
            _currentOutputKw = 0;
        }

        public abstract double CalculateEfficiency();

        public virtual void ConnectToGrid()
        {
            IsGridSynced = true;
        }

        public virtual void DisconnectFromGrid()
        {
            IsGridSynced = false;
        }

        public virtual string GenerateJSON()
        {
            return $"{{\"Id\":\"{_id}\", \"Name\":\"{_name}\", \"OutputKw\":{_currentOutputKw}, \"Active\":{_isActive}, \"GridSynced\":{IsGridSynced}}}";
        }
    }
}