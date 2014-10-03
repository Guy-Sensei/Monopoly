using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Thimble : Player
    {
        public Thimble(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Always wear protection... when sewing.";
        }

        override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
