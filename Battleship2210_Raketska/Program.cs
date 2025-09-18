namespace Battleship2210_Raketska
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create ship factory
            ShipFactory shipFactory = new ShipFactory();

          /*  Console.WriteLine("Enter filepath here:");
            string? relativePath = Console.ReadLine();

   
            if (relativePath.IndexOfAny(Path.GetInvalidPathChars()) >= 0)
            {
                Console.WriteLine("Invalid characters in path. Exiting program.");
                return;
            }

            string fullPath = Path.GetFullPath(relativePath);

            if (!File.Exists(fullPath))
            {
                Console.WriteLine($"File not found at: {fullPath}");
                return;
            }*/

           // Console.WriteLine($"Valid file path provided: {fullPath}");

            List<Ship> newShips = shipFactory.ParseShipFile("C:\\Users\\lisar\\Source\\Repos\\Battleship-Clone\\Battleship2210_Raketska\\textFile\\Battleship-TestData\\Battleship-TestData\\Battleship-GoodData.gameboard.txt");

            if (newShips.Count == 0)
            {
                Console.WriteLine("Could not parse ship file. Exiting program");
                return;
            }

            foreach (var ship in newShips)
            {
                Console.WriteLine(ship.GetInfo());
            }

            //Create Game 
            Game game = new(newShips);

            //Start the game
            game.GameLoop();

        }
    }
}
