using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class RaceCar : Player
    {
        public RaceCar(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Burn that rubber!";
        }

        override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
