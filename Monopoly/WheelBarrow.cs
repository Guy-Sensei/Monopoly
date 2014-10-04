using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class WheelBarrow : Player
    {
        public WheelBarrow(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Hurry up and load the body! We gotta roll!";
        }

        protected override void Move(int increment)
        {
            base.Move(increment);
        }
    }
}
