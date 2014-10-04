using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    public enum TOKEN
    {
        BOAT,
        DOG,
        THIMBLE,
        TOP_HAT,
        WHEEL_BARROW,
        BATTLESHIP,
        RACE_CAR,
        SHOE,
        MAX
    }

    public class Game
    {
        

        // define constants
        const int MINPLAYERS = 2;
        const int MAXPLAYERS = 4;
        const int MAXSPACES = 40;

        // number of players
        int numPlayers;

        // current turn
        int playerTurn;

        // turn number
        int turnNumber;

        // List of Players
        List<Player> players;

        /// <summary>
        /// Default constructor
        /// </summary>
        public Game()
        {
            players = new List<Player>();
            Reset();
        }

        /// <summary>
        /// Ask a question and return the input string.
        /// </summary>
        /// <param name="question">What do you want to ask the user?</param>
        /// <returns></returns>
        string Question(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        /// <summary>
        /// Reset the game
        /// </summary>
        void Reset()
        {
            players.Clear();
            turnNumber = 0;
            PlayerSelect();
            BeginGame();
        }

        /// <summary>
        /// Resets the player data and asks for new data
        /// </summary>
        void PlayerSelect()
        {
            // reset number of players to 0
            numPlayers = 0;

            // ask how many players and store in numPlayers
            while (numPlayers < MINPLAYERS || numPlayers > MAXPLAYERS)
            {
                Console.Clear();
                numPlayers = Convert.ToInt32((Question("How many players? (" + MINPLAYERS + " - " + MAXPLAYERS + " players)")));
            }

            Console.Clear();

            // create a list of used tokens to avoid selecting the same token for multiple players
            List<int> usedTokens = new List<int>();

            // loop through the number of players
            for (int i = 1; i <= numPlayers; i++)
            {
                Console.WriteLine("Player " + i + ", Please select your token");

                // Display available tokens
                for (int j = 0; j < (int)TOKEN.MAX; j++)
                {

                    // if this is the first player, show all tokens
                    if (players.Count() == 0)
                        Console.WriteLine(j + ": " + ((TOKEN)j).ToString());

                    // otherwise, only display unused tokens
                    else
                    {
                        if (!usedTokens.Contains(j))
                        {
                            Console.WriteLine(j + ": " + ((TOKEN)j).ToString());
                        }
                    }
                }

                // temporary token variable
                int selectedToken = -1;

                // infinite loop to receive input
                while (selectedToken < 0 || selectedToken > (int)TOKEN.MAX)
                {
                    // read input
                    selectedToken = Convert.ToInt32(Console.ReadLine());

                    // if selected token is used, reset the temporary variable to -1 and print an error
                    if (usedTokens.Contains(selectedToken))
                    {
                        Console.WriteLine((TOKEN)selectedToken + " is already selected. Please choose another.");
                        selectedToken = -1;
                    }
                }

                // create player object and store in list of players
                Player pl;
                switch ((TOKEN)selectedToken)
                {
                    case TOKEN.BATTLESHIP:
                        pl = new BattleShip(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.BOAT:
                        pl = new Boat(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.DOG:
                        pl = new Dog(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.RACE_CAR:
                        pl = new RaceCar(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.SHOE:
                        pl = new Shoe(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.THIMBLE:
                        pl = new Thimble(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.TOP_HAT:
                        pl = new TopHat(i, (TOKEN)selectedToken);
                        break;

                    case TOKEN.WHEEL_BARROW:
                        pl = new WheelBarrow(i, (TOKEN)selectedToken);
                        break;
                    default:
                        pl = new BattleShip(i, (TOKEN)selectedToken);
                        break;
                }

                players.Add(pl);

                // add the selected token to the list of used tokens
                usedTokens.Add((int)selectedToken);

                Console.Clear();
            }

            
        }

        void ShowStandings()
        {
            for (int i = 0; i < numPlayers; i++)
            {
                Console.WriteLine("Player " + (i+1) + " (" + players[i].token.ToString() + ")");
                Console.WriteLine("Money = " + players[i].money);
                Console.WriteLine("Position = " + players[i].position + "\n");
            }
        }

        void BeginTurn()
        {
            Console.Clear();
            ShowStandings();
            Console.WriteLine("Player " + (playerTurn+1) + ", it's your turn.");
            Console.WriteLine("Press any key to roll the dice.");
            Console.ReadKey();

            players[playerTurn].Roll();

            EndTurn();
        }

        void EndTurn()
        {
            Console.WriteLine("Your turn is over. Press any key to end your turn.");
            Console.ReadKey();
            NextPlayer();
        }

        void NextPlayer()
        {
            turnNumber++;
            playerTurn++;
            if (playerTurn >= numPlayers)
                playerTurn = 0;

            BeginTurn();
        }

        void BeginGame()
        {
            // randomize the first turn
            playerTurn = Program.rand.Next(0, (numPlayers-1));

            foreach (Player p in players)
            {
                Console.WriteLine("Player " + p.playerNumber + " is " + p.token.ToString());
            }

            Console.WriteLine("The first player will be Player " + (playerTurn+1));

            Console.WriteLine("Press any key to begin.");
            Console.ReadKey();
            BeginTurn();
        }
    }
}
