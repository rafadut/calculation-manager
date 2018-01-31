using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_Test()
        {
            CalculationManager manager = new CalculationManager();
            Assert.IsTrue(manager.Add(2, 2).Equals(4), "2 + 2 = 4");
            Assert.IsTrue(manager.Add(2, 2.5).Equals(4.5), "2 + 2.5 = 4.5");
            try { manager.Add(DateTime.Now, 2.5); }
            catch (Exception ex)
            {
                Assert.IsInstanceOfType(ex,
                    typeof(InvalidCastException), "Today + 2 = oops");
            }
        }

        [TestMethod]
        public void Index_Test()
        {
            //CalculationController controller = new CalculationController();
            //Assert.IsInstanceOfType(controller.Index(), typeof(ExpectedViewResult));
        }

        [TestMethod]
        public void TestAdd()
        {
            //// Create the fake calculator:
            //ICalculator calculator = new Calculator.Fakes.StubICalculator()
            //{
            //    // Define each method:
            //    Add = (a, b) => { return 25; }
            //};
            //// In the completed application, item would be a real one:
            //var item = new Mathematics(calculator);
            //   double added = item.AddNumbers();
            //Assert.AreEqual(25, added);
        }
    }
}
