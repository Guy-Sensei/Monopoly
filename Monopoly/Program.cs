using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Program
    {
        public static Game game;

        // random number
        public static Random rand;

        static void Main(string[] args)
        {
            rand = new Random();
            game = new Game();
        }
    }
}
