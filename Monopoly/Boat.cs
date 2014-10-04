using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Boat : Player
    {
        public Boat(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Makin' waves, man...";
        }

        protected override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
