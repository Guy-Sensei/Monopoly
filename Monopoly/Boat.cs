using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Boat : Player
    {
        public Boat(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Makin' waves, man...";
        }

        override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
