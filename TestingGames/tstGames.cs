using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGames
{
    [TestClass]
    public class tstGames
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsGames newGame = new clsGames();
            Assert.IsNotNull(newGame);
        }
    }
}