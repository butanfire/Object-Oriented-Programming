namespace ClassicRPG.Interfaces
{
    public interface IEnemy
    {
        bool Active { get; set; }
        int Health { get; set; }
        float PositionX { get; set; }
        float PositionY { get; set; }
        int Width { get; set; }
        int Height { get; set; }
    }
}
