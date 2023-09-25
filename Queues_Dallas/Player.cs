using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Dallas
{
    internal class Player
    {
        //makes 3 public objest with get set vaules and makes a public method with the preameders healtherparam and name param and sets them equal to heakth and Gamertag
        public int Health { get; set; }
         
        public string GamerTag { get; }

        public Player(int healthParam, string nameParam)
        {
            Health = healthParam;
            GamerTag = nameParam;
        }

        //makes a public void with a if statement that checks if currentPlayers is equal to max players if it is then it hults the queue
        //if not then it writs the flowing and adds 1 by 1 to game
        public void JoinGame(Game game, Queue<Player> queue) 
        { 
            if (game.CurrentPlayers == game.MaxPlayers)
            {
                queue.Enqueue(this);
            }
            else
            {
                Console.WriteLine("Joining Game!");
                game.CurrentPlayers++;
            }
        }
        //makes a public override string for GamerTag
        public override string ToString()
        {
            return GamerTag;
        }
    }
}
