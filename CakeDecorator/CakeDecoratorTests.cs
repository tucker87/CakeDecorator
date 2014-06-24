using Microsoft.VisualStudio.TestTools.UnitTesting;
using CakeDecorator;

namespace CakeDecorator
{
    [TestClass]
    public class CakeDecoratorTests
    {

        //Define bases
        [TestMethod]
        public void WhiteCakesPriceIsOne()
        {
            var whiteCake = new WhiteCake();
            Assert.AreEqual(1, whiteCake.GetPrice());
        }

        [TestMethod]
        public void ChocolateCakesPriceIsOneFifty()
        {
            var chocolateCake = new ChocolateCake();
            Assert.AreEqual(1.5, chocolateCake.GetPrice());
        }
        //Define Decorators
        [TestMethod]
        public void ChocolateCakeWithSprinklesIsTwoFifty()
        {
            var chocolateCake = new ChocolateCake();
            var chocolateCakeWithSprinkles = new Sprinkles(chocolateCake);
            Assert.AreEqual(2.5, chocolateCakeWithSprinkles.GetPrice());
        }

        [TestMethod]
        public void WhiteCakeWithSprinklesIsTwo()
        {
            var whiteCake = new WhiteCake();
            var whiteCakeWithSprinkles = new Sprinkles(whiteCake);
            Assert.AreEqual(2, whiteCakeWithSprinkles.GetPrice());
        }

        [TestMethod]
        public void WhiteCakeWithTopperIsThree()
        {
            var whiteCake = new WhiteCake();
            var whiteCakeWithTopper = new Topper(whiteCake);
            Assert.AreEqual(3, whiteCakeWithTopper.GetPrice());
        }

        //Adding field to test if it acts like methods

        [TestMethod]
        public void CakesHaveADescription()
        {
            var whiteCake = new WhiteCake();
            Assert.AreEqual("White Cake", whiteCake.Desc);
        }

        [TestMethod]
        public void ToppingsAddToTheDescription()
        {
            var chocolateCake = new ChocolateCake();
            var chocolateCakeWithSprinkles = new Sprinkles(chocolateCake);
            Assert.AreEqual("Chocolate Cake with Sprinkles", chocolateCakeWithSprinkles.Desc);
        }

        //Adding a field that the Toppings would only reference
        [TestMethod]
        public void CakesHaveNames()
        {
            var whiteCake = new WhiteCake();
            var cakeName = whiteCake.Name;
            Assert.AreEqual("W", cakeName);
        }

        [TestMethod]
        public void GetCakeNameReturnsCakeName()
        {
            var chocolateCake = new ChocolateCake();
            var cakeName = chocolateCake.GetCakeName();
            Assert.AreEqual("C", cakeName);
        }

        [TestMethod]
        public void GetCakeNameWorksWithToppings()
        {
            var whiteCake = new WhiteCake();
            var whiteCakeWithSprinkles = new Sprinkles(whiteCake);
            var cakeName = whiteCakeWithSprinkles.GetCakeName();
            Assert.AreEqual("WS", cakeName);
        }
    }
}
