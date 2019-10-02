using System;

namespace Game.Models
{
    public class Hands
    {
        public static void RockWinChecker(string user1, string user2)
        {
            if(user1 == "rock" && user2 == "paper")
            {
                Console.WriteLine("user2 wins");
            }
            else if(user1 == "rock" && user2 == "scissors")
            {
                Console.WriteLine("user1 wins");
            }
            else if(user1 == "rock" && user2 == "rock")
            {
                // go back to the start of game
            }
        }
        public static void PaperWinChecker(string user1, string user2)
        {
            if(user1 == "paper" && user2 == "rock")
            {
                Console.WriteLine("user1 wins");
            }
            else if(user1 == "paper" && user2 == "scissors")
            {
                Console.WriteLine("user2 wins");
            }
            else if(user1 == "paper" && user2 == "paper")
            {
                // go back to the start of the game
            }
        }
        public static void ScissorsChecker(string user1, string user2)
        {
             if(user1 == "scissors" && user2 == "paper")
             {
                 Console.WriteLine("User1 wins");
             }
             else if (user1 == "scissors" && user2 == "rock")
             {
                 Console.WriteLine("user2 wins");
             }
             else if (user1 == "scissors" && user2 == "scissors")
             {
                //  got back to start
             }
        }
    }
}