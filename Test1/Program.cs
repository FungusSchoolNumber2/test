
namespace Test1
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.ReadLine();
            int areaSize;
            int ships;
            bool multiplayer;
            gameSetup(out areaSize, out ships, out multiplayer);
            Water player = new Water(areaSize, ships, !multiplayer);
            player.drawGrid();
        }
        static void gameSetup(out int areaSize, out int ships, out bool multiplayer)
        {
            Console.Write("How big would you like the arena to be?: ");
            areaSize = Tools.SafeInts(Console.ReadLine());
            Console.Write("How many ships do you want?: ");
            ships = Tools.SafeInts(Console.ReadLine(), areaSize);
            Console.Write("Are you going to play alone?(y/n): ");
            if (Console.ReadLine() == "n")
            {
                multiplayer = true;
            }
            else
            {
                multiplayer = false;
            }
        }

    }
}

