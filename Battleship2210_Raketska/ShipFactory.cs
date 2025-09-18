using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2210_Raketska
{
    internal class ShipFactory
    {
        public bool VerifyShipString(string s)
        {

            if (string.IsNullOrWhiteSpace(s))
                return false;

            string[] parts = s.Split(',');

            if (parts.Length != 5)
                return false;

            string shipName = parts[0].Trim();
            string shipSize = parts[1].Trim();
            string shipDirection = parts[2].Trim();
            string shipCoordX = parts[3].Trim();
            string shipCoordY = parts[4].Trim();


            if (string.IsNullOrEmpty(shipName))
                return false;

            if (!int.TryParse(shipSize, out int size) && size >= 2 && size <= 5)
                return false;
      
            //if (!Enum.TryParse<DirectionType>(shipDirection, true, out _))
            //    return false;

            if (!int.TryParse(shipCoordX, out int x) || x < 0 || x > 10)
                return false;

            if (!int.TryParse(shipCoordY, out int y) || y < 0 || y > 10)
                return false;

            return true;
        }
        public Ship ParseShipString(string s)
        {
            string[] parts = s.Split(',');
            string shipName = parts[0].Trim();
            string shipSize = parts[1].Trim();
            string shipDirection = parts[2].Trim();
            string shipCoordX = parts[3].Trim();
            string shipCoordY = parts[4].Trim();
            string shipInfo = $"{shipName} {shipSize} {shipDirection} {shipCoordX} {shipCoordY}";
            Console.WriteLine(shipDirection);

            Coord2D shipCoord = new Coord2D(int.Parse(shipCoordX), int.Parse(shipCoordY));
            DirectionType direction = DirectionType.Horizontal;

            if (shipDirection.Equals("h"))
            {
                direction = DirectionType.Horizontal;
            }
            else if (shipDirection.Equals("v"))
            {
                direction = DirectionType.Vertical;
            }

            switch (shipName)
            {
                case "Carrier":
                    return new Carrier(shipCoord, direction);

                case "Battleship":
                    return new Battleship(shipCoord, direction);

                case "Destroyer":
                    return new Destroyer(shipCoord, direction);

                case "Submarine":
                    return new Submarine(shipCoord, direction);

                case "Patrol Boat":
                    return new PatrolBoat(shipCoord, direction);

                default:
                    Console.WriteLine($"Unknown ship type: {shipName}");
                    return null;
            }
        }
        public List<Ship> ParseShipFile(string relativePath)
        {
            List<Ship> shipsFromFile = [];
            try
            {
                using (StreamReader sr = new StreamReader(relativePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (line[0] != '#')
                        {

                            bool verifyShip = VerifyShipString(line);
                            if (!verifyShip)
                            {
                                Console.WriteLine("Couldn't verify ship");
                                return shipsFromFile;
                            }

                            shipsFromFile.Add(ParseShipString(line));

                        }
                    }
                }

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{relativePath} not found'");
            }

            return shipsFromFile;
        }
    }
}
