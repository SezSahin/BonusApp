using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BonusApp;

namespace BonusAppTest
{
    [TestClass]
    public class UnitTest1
    {
        Order O = new Order();
        Bonuses B = new Bonuses();

        [TestInitialize]
        public void Init()
        {
            Product TeddyBear = new Product { Name = "Teddy Bear", Value = 1.5 };
            Product BuildingBlocks = new Product { Name = "Building Blocks", Value = 4.0};
            Product WhiteRider = new Product { Name = "White Rider", Value = 7.5 };

            O.AddProduct(TeddyBear);
            O.AddProduct(BuildingBlocks);
            O.AddProduct(WhiteRider);
        }
        [TestMethod]
        public void TenPercent_Test()
        {
            Assert.AreEqual(0.15, B.TenPercent(1.5));
            Assert.AreEqual(0.4, B.TenPercent(4.0));
            Assert.AreEqual(0.75, B.TenPercent(7.5));
        }
        [TestMethod]
        public void FlatTwoIfAMountMoreThanFive_Test()
        {
            Assert.AreEqual(0.0, B.FlatTwoIfAmountMoreThanFive(1.5));
            Assert.AreEqual(0.0, B.FlatTwoIfAmountMoreThanFive(1.0));
            Assert.AreEqual(2.0, B.FlatTwoIfAmountMoreThanFive(7.5));
        }
        [TestMethod]
        public void GetValueOfProducts_Test()
        {
            Assert.AreEqual(13, O.GetValueOfProducts());
        }
        [TestMethod]
        public void GetBonus_Test()
        {
            O.Bonus = new DG_BonusProvider(B.TenPercent);
            Assert.AreEqual(1.3, O.GetBonus(), 0.001);

            O.Bonus = B.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(2.0, O.GetBonus(), 0.001);
        }
        [TestMethod]
        public void GetTotalPrice_Test()
        {
            O.Bonus = new DG_BonusProvider(B.TenPercent);
            Assert.AreEqual(14.3, O.GetTotalPrice(), 0.001);

            O.Bonus = B.FlatTwoIfAmountMoreThanFive;
            Assert.AreEqual(15, O.GetTotalPrice(), 0.001);
        }
    }
}
