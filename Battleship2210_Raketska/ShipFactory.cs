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
            return false;
        }
        public Ship ParseShipString(string s)
        {
            Coord2D coord = new(0, 0);

            return new Carrier(coord, DirectionType.Horizontal);
        }
        public List<Ship> ParseShipFile(string path)
        {
            List<Ship> shipsFromFile = [];
            return shipsFromFile;
        }
    }
}
