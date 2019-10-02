using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game.Models;
using User.Models;

namespace RockPaperScissors.Tests
{
    [TestClass]
    public class RockPaperScissorsTests
    {
        [TestMethod]
        public void RockWinChecker_IfUIIsRockItWillGoToThisFunc_True()
        {
            User1 firstUser = new User1("nikhil","R");
            User2 secondUser = new User2("Nik", "P");
            Assert.AreEqual(Hands.RockWinChecker(firstUser,secondUser), 0);
        }
    }
}