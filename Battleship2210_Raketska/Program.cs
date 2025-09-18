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
            Console.ReadLine();
            //Parse user input
            List<Ship> newShips = shipFactory.ParseShipFile(@"C:\Users\Kaleb\Desktop\Battleship2210_Raketskazip\Battleship2210_Raketska\Battleship2210_Raketska\textFile\Battleship-TestData\Battleship-TestData\Battleship-GoodData.gameboard.txt");

            if(newShips.Count == 0)
            {
                Console.WriteLine("Could not parse ship file. Exiting program");
                return;
            }

            foreach(var ship in newShips)
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
