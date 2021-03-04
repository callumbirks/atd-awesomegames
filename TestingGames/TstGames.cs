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
        [TestMethod]
        public void GameIDPropertyOK()
        {
            clsGame aGame = new clsGame();
            int testId = 1;
            aGame.GameId = testId;
            Assert.AreEqual(aGame.GameId, testId);
        }
        [TestMethod]
        public void GameTitlePropertyOK()
        {
            clsGame aGame = new clsGame();
            String testTitle = "Test Title";
            aGame.GameTitle = testTitle;
            Assert.AreEqual(aGame.GameTitle, testTitle);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsGame aGame = new clsGame();
            double testPrice = 12.20;
            aGame.Price = testPrice;
            Assert.AreEqual(aGame.Price, testPrice);
        }
        [TestMethod]
        public void DiscountPropertyOK()
        {
            clsGame aGame = new clsGame();
            int testDiscount = 20;
            aGame.Discount = testDiscount;
            Assert.AreEqual(aGame.Discount, testDiscount);
        }
        [TestMethod]
        public void DatePublishedPropertyOK()
        {
            clsGame aGame = new clsGame();
            DateTime testDate = new DateTime(2021, 02, 22);
            aGame.DatePublished = testDate;
            Assert.AreEqual(aGame.DatePublished, testDate);
        }
        [TestMethod]
        public void ActivePropertyOK()
        {
            clsGame aGame = new clsGame();
            Boolean testActive = false;
            aGame.Active = testActive;
            Assert.AreEqual(aGame.Active, testActive);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            int testId = 4;
            found = aGame.Find(testId);
            Assert.IsTrue(found);
        }
        [TestMethod]
        public void TestGameIdFound()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            Boolean ok = true;
            int testId = 4;
            found = aGame.Find(testId);
            if(aGame.GameId != 4)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestGameTitleFound()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            Boolean ok = true;
            int testId = 4;
            found = aGame.Find(testId);
            if(aGame.GameTitle != "Adventures of Bork")
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestPriceFound()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            Boolean ok = true;
            int testId = 4;
            found = aGame.Find(testId);
            if (aGame.Price != 16.99)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestDiscountFound()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            Boolean ok = true;
            int testId = 4;
            found = aGame.Find(testId);
            if (aGame.Discount != 10)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestDatePublishedFound()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            Boolean ok = true;
            int testId = 4;
            found = aGame.Find(testId);
            if (aGame.DatePublished != (new DateTime(2021, 02, 21)))
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
        [TestMethod]
        public void TestActiveFound()
        {
            clsGame aGame = new clsGame();
            Boolean found = false;
            Boolean ok = true;
            int testId = 4;
            found = aGame.Find(testId);
            if (aGame.Active != true)
            {
                ok = false;
            }
            Assert.IsTrue(ok);
        }
    }
}
