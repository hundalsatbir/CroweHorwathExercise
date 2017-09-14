using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalExerciseTest
{
    [TestClass]
    public class ValuesControllerTests
    {
        [TestMethod]
        public void TestInitilization()
        {
            TechnicalExercise.Controllers.ValuesController valuesController = new TechnicalExercise.Controllers.ValuesController(new TechnicalExercise.Data.StaticHelloWorldRepository());
            Assert.IsNotNull(valuesController);
        }

        [TestMethod]
        public void TestGet()
        {
            TechnicalExercise.Controllers.ValuesController valuesController = new TechnicalExercise.Controllers.ValuesController(new TechnicalExercise.Data.StaticHelloWorldRepository());
            var result = valuesController.Get();
            Assert.AreEqual("Hello World", result);
        }


        [TestMethod]
        public void TestPost()
        {
            TechnicalExercise.Controllers.ValuesController valuesController = new TechnicalExercise.Controllers.ValuesController(new TechnicalExercise.Data.StaticHelloWorldRepository());
            valuesController.Post("Hi");
            Assert.IsNotNull(valuesController);
        }
    }
}
