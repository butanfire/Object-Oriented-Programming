namespace TheSlum
{
    using GameEngine;

    public class TheSlum
    {
        public static void Main()
        {
            Engine engine = new Engine();            
            //engine.Run();
            EngineModification modifiedEngine = new EngineModification();
            modifiedEngine.Run();
        }
    }
}
