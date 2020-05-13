using Lab06Zoo.MythologicalCreatures.Greek;
using Lab06Zoo.MythologicalCreatures.Interface;
using Lab06Zoo.MythologicalCreatures.Japanese;
using Lab06Zoo.MythologicalCreatures.Norse;
using System;
using Xunit;

namespace Lab06Zoo.Tests
{
    public class EatTests
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
            Assert.Equal("cucumbers", actual);

        }
    }

    public class SoundTests
    {
        [Fact]
        public void Jormungandr_Can_sound()
        {
            // Arrange
            Jormungandr creature = new Jormungandr();

            // Act
            string actual = creature.MakeSound();

            // Assert
            Assert.Equal("Ssssss!", actual);

        }

        [Fact]
        public void Pegasus_Can_sound()
        {
            // Arrange
            Pegasus creature = new Pegasus();

            // Act
            string actual = creature.MakeSound();

            // Assert
            Assert.Equal("Neigh!", actual);

        }

        public class RideTests
        {
            [Fact]
            public void Can_ride_Sleipnir()
            {
                // Arrange
                Sleipnir creature = new Sleipnir();

                // Act
                Assert.True(creature.CanRide());

                // Assert
                

            }

            [Fact]
            public void Can_ride_Jormungandr()
            {
                // Arrange
                Jormungandr creature = new Jormungandr();

                // Act
                Assert.False(creature.CanRide());

                // Assert


            }
        }
    }
}
