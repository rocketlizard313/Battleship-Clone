using System;
using System.Collections.Generic;
using System.Linq;

namespace Battleship2210_Raketska
{
    internal class Game
    {
        private List<Ship> Fleet { get; set; }
        private bool gameRunning = true;
        private string userInput = string.Empty;

        public Game(List<Ship> fleet)
        {
            Fleet = fleet ?? new List<Ship>();
        }

        public bool AllSunk()
        {
            // Checks if all ships are sunk
            return false;
        }

        public Ship FireAt(Coord2D target)
        {
        
            return null; // Miss
        }

        public void Initialize()
        {
            // TODO: load ships from file, prompt user, etc.
            Console.WriteLine("Game initialized. Fleet ready!");
        }

        public void GameLoop()
        {
            while (gameRunning)
            {
                GetInput();
                Update();
                Render();
            }
        }

        private void GetInput()
        {
            Console.Write("Please enter a coordinate (or 'exit' to quit): ");
            userInput = Console.ReadLine()?.Trim() ?? string.Empty;

            if (userInput.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                EndGame();
            }
        }

        private void Update()
        {
            if (!gameRunning || string.IsNullOrWhiteSpace(userInput)) return;

            Console.WriteLine($"You entered: {userInput}");

            string[] coordInput = userInput.Trim().Split(",");
            int coordX = int.Parse(coordInput[0]);
            int coordY = int.Parse(coordInput[1]);
            Console.WriteLine(coordX + "," + coordY);

            foreach (Ship ship in Fleet)
            {
              bool shipHit = ship.CheckIfHit(new Coord2D(coordX, coordY));
                if (shipHit) { Console.WriteLine($"Ship hit {ship.GetName()}");
                }
               // else { Console.WriteLine("ship not hit"); }
            }

        }


        private void Render()
        {
          
        }

        private void EndGame()
        {
            gameRunning = false;
            Console.WriteLine("Game Over!");
        }
    }
}
