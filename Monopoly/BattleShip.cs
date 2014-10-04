using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class BattleShip : Player
    {
        public BattleShip(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Hard to port!";
        }

        protected override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
