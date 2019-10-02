using System;
using Game.Models;

namespace User.Models
{
    public class People
    {
        public int Points{get;set;}
        public string Answer{get;set;}
        public string Name{get;set;}

    }
    public class User1 : People
    {
        public User1(string user1Name, string userInput)
        {
            Name = user1Name;
            Answer = userInput;
            Points = 0;
        }
        public void AddPoints()
        {
            Points++;
        }
       
    }
    public class User2 : People
    {
        public User2(string user2Name, string userInput)
        {
            Name = user2Name;
            Answer = userInput;
            Points = 0;
        }
        public void AddPoints()
        {
            Points++;
        }
       
    }
}