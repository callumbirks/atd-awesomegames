using System;
using ClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestingGames
{
    [TestClass]
    public class TstGames
    {
        string GameTitle = "Adventures of Jeff";
        string Price = (12.99).ToString();
        string Discount = (10).ToString();
        string DatePublished = DateTime.Now.Date.ToString();

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
        [TestMethod]
        public void ValidMethodOK()
        {
            clsGame aGame = new clsGame();
            String Error;
            Error = aGame.Valid(GameTitle, Price, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameTitleMinLessOne()
        {
            clsGame aGame = new clsGame();
            String Error;
            String TestTitle = "";
            Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void GameTitleMin()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "1";
            String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameTitleMinPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "12";
            String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void GameTitleMid()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "".PadRight(25, 'a');
            if (TestTitle.Length == 25)
            {
                String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
                Assert.AreEqual(Error, "");
            }
            else
            {
                throw new Exception("Incorrect test string length");
            }
        }
        [TestMethod]
        public void GameTitleMaxLessOne()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "".PadRight(49,'a');
            if (TestTitle.Length == 49)
            {
                String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
                Assert.AreEqual(Error, "");
            }
            else
            {
                throw new Exception("Incorrect test string length");
            }
        }
        [TestMethod]
        public void GameTitleMax()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "".PadRight(50,'a');
            if (TestTitle.Length == 50)
            {
                String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
                Assert.AreEqual(Error, "");
            }
            else
            {
                throw new Exception("Incorrect test string length");
            }
        }
        [TestMethod]
        public void GameTitleMaxPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "".PadRight(51,'a');
            if (TestTitle.Length == 51)
            {
                String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
                Assert.AreNotEqual(Error, "");
            }
            else
            {
                throw new Exception("Incorrect test string length");
            }
        }
        [TestMethod]
        public void GameTitleExtremeMax()
        {
            clsGame aGame = new clsGame();
            String TestTitle = "".PadRight(300,'a');
            if (TestTitle.Length == 300)
            {
                String Error = aGame.Valid(TestTitle, Price, Discount, DatePublished);
                Assert.AreNotEqual(Error, "");
            }
            else
            {
                throw new Exception("Incorrect test string length");
            }
        }
        [TestMethod]
        public void PriceExtremeMin()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (-500.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinLessOne()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (-1.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceMin()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (0.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMinPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (1.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMid()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (50.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxLessOne()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (99.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMax()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (100.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void PriceMaxPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (101.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceExtremeMax()
        {
            clsGame aGame = new clsGame();
            String TestPrice = (500.00).ToString();
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void PriceInvalidType()
        {
            clsGame aGame = new clsGame();
            String TestPrice = "Jeff";
            String Error = aGame.Valid(GameTitle, TestPrice, Discount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiscountExtremeMin()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (-500).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMinLessOne()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (-1).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMin()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (0).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMinPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (1).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMid()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (50).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMaxLessOne()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (99).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMax()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (100).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DiscountMaxPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (101).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiscountExtremeMax()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = (500).ToString();
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DiscountInvalidType()
        {
            clsGame aGame = new clsGame();
            String TestDiscount = "Test";
            String Error = aGame.Valid(GameTitle, Price, TestDiscount, DatePublished);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedExtremeMin()
        {
            clsGame aGame = new clsGame();
            String TestDate = (new DateTime(1960, 06, 21)).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMinLessOne()
        {
            clsGame aGame = new clsGame();
            String TestDate = (new DateTime(1989, 12, 31)).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMin()
        {
            clsGame aGame = new clsGame();
            String TestDate = (new DateTime(1990, 01, 01)).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMinPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestDate = (new DateTime(1990, 01, 02)).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMid()
        {
            clsGame aGame = new clsGame();
            String TestDate = (new DateTime(2001, 03, 29)).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMaxLessOne()
        {
            clsGame aGame = new clsGame();
            String TestDate = DateTime.Now.Date.AddDays(-1).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMax()
        {
            clsGame aGame = new clsGame();
            String TestDate = DateTime.Now.Date.ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedMaxPlusOne()
        {
            clsGame aGame = new clsGame();
            String TestDate = DateTime.Now.Date.AddDays(1).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedExtremeMax()
        {
            clsGame aGame = new clsGame();
            String TestDate = DateTime.Now.Date.AddYears(50).ToString();
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void DatePublishedInvalidType()
        {
            clsGame aGame = new clsGame();
            String TestDate = "Test21";
            String Error = aGame.Valid(GameTitle, Price, Discount, TestDate);
            Assert.AreNotEqual(Error, "");
        }
    }
}
