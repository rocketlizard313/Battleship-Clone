namespace Battleship2210_Raketska
{
    abstract class Ship : IInformatic
    {
        /// <summary>
        /// Starting position of the ship 
        /// </summary>
        private Coord2D Position { get; }
        /// <summary>
        /// Direction of the ship for either left or down direction 
        /// </summary>
        private DirectionType Direction { get; }
        /// <summary>
        /// length supposed to span 
        /// </summary>
        private int Length { get; }
        /// <summary>
        /// list of points for a specific ship 
        /// </summary>
        private List<Coord2D> Points { get; } = new List<Coord2D>();
        private List<Coord2D> DamagedPoints { get; } = new List<Coord2D> { };
        /// <summary>
        /// Creating a ship (span) of poi8nts 
        /// </summary>
        /// <param name="position">Starting position</param>
        /// <param name="direction">Which way </param>
        /// <param name="length">ho wlong</param>
        public Ship(Coord2D position, DirectionType direction, int length)
        {
            Position = position;
            Direction = direction;
            Length = length;

            CreateShipPoints();
        }


        public virtual string GetInfo()
        {
            return $"{GetName()} {Length}, at {Position} {Direction} | HP";
        }


        public bool CheckIfHit(Coord2D p)
        {
            return Points.Contains(p);
        }
        public void TakeDamage(Coord2D p)
        {
            Points.Add(p);
        }
        public virtual string GetName()
        {
            return nameof(Ship);
        }

        public void CreateShipPoints()
        {
            // start with position of ship check if horizontal or vertical, check for length, depending on the length 
            // span the ship across the cells 
            int x = Position.X;
            int y = Position.Y;
            for (int i = 0; i < Length; i++)
            {
                Points.Add(new Coord2D(x, y));
                if (Direction == DirectionType.Horizontal)
                {
                    x++;
                }
                else//Direction == DirectionType.Vertical
                {
                    y++;
                }
            }
           
            foreach(var item in Points)
            {
                Console.WriteLine($"{item.X},{item.Y}");
            }
        }


    }
}
