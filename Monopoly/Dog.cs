using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    class Dog : Player
    {
        public Dog(int playerID, TOKEN tok)
            : base(playerID, tok)
        {
            moveString = "Woof! Where did I hide that bone?";
        }

        protected override void Move(int incr)
        {
            base.Move(incr);
        }
    }
}
