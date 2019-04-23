using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MonkeyBusiness;

namespace MonkeyBusinessTests
{
    [TestClass]
    public class MonkeyTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Monkey_NegativeAge_ThrowsException()
        {
            // Arrange
            string name = "UnbornMonkey";
            int invalidAge = -23;
            string favouriteFood = "Chocolate";

            // Act
            Monkey monkey = new Monkey(name, invalidAge);

            // Assert - this is handled by the ExpectedException

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Monkey_ExcessiveAge_ThrowsException()
        {
            // Arrange
            string name = "ImpossiblyOldMonkey";
            int invalidAge = 100;
            string favouriteFood = "Chocolate";

            // Act
            Monkey monkey = new Monkey(name, invalidAge);

            // Assert - this is handled by the ExpectedException
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Monkey_BlankName_ThrowsException()
        {
            // Arrange
            string name = "    ";
            int age = 5;
            string favouriteFood = "Chocolate";

            // Act
            Monkey monkey = new Monkey(name, age);

            // Assert - this is handled by the ExpectedException
        }

        [TestMethod]
        public void Monkey_RemovingBananaFromFavouriteFoods_IsNotAllowed()
        {
            // Arrange
            string name = "Banana Hating Monkey";
            int age = 10;
            string favouriteFood = "Strawberry";
            string newFavouriteFood = "Banana";

            // Act
            Monkey monkey = new Monkey(name, age);
            monkey.AddFavouriteFood(newFavouriteFood);
            monkey.RemoveFavouriteFood(newFavouriteFood);

            // Assert 
            Assert.IsTrue(monkey.IsFavouriteFood(newFavouriteFood));
        }
    }
}
