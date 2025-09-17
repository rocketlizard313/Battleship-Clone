using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship2210_Raketska
{
    internal class Game
    {
        private List<Ship> Fleet { get; set; }
        public Game(List<Ship> fleet) { }
        public bool AllSunk()
        {
            return Fleet.Any(); //?
        }
        public Ship FireAt(Coord2D p)
        {
            return new Carrier(p,DirectionType.Horizontal); 
        }

        public void Initialize() 
        {
            // read from a file promt etc.

            
        }
        private void GameLoop()
        {
            //handle input if hit escape hit escape key and end 
        }
        private void GetInput()
        {

        }
        private void Update()
        {

        }
        private void Render()
        {

        }
        public void EndGame()
        {

        }

    }
}
