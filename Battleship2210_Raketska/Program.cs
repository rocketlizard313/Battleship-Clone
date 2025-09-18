namespace Battleship2210_Raketska
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Create ship factory
            ShipFactory shipFactory = new ShipFactory();

            //Prompt user for file here 
            Console.WriteLine("Enter filepath here:");
            string relativePath = Console.ReadLine();

            // If user just presses Enter, fall back to default relative path
            relativePath.Trim();
            
            List<Ship> newShips = shipFactory.ParseShipFile(relativePath);

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
