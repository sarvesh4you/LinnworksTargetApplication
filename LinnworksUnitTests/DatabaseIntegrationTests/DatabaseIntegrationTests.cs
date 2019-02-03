using LinnworksTest.Controllers;
using LinnworksTest.DataAccess;
using Moq;
using NUnit.Framework;
using System;
using static LinnworksTest.Controllers.AuthController;

namespace DatabaseIntegrationTests
{

    public class TestController
    {
        
        string _testStepName;
        private readonly ITokenRepository tokenRepository;
        private readonly IGenericRepository<LinnworksTest.DataAccess.Category> categoryRepository;
        Account account;
        Guid guid;


        [SetUp]
        public void Setup()
         {
            account = new Account();
            guid = Guid.NewGuid();
            guid = Guid.Parse("bccf905c-6592-40f2-8db1-c976791fa40a");
            account.Token = "bccf905c-6592-40f2-8db1-c976791fa40a";
  
          
            _testStepName = TestContext.CurrentContext.Test.Name;
            System.Console.WriteLine("***** STARTING TEST STEP:- " + _testStepName + " *****");
        }
 

        [Test]
        public async System.Threading.Tasks.Task Test000_Demo_TestAsync()
        {

            // Arrange
            var mockRepo = new Mock<ITokenRepository>();
            //mockRepo.Setup(repo => repo.IsValidTokenAsync(guid))
            //      .ReturnsAsync(true);
            var controller = new AuthController(mockRepo.Object);
           // var controller2 = new CategoryController(categoryRepository);
            var result = controller.Ok();

            var result1 = await controller.Login(account);
            //controller.Configuration = new HttpConfiguration();
            Assert.IsNotNull(result1);
            
            System.Console.WriteLine(result1.GetType());
     
           // Assert.That(result1, Is.InstanceOf<OkResult>());

        }

        Product GetDemoProduct()
        {
            // return new Product() { account.Token = guid };
            return null;
        }


        [TearDown()]
        public void Tear_Down()
        {
           

        }

    }
}