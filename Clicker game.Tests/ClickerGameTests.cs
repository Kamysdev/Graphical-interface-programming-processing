using Clicker_game.Data;

namespace Clicker_game.Tests
{
    [TestClass]
    public class ClickerGameTests
    {
        [TestMethod]
        public void BigNumber_Add_999and999_1998returned()
        {
            BigNumber num1 = new BigNumber("999");
            BigNumber num2 = new BigNumber("999");
            string expected = "1998";

            num1.Add(num2);

            Assert.AreEqual(expected, num1.GetStringNumber());
        }

        [TestMethod]
        public void BigNumber_Multiply_123456and654321_80779853376returned()
        {
            BigNumber num1 = new BigNumber("123456");
            BigNumber num2 = new BigNumber("654321");
            string expected = "80779853376";

            num1.Multiply(num2);

            Assert.AreEqual(expected, num1.GetStringNumber());
        }

        [TestMethod]
        public void BigNumber_Subtract_9900112and55430_9844682returned()
        {
            BigNumber num1 = new BigNumber("12345");
            BigNumber num2 = new BigNumber("23");
            string expected = "12322";

            num1.Subtract(num2);

            Assert.AreEqual(expected, num1.GetStringNumber());
        }

        [TestMethod]
        public void BigNumbers_Divide_8884499and13_683423returned()
        {
            BigNumber num1 = new BigNumber("8884499");
            BigNumber num2 = new BigNumber("13");
            string expected = "683423";

            num1.Divide(num2);

            Assert.AreEqual(expected, num1.GetStringNumber());
        }
    }
}