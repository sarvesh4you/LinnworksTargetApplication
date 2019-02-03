using LinnworksTest.Models;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class TestCategotyWithStockClass
    {
        string testStepName;
        CategoryWithStock catWithStock;

        [SetUp]
        public void Setup()
        {
            catWithStock = new CategoryWithStock();
            testStepName = TestContext.CurrentContext.Test.Name;
            System.Console.WriteLine("***** STARTING TEST STEP:- " + testStepName + " *****");
        }


        [Test]
        public void UnitTest005_Test_CategoryWithStock_Class_And_Structure()
        {
          

            Assert.That(catWithStock.Stock, Is.EqualTo(0));

            catWithStock.Stock++;
            Assert.Multiple(() =>
            {
                Assert.That(catWithStock.Stock, Is.EqualTo(1));
                Assert.That(catWithStock.Stock, Is.InstanceOf<int>());
                Assert.That(catWithStock.Stock, Is.Not.Null);
            });

            Assert.Pass(testStepName + " : is passed");
        }

        [TearDown()]
        public void Tear_Down()
        {
            catWithStock = null;

        }
    }
}