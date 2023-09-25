using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues_Dallas
{
    class Game
    {
        //makes a public int nameed Maxplayers with a git statment
        public int MaxPlayers { get; }

        //makes a public int nameed CurrentPlayers with a git and set statment
        public int CurrentPlayers { get; set; }

        //makes a public Game object with the premeiters of maxP and currentP set equal to MaxPlayers and CurrentPlayers
        public Game(int maxP, int currentP)
        {
            MaxPlayers = maxP;
            CurrentPlayers = currentP;
        }

        //public void that kicksplayers and subtracts from the currentplayers
        public void KickPlayer()
        {
            CurrentPlayers--;
        }

        //makes a public void method with and if statemtn taht checks it currentPlayers is less then maxPlayers then is checks if
        //player queue is greater then 0 then if it is it deques players 1 at a time and if the queue is = to 0 then it will print to the console the follwoing
        public void CheckQueue(Queue<Player> playerQueue)
        {
            if (CurrentPlayers < MaxPlayers)
            {
                if (playerQueue.Count > 0)
                {
                    playerQueue.Dequeue();
                    CurrentPlayers++;
                }
                else
                {
                    Console.WriteLine("No players in the queue!");
                }
            }
        }

    }
}
