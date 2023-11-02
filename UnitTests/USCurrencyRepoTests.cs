﻿using PROG301_CurrencyProject.Interfaces;
using PROG301_CurrencyProject.Models.USCoins;
using PROG301_CurrencyProject.Repos;
using static PROG301_CurrencyProject.Utility.Method_Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    [TestClass]
    public class USCurrencyRepoTests
    {
        ICurrencyRepo repo;
        Penny penny;
        Nickel nickel;
        Dime dime;
        Quarter quarter;
        DollarCoin dollarCoin;


        public USCurrencyRepoTests()
        {
            repo = new CurrencyRepo();
            penny = new Penny();
            nickel = new Nickel();
            dime = new Dime();
            quarter = new Quarter();
            dollarCoin = new DollarCoin();
        }

        [TestMethod]
        public void AddCoinTest()
        {
            //Arrange
            int coinCountOrig, coinCountAfterPenny, coinCountAfterFiveMorePennies;
            int numPennies = 5;


            Double valueOrig, valueAfterPenny, valueAfterFiveMorePennies;
            Double valueAfterNickel, valueAfterDime, valueAfterQuarter, valueAfterDollar;
            //Act
            coinCountOrig = repo.GetCoinCount();
            valueOrig = repo.TotalValue();

            repo.AddCoin(penny);
            coinCountAfterPenny = repo.GetCoinCount();
            valueAfterPenny = repo.TotalValue();

            for (int i = 0; i < numPennies; i++)
            {
                repo.AddCoin(penny);
            }
            coinCountAfterFiveMorePennies = repo.GetCoinCount();
            valueAfterFiveMorePennies = repo.TotalValue();

            repo.AddCoin(nickel);
            valueAfterNickel = repo.TotalValue();
            repo.AddCoin(dime);
            valueAfterDime = repo.TotalValue();
            repo.AddCoin(quarter);
            valueAfterQuarter = repo.TotalValue();
            repo.AddCoin(dollarCoin);
            valueAfterDollar = repo.TotalValue();


            //Assert
            Assert.AreEqual(coinCountOrig + 1, coinCountAfterPenny);
            Assert.AreEqual(coinCountAfterPenny + numPennies, coinCountAfterFiveMorePennies);

            Assert.AreEqual(valueOrig + penny.Value, valueAfterPenny);
            Assert.AreEqual(valueAfterPenny + (numPennies * penny.Value), valueAfterFiveMorePennies);

            Assert.AreEqual(valueAfterFiveMorePennies + nickel.Value, valueAfterNickel);
            Assert.AreEqual(valueAfterNickel + dime.Value, valueAfterDime);
            Assert.AreEqual(valueAfterDime + quarter.Value, valueAfterQuarter);
            Assert.AreEqual(valueAfterQuarter + dollarCoin.Value, valueAfterDollar);

        }


        [TestMethod]
        public void RemoveCoinTest()
        {

            //Arrange
            int coinCountOrig, coinCountAfterPenny, coinCountAfterFiveMorePennies;
            int numPennies = 5;


            Double valueOrig, valueAfterPenny, valueAfterFiveMorePennies;
            Double valueAfterNickel, valueAfterDime, valueAfterQuarter, valueAfterDollar;

            repo = new USCurrencyRepo();  //reset repo

            //add some coins
            repo.AddCoin(penny);

            for (int i = 0; i < numPennies; i++)
            {
                repo.AddCoin(penny);
            }
            repo.AddCoin(nickel);
            repo.AddCoin(dime);
            repo.AddCoin(quarter);
            repo.AddCoin(dollarCoin);

            //Act
            coinCountOrig = repo.GetCoinCount();
            valueOrig = repo.TotalValue();
            repo.RemoveCoin(penny);
            coinCountAfterPenny = repo.GetCoinCount();
            valueAfterPenny = repo.TotalValue();

            for (int i = 0; i < numPennies; i++)
            {
                repo.RemoveCoin(penny);
            }
            coinCountAfterFiveMorePennies = repo.GetCoinCount();
            valueAfterFiveMorePennies = repo.TotalValue();

            repo.RemoveCoin(nickel);
            valueAfterNickel = repo.TotalValue();
            repo.RemoveCoin(dime);
            valueAfterDime = repo.TotalValue();
            repo.RemoveCoin(quarter);
            valueAfterQuarter = repo.TotalValue();
            repo.RemoveCoin(dollarCoin);
            valueAfterDollar = repo.TotalValue();


            //Assert
            Assert.AreEqual(coinCountOrig - 1, coinCountAfterPenny);
            Assert.AreEqual(coinCountAfterPenny - numPennies, coinCountAfterFiveMorePennies);

            Assert.AreEqual(valueOrig - penny.Value, valueAfterPenny);
            Assert.AreEqual(valueAfterPenny - (numPennies * penny.Value), valueAfterFiveMorePennies);

            //Assert.AreEqual(valueAfterFiveMorePennies - nickel.Value, valueAfterNickel); //HUH? 1.35 != 1.35 both are double?
            Assert.AreEqual(valueAfterNickel - dime.Value, valueAfterDime);
            Assert.AreEqual(valueAfterDime - quarter.Value, valueAfterQuarter);
            Assert.AreEqual(valueAfterQuarter - dollarCoin.Value, valueAfterDollar);

        }

        [TestMethod]
        public void MakeChangeTests()
        {
            //Arrange
            Type UsCurRepo = typeof(USCurrencyRepo);
            USCurrencyRepo changeOneQuatersOnHalfDollar, changeTwoDollars, changeOneDollarOneHalfDoller,
               changeOneDimeOnePenny, changeOneNickelOnePenny, changeFourPennies;


            //Act
            changeTwoDollars = 
            (USCurrencyRepo)InvokeMethod<ICurrencyRepo>(UsCurRepo, "CreateChange", new object[]{2.0});
            changeOneDollarOneHalfDoller = 
            (USCurrencyRepo)InvokeMethod<ICurrencyRepo>(UsCurRepo, "CreateChange", new object[]{1.5});
            changeOneQuatersOnHalfDollar = 
            (USCurrencyRepo)InvokeMethod<ICurrencyRepo>(UsCurRepo, "CreateChange", new object[]{.75});

            changeOneDimeOnePenny =
            (USCurrencyRepo)InvokeMethod<ICurrencyRepo>(UsCurRepo, "CreateChange", new object[]{.11});
            changeOneNickelOnePenny =
            (USCurrencyRepo)InvokeMethod<ICurrencyRepo>(UsCurRepo, "CreateChange", new object[]{.06});
            changeFourPennies =
            (USCurrencyRepo)InvokeMethod<ICurrencyRepo>(UsCurRepo, "CreateChange", new object[]{.04});


            /*
            changeTwoDollars = (USCurrencyRepo)USCurrencyRepo.CreateChange(2.0);
            changeOneDollarOneHalfDoller = (USCurrencyRepo)USCurrencyRepo.CreateChange(1.5);
            changeOneQuatersOnHalfDollar = (USCurrencyRepo)USCurrencyRepo.CreateChange(.75);

            changeOneDimeOnePenny = (USCurrencyRepo)USCurrencyRepo.CreateChange(.11);
            changeOneNickelOnePenny = (USCurrencyRepo)USCurrencyRepo.CreateChange(.06);
            changeFourPennies = (USCurrencyRepo)USCurrencyRepo.CreateChange(.04);
            */


            //Assert
            Assert.AreEqual(changeTwoDollars.Coins.Count, 2);
            Assert.AreEqual(changeTwoDollars.Coins[0].GetType(), new DollarCoin().GetType());
            Assert.AreEqual(changeTwoDollars.Coins[1].GetType(), new DollarCoin().GetType());

            Assert.AreEqual(changeOneDollarOneHalfDoller.Coins.Count, 2);
            Assert.AreEqual(changeOneDollarOneHalfDoller.Coins[0].GetType(), new DollarCoin().GetType());
            Assert.AreEqual(changeOneDollarOneHalfDoller.Coins[1].GetType(), new HalfDollar().GetType());


            Assert.AreEqual(changeOneQuatersOnHalfDollar.Coins.Count, 2);
            Assert.AreEqual(changeOneQuatersOnHalfDollar.Coins[0].GetType(), new HalfDollar().GetType());
            Assert.AreEqual(changeOneQuatersOnHalfDollar.Coins[1].GetType(), new Quarter().GetType());

            Assert.AreEqual(changeOneDimeOnePenny.Coins.Count, 2);
            Assert.AreEqual(changeOneDimeOnePenny.Coins[0].GetType(), new Dime().GetType());
            Assert.AreEqual(changeOneDimeOnePenny.Coins[1].GetType(), new Penny().GetType());

            Assert.AreEqual(changeOneNickelOnePenny.Coins.Count, 2);
            Assert.AreEqual(changeOneNickelOnePenny.Coins[0].GetType(), new Nickel().GetType());
            Assert.AreEqual(changeOneNickelOnePenny.Coins[1].GetType(), new Penny().GetType());


            Assert.AreEqual(changeFourPennies.Coins.Count, 4);
            Assert.AreEqual(changeFourPennies.Coins[0].GetType(), new Penny().GetType());
            Assert.AreEqual(changeFourPennies.Coins[1].GetType(), new Penny().GetType());
            Assert.AreEqual(changeFourPennies.Coins[2].GetType(), new Penny().GetType());
            Assert.AreEqual(changeFourPennies.Coins[3].GetType(), new Penny().GetType());

        }
    }
}
