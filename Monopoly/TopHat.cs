using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class TopHat : Player
    {
        public TopHat(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Keeping it classy.";
        }

        protected override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
