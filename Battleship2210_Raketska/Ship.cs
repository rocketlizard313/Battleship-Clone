using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2210_Raketska
{
    abstract class Ship
    {
        private Coord2D Position { get; }
        private DirectionType Direction { get; }
        private int Length { get; }
        private List<Coord2D> Points { get; }
        private List<Coord2D> DamagedPoints { get; }
        public Ship(Coord2D position, DirectionType direction, int length)
        {
            Position = position;
            Direction = direction;
            Length = length;
            Points = new List<Coord2D>();
            DamagedPoints = new List<Coord2D>();
        }
        public bool CheckIfHit(Coord2D p)
        {
            return Points.Contains(p);
        }
        public void TakeDamage(Coord2D p)
        {
            Points.Add(p);
        }
        public string GetName()
        {
            return nameof(Ship);
        }

    }
}
