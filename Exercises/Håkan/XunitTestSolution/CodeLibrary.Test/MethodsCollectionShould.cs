using System;
using Xunit;

namespace CodeLibrary.Test
{
    public class MethodsCollectionShould
    {
        [Fact]
        public void Kommentar()
        {
            // Arrange
               // Instansierar de klasser som beh�vs f�r testet
            // Act
               // Utf�r sj�lva testet
            // Assert
               // Validerar att resultatet av testet blev som f�rv�ntat
        }

        [Fact]
        public void TestAdd()
        {
            // Arrange
            MethodsCollection metods = new MethodsCollection();
            // Act
            int result = metods.Add(1, 2);
            // Assert
            Assert.Equal(3, result);
        }

        [Theory]
        [InlineData(3, 4, 7)]
        [InlineData(5, 6, 11)]
        public void TestAdd2(int a, int b, int expected)
        {
            // Arrange
            MethodsCollection metods = new MethodsCollection();
            // Act
            int result = metods.Add(a, b);
            // Assert
            Assert.Equal(expected, result);
        }
    }
}
