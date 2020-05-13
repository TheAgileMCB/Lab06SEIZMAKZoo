using Lab06Zoo.MythologicalCreatures.Interface;
using Lab06Zoo.MythologicalCreatures.Japanese;
using System;
using Xunit;

namespace Lab06Zoo.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Kitsune_Can_eat()
        {
            // Arrange
            Japanese fox = new Kitsune();

            // Act
            string actual = fox.Eats();

            // Assert
            Assert.Equal("berries", actual);

        }
    }
}
