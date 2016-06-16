namespace Blobs.Interfaces
{
    public interface IEngine
    {
        void Run();

        bool IsRunning { get; set; }
    }
}
