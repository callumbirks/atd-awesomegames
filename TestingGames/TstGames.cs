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
        public void GameIDPropertyOK()
        {
            clsGame aGame = new clsGame();
            int testId = 1;
            aGame.GameId = testId;
            Assert.AreEqual(aGame.GameId, testId);
        }
        public void GameTitlePropertyOK()
        {
            clsGame aGame = new clsGame();
            String testTitle = "Test Title";
            aGame.GameTitle = testTitle;
            Assert.AreEqual(aGame.GameTitle, testTitle);
        }
        public void PricePropertyOK()
        {
            clsGame aGame = new clsGame();
            double testPrice = 12.20;
            aGame.Price = testPrice;
            Assert.AreEqual(aGame.Price, testPrice);
        }
        public void DiscountPropertyOK()
        {
            clsGame aGame = new clsGame();
            int testDiscount = 20;
            aGame.Discount = testDiscount;
            Assert.AreEqual(aGame.Discount, testDiscount);
        }
        public void DatePublishedPropertyOK()
        {
            clsGame aGame = new clsGame();
            DateTime testDate = new DateTime(2021, 02, 22);
            aGame.DatePublished = testDate;
            Assert.AreEqual(aGame.DatePublished, testDate);
        }
        public void ActivePropertyOK()
        {
            clsGame aGame = new clsGame();
            bool testActive = false;
            aGame.Active = testActive;
            Assert.AreEqual(aGame.Active, testActive);
        }
    }
}
