using System;
using RockPaperScissors;
using User.Models;

namespace Game.Models
{
    public class Hands
    {
        public static void RockWinChecker(User1 user1, User2 user2)
        {
            if(user1.Answer == "R" && user2.Answer == "P")
            {
                Console.WriteLine(user2.Name + " won this round");
                user2.AddPoints();
                PointChecker(user1,user2);
                Program.NewRound(user1,user2);

            }
            else if(user1.Answer == "R" && user2.Answer == "S")
            {
                Console.WriteLine(user1.Name + " won this round");
                user1.AddPoints();
                PointChecker(user1,user2);
                Program.NewRound(user1,user2);
            }
            else if(user1.Answer == "R" && user2.Answer == "R")
            {
                Program.DrawRound(user1,user2); 

            }
        }
        public static void PaperWinChecker(User1 user1, User2 user2)
        {
            if(user1.Answer == "P" && user2.Answer == "R")
            {
                Console.WriteLine(user1.Name + " won this round");
                user1.AddPoints();
                PointChecker(user1,user2);
                Program.NewRound(user1,user2);
            }
            else if(user1.Answer == "P" && user2.Answer == "S")
            {
                Console.WriteLine(user2.Name + " won this round");
                user2.AddPoints();
                PointChecker(user1,user2);
                Program.NewRound(user1,user2);
            }
            else if(user1.Answer == "P" && user2.Answer == "P")
            {
                
                Program.DrawRound(user1,user2); 
                
            }
        }
        public static void ScissorsChecker(User1 user1, User2 user2)
        {
             if(user1.Answer == "S" && user2.Answer == "P")
             {
                 Console.WriteLine(user1.Name + " won this round");
                 user1.AddPoints();
                 PointChecker(user1,user2);
                 Program.NewRound(user1,user2);
             }
             else if (user1.Answer == "S" && user2.Answer == "R")
             {
                 Console.WriteLine(user2.Name + " won this round");
                 user2.AddPoints();
                 PointChecker(user1,user2);
                 Program.NewRound(user1,user2);
             }
             else if (user1.Answer == "S" && user2.Answer == "S")
             {
               
                Program.DrawRound(user1,user2); 
             }
        }
        public static void PointChecker(User1 user1, User2 user2)
        {
            if(user1.Points == 3)
            {
                Console.WriteLine("Game OVER!" + user1.Name + " WINS!");
                System.Environment.Exit(0);
               
            }
            else if(user2.Points == 3)
            {
                Console.WriteLine("Game OVER!" + user2.Name + " WINS!");
                System.Environment.Exit(0);
            }
        }
    }
}