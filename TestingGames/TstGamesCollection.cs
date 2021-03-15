﻿using System;
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

    }
}