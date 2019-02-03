using LinnworksTest;
using NUnit.Framework;



namespace UnitTest
{
    [TestFixture]
    public class TestTutorialClass
    {
        Tutorial testTutorial; 
        string _testStepName;
     


        [SetUp]
        public void Setup()
        {
            testTutorial = new Tutorial();
            _testStepName = TestContext.CurrentContext.Test.Name;
            System.Console.WriteLine("***** STARTING TEST STEP:- " + _testStepName + " *****");
        }
 

        [Test]
        public void UnitTest001_Demo_Test()
        {
           
            Assert.AreEqual(testTutorial.Name, "Sarvesh - ASP.Net");
            Assert.Pass(_testStepName+" : is passed");
        }

        [TearDown()]
        public void Tear_Down()
        {
            testTutorial = null;

        }

    }
}