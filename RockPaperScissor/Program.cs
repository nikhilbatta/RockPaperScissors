using System;
using System.Collections.Generic;
using Game.Models;
using User.Models;

namespace RockPaperScissors
{
    public class Program
    {
        public static void Main()
        {
            StartGame();
        }
        public static void StartGame()
        {
            Console.WriteLine("User1, what is your name?");
            string user1Name = Console.ReadLine();
            Console.WriteLine("User2, what is your name?");
            string user2Name =Console.ReadLine();

            Console.WriteLine("Welcome to rock paper scissors");
            Console.WriteLine("User 1 please enter in R for rock, P for Paper, or S for scissors");
            // hides users response for purpose of the game 
            string user1answer = null;
            while(true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                    user1answer += key.KeyChar;

           }

            User1 firstUser = new User1(user1Name, user1answer);
            // hides users response for purpose of the game
            Console.WriteLine("user2 please enter in a thing");
            string user2answer = null;
            while(true)
            {
                var key = System.Console.ReadKey(true);
                  if (key.Key == ConsoleKey.Enter)
                    break;
                    user2answer += key.KeyChar;

            }

            User2 secondUser = new User2(user2Name, user2answer);

            if(firstUser.Answer == "r" || firstUser.Answer == "R")
            {
                Hands.RockWinChecker(firstUser, secondUser);
            }
            else if(firstUser.Answer == "s" || firstUser.Answer == "S")
            {
                Hands.ScissorsChecker(firstUser,secondUser);
            }
            else if(firstUser.Answer == "p" || firstUser.Answer == "P")
            {
                Hands.PaperWinChecker(firstUser, secondUser);
            }
        }
        public static void NewRound(User1 user1, User2 user2)
        {
            Console.WriteLine("Next Round");
            Console.WriteLine("User 1 please enter in a thing");
            string user1answer = Console.ReadLine();
            user1.Answer = user1answer;
            Console.WriteLine("user2 please enter in a thing");
            string user2answer = Console.ReadLine();
            user2.Answer = user2answer;
            if( user1answer == "R")
            {
                Hands.RockWinChecker(user1, user2);
            }
            else if(user1answer == "S")
            {
                Hands.ScissorsChecker(user1,user2);
            }
            else if(user1answer == "P")
            {
                Hands.PaperWinChecker(user1, user2);
            }
        }
        public static void DrawRound(User1 user1 , User2 user2)
        {
            Console.WriteLine("That round was a draw lets go again");
            Console.WriteLine("User 1 please enter in a thing");
            string user1answer = Console.ReadLine();
            user1.Answer = user1answer;
            Console.WriteLine("user2 please enter in a thing");
            string user2answer = Console.ReadLine();
            user2.Answer = user2answer;
            if( user1answer == "R")
            {
                Hands.RockWinChecker(user1, user2);
            }
            else if(user1answer == "S")
            {
                Hands.ScissorsChecker(user1,user2);
            }
            else if(user1answer == "P")
            {
                Hands.PaperWinChecker(user1, user2);
            }

        }
    }
}