using LinnworksTest.DataAccess;
using NUnit.Framework;
using System;



namespace UnitTest
{
    [TestFixture]
    public class TestCategoryClass
    {
        
        Category category;
        string testStepName;
 
        [SetUp]
        public void Setup()
        {
            category = new Category();
            testStepName = TestContext.CurrentContext.Test.Name;
            System.Console.WriteLine("***** STARTING TEST STEP:- " + testStepName + " *****");
        }
 

   
        [Test]
        public void UnitTest002_Test_Category_Class_And_Structure()
        {
            Guid id = Guid.NewGuid();
            category.Id = id;

            Assert.Multiple(() =>
            {
                Assert.That(category.Id, Is.EqualTo(id));
                Assert.That(category.Id, Is.Not.Null);
                Assert.That(category.Id, Is.InstanceOf<Guid>());
            });
            Assert.Pass(testStepName + " : is passed");
        }



        [TearDown()]
        public void Tear_Down()
        {
            category = null;

        }


    
    }
}