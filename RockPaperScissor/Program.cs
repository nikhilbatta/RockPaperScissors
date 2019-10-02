using System;
using System.Collections.Generic;
using Game.Models;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to rock paper scissors");
            Console.WriteLine("User 1 please enter in a thing");
            string user1answer = Console.ReadLine();
            Console.WriteLine("user2 please enter in a thing");
            string user2answer = Console.ReadLine();
            if(user1answer == "rock")
            {
                Hands.RockWinChecker(user1answer, user2answer);
            }
            else if(user1answer == "scissors")
            {
                Hands.ScissorsChecker(user1answer,user2answer);
            }
            else if(user1answer == "paper")
            {
                Hands.PaperWinChecker(user1answer, user2answer);
            }
        }
    }
}