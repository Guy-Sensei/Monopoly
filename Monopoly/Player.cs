using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public class Player
    {
        public int playerNumber;
        public int money;
        public int position;
        public TOKEN token;
        public string moveString;

        public Player(int playerID, TOKEN tok)
        {
            playerNumber = playerID;
            token = tok;
            position = 0;
            money = 0;
        }

        /// <summary>
        /// Generates 2 random numbers
        /// representing 2 dice rolls.
        /// Then calls the Move() method
        /// to update the position of the player.
        /// </summary>
        public void Roll()
        {
            int d1 = Program.rand.Next(1, 6);
            int d2 = Program.rand.Next(1, 6);

            Console.WriteLine("You rolled a " + d1 + " and a " + d2);
            
            Move(d1 + d2);
        }

        public virtual void Move(int increment)
        {
            position += increment;
            
            if (position >= 40)
                position -= 40;

            Console.WriteLine(moveString);
            Console.WriteLine("You move " + increment + " spaces on the board.");
            Console.WriteLine("You land on position " + position + ".");
        }
    }
}
