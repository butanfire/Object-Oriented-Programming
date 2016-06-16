namespace ClassicRPG.Interfaces
{
    public interface IItem
    {
        bool isEquiped { get; set; }
        int Durability { get; set; }
        string Name { get; set; }
    }
}
