namespace Blobs
{
    using Core;
    using Core.IO;

    public class BlobGame
    {
        static void Main(string[] args)
        {
            var reader = new InputReader();
            var writer = new ConsoleWriter();
            var data = new Data();
            GameEngine game = new GameEngine(data, reader, writer);
            game.Run();
        }
    }
}
