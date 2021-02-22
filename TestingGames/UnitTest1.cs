using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGames
{
    [TestClass]
    public class TstGames
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsGame aGame = new clsGame();
            Assert.IsNotNull(aGame);
        }
    }
}
