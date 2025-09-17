using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Battleship2210_Raketska
{
    internal interface IHealth
    {
        public int GetMaxHealth()
        {
            return 0;
        }
        public int GetCurrentHealth() 
        {
            return 0; 
        }
        public bool IsDead()
        {
            return true;
        }
    }
}
