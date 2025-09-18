using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2210_Raketska
{
    internal class Coord2D
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord2D(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X},{Y})";
        }
        /// <summary>
        /// Checks if two sets of coordinates are equal
        /// Value equality instead of reference 
        /// </summary>
        /// <param name="coord2D">Comparison coordinate</param>
        /// <returns>Compared coordsd</returns>
        /* public bool Equals(Coord2D coord2D)  //might be wrong bc this is just comparing coordinates not memory adress have to override somewhere

         {
             if (coord2D == null) return false;
           //  if (this.X != coord2D.X) return false;
           //  if (this.Y != coord2D.Y) return false;
             if (this.X == coord2D.X && this.Y == coord2D.Y) return true;
             return false;
         }*/
        public override bool Equals(object obj)
        {
            if (obj is Coord2D other)
            {
                return this.X == other.X && this.Y == other.Y;
            }
            return false;
        }
        /// <summary>
        /// Coordinates with the same X,Y will now be stored 
        /// under the same hash value, regardless of memory address
        /// </summary>
        /// <returns>Integer hash representing the coordinate</returns>
        public int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode(); // ^ is bitwise XOR
        }

        public static bool TryParse(string s, out Coord2D coord)
        {
            if (!TryParse(s, out coord)) return false;
            return true; // this will cause stack overflow :(((
        }
       
    }
}
