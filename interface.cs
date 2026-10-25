namespace SmartGridEngine.Interfaces
{
    public interface GridConnection
    {
        bool IsGridSynced { get; }
        void ConnectToGrid();
        void DisconnectFromGrid();
    }

    public interface ExportJson
    {
        string GenerateJSON();
    }
}
