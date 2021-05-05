using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace TestingGames
{
    [TestClass]
    public class TstGamesCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            Assert.IsNotNull(AllGames);
        }
        [TestMethod]
        public void GamesListOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            List<clsGame> TestList = new List<clsGame>();
            clsGame TestGame = new clsGame();
            TestGame.GameId = 7;
            TestGame.GameTitle = "Some Game";
            TestGame.Price = 11.99;
            TestGame.Discount = 20;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            TestList.Add(TestGame);
            AllGames.GamesList = TestList;
            Assert.AreEqual(AllGames.GamesList, TestList);
        }
        [TestMethod]
        public void ThisGamePropertyOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            clsGame TestGame = new clsGame();
            TestGame.GameId = 7;
            TestGame.GameTitle = "Some Game";
            TestGame.Price = 11.99;
            TestGame.Discount = 20;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            AllGames.ThisGame = TestGame;
            Assert.AreEqual(AllGames.ThisGame, TestGame);
        }
        [TestMethod]
        public void ListAndCountOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            List<clsGame> TestList = new List<clsGame>();
            clsGame TestGame = new clsGame();
            TestGame.GameId = 7;
            TestGame.GameTitle = "Some Game";
            TestGame.Price = 11.99;
            TestGame.Discount = 20;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            TestList.Add(TestGame);
            AllGames.GamesList = TestList;
            Assert.AreEqual(AllGames.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            clsGame TestGame = new clsGame();
            int PrimaryKey = 0;
            TestGame.GameTitle = "Some Game";
            TestGame.Price = 11.99;
            TestGame.Discount = 20;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            AllGames.ThisGame = TestGame;
            PrimaryKey = AllGames.Add();
            TestGame.GameId = PrimaryKey;
            AllGames.ThisGame.Find(PrimaryKey);
            Assert.AreEqual(AllGames.ThisGame, TestGame);
        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            clsGame TestGame = new clsGame();
            int PrimaryKey = 0;
            TestGame.GameTitle = "Some Game";
            TestGame.Price = 11.99;
            TestGame.Discount = 20;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            AllGames.ThisGame = TestGame;
            PrimaryKey = AllGames.Add();
            TestGame.GameId = PrimaryKey;
            TestGame.GameTitle = "Another Game";
            TestGame.Price = 7.99;
            TestGame.Discount = 0;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            AllGames.ThisGame = TestGame;
            AllGames.Update();
            AllGames.ThisGame.Find(PrimaryKey);
            Assert.AreEqual(AllGames.ThisGame, TestGame);
        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            clsGame TestGame = new clsGame();
            int PrimaryKey = 0;
            TestGame.GameTitle = "Some Game";
            TestGame.Price = 11.99;
            TestGame.Discount = 20;
            TestGame.DatePublished = DateTime.Now.Date;
            TestGame.Active = true;
            AllGames.ThisGame = TestGame;
            PrimaryKey = AllGames.Add();
            TestGame.GameId = PrimaryKey;
            AllGames.ThisGame.Find(PrimaryKey);
            AllGames.Delete();
            bool Found = AllGames.ThisGame.Find(PrimaryKey);
            Assert.IsFalse(Found);
        }

        [TestMethod]
        public void ReportByGameTitle()
        {
            clsGamesCollection AllGames = new clsGamesCollection();
            clsGamesCollection FilteredGames = new clsGamesCollection();
            FilteredGames.ReportByGameTitle("");
            Assert.AreEqual(AllGames.Count, FilteredGames.Count);
        }

        [TestMethod]
        public void ReportByGameTitleNoneFound()
        {
            clsGamesCollection FilteredGames = new clsGamesCollection();
            FilteredGames.ReportByGameTitle("some game that doesn't exist");
            Assert.AreEqual(0, FilteredGames.Count);
        }
    }
}
