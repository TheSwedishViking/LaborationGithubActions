using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _1901.Tests
{
    public class CalculateRocketfuelTest
    {
        [Theory]
        [InlineData(12,2)]
        [InlineData(14, 2)]
        [InlineData(1969, 654)]
        [InlineData(100756, 33583)]
        [InlineData(0, 0)]
        [InlineData(-5000, 0)]
        [InlineData(null, 0)]

        public void ModulWeightIsTwelve_DivideByThreeMinusTwo_RounDownNumbers_ExcpectedResultIsTwo(int? weight, int excpected)
        {
            //Arrange
            var sut = new FuelCalculator();
            //Act
            int actualResult = sut.GetRequiredFuel(weight);

            //Assert

            Assert.Equal(excpected, actualResult);
        }
        [Theory]
        [InlineData(100756, 50346)]
        public void CalculateTotalFuelRequirment_IncludingFuelForTheFuel_Until_ReachingNegativesOrZero_ReturnsTotalSumOfFuelRequired(int weight, int expected)
        {
            //A
            var sut = new FuelCalculator();

            //A
            int actual = sut.GetRequiredFuelncludingFuelForFuel(weight);

            //A
            Assert.Equal(actual, expected);
        }

    }
}
