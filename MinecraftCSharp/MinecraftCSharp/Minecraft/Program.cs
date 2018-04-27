using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minecraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new inspire_core.GameCore();
            game.Start(new Game.Game(), 1280, 720, 60);
        }
    }
}
