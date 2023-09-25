using Queues_Dallas;

class Program
{
    static void Main(string[] args)
    {
        //makes an object named myGame and sets it equal new Game and gives it vaules of 50 and 49
        Game myGame = new Game(50, 49);

        
        Queue<Player> waitingToJoinQ = new Queue<Player>();

        //makes a queue of 4 players and gives them a vaule of 100
        Player p1 = new Player(100, "MMSix");
        Player p2 = new Player(100, "xXAwesomenessXx");
        Player p3 = new Player(100, "Get Good");
        Player p4 = new Player(100, "ZombieSlaya");

        //give the 4 players waiting to join q
        p1.JoinGame(myGame, waitingToJoinQ);
        p2.JoinGame(myGame, waitingToJoinQ);
        p3.JoinGame(myGame, waitingToJoinQ);
        p4.JoinGame(myGame, waitingToJoinQ);


        //writes the following for each player waitning i the q
        Console.WriteLine("Players in da Q:");
        foreach (Player player in waitingToJoinQ)
        {
            Console.WriteLine(player);
        }
        //kicks player from game and checks the q
        myGame.KickPlayer();
        myGame.CheckQueue(waitingToJoinQ);

        //prints following foreach player in the queue and prints out the players username
        Console.WriteLine("\nPlayers in da Q:");
        foreach (Player player in waitingToJoinQ)
        {
            Console.WriteLine(player);
        }
    }
}