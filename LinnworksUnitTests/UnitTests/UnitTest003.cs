using LinnworksTest.DataAccess;
using NUnit.Framework;



namespace UnitTest
{
    [TestFixture]
    public class TestProductClass
    {
       
        Product product;
        string testStepName;

        [SetUp]
        public void Setup()
        {
            product = new Product();
            testStepName = TestContext.CurrentContext.Test.Name;
            System.Console.WriteLine("***** STARTING TEST STEP:- " + testStepName + " *****");
        }
 

        [Test]
        public void UnitTest003_Test_Product_Class_And_Structure()
        {
            Assert.That(product.StockLevel, Is.EqualTo(0));

            product.StockLevel++;

            Assert.Multiple(() =>
            {
                Assert.That(product.StockLevel, Is.EqualTo(1));
                Assert.That(product.StockLevel, Is.InstanceOf<int>());
                Assert.That(product.StockLevel, Is.Not.Null);
            });

            Assert.Pass(testStepName + " : is passed");
        }


        [TearDown()]
        public void Tear_Down()
        {
            product = null;

        }


     
    }
}