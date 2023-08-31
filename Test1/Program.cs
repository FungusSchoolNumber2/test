
namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            int areaSize;
            int ships;
            bool multiplayer;
            gameSetup(out areaSize, out ships, out multiplayer);
            Bot.drawGrid();
            Water player = new Water(5, 3, false);
            player.drawGrid();
        }

        static void gameSetup(out int areaSize, out int ships, out bool mutiplayer)
        {
            Console.Write("How big would you like the arena to be: ");
            
        }

    }
}

