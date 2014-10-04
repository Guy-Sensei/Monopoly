using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Shoe : Player
    {
        public Shoe(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Don't step on my toes!";
        }

        protected override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
