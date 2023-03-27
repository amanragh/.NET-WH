using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoQDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoQTestProject
{
    [TestClass]
    public class DemoTest
    {

        // Step 6. Add the definition of the mock objects
        public IUSD_CLP_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_CLP_ExchangeRateFeed> mockObject = new Mock<IUSD_CLP_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);
            return mockObject.Object;
        }
        // Step 7. Add the test methods for each test case
        [TestMethod]
        public void TC1_Divide9By3()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TC2_DivideByZero()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 0);
        }
        [TestMethod]
        public void TC3_ConvertUSDtoCLPTest()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoCLP(1);
            int expectedResult = 500;
            Assert.AreEqual(expectedResult, actualResult);
        }






        [TestMethod]
        public void TestGetSum()
        {
            int x = 9, y = 7;
            var result = GetSum(x, y);
            Assert.AreEqual(x + y, result);
            Assert.AreNotEqual(x - y, result);
        }


        private int GetSum(int x, int y)
        {
            return x + y;
        }

    }
}
