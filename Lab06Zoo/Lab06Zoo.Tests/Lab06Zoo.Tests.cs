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
            Kitsune creature = new Kitsune();
    
            // Act
            string actual = creature.Eats();

            // Assert
            Assert.Equal("berries", actual);

        }

        [Fact]
        public void Kappa_Can_eat()
        {
            // Arrange
            Kappa creature = new Kappa();

            // Act
            string actual = creature.Eats();

            // Assert
            Assert.Equal("cucumber", actual);

        }
    }
}
