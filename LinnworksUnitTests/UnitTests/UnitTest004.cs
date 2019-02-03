using LinnworksTest.DataAccess;
using NUnit.Framework;
using System;



namespace UnitTest
{
    [TestFixture]
    public class TestTokenClass
    {
        string testStepName;
        Token token;

        [SetUp]
        public void Setup()
        {
            token = new Token();
            testStepName = TestContext.CurrentContext.Test.Name;
            System.Console.WriteLine("***** STARTING TEST STEP:- " + testStepName + " *****");
        }


        [Test]
        public void UnitTest004_Test_Token_Class_And_Structure()
        {
            Guid val = Guid.NewGuid();
            token.Value = val;
            token.Id = val;

            Assert.Multiple(() =>
            {
                Assert.That(token.Value, Is.EqualTo(val));
                Assert.That(token.Id, Is.EqualTo(val));
                Assert.That(token.Id, Is.InstanceOf<Guid>());
                Assert.That(token.Value, Is.InstanceOf<Guid>());
            });

            Assert.Pass(testStepName + " : is passed");
        }

        [TearDown()]
        public void Tear_Down()
        {
            token = null;

        }
    }
}