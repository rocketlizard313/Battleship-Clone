using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2210_Raketska
{
    internal class Carrier(Coord2D start, DirectionType direction) : Ship(start, direction, 5)
    {
    }
}
