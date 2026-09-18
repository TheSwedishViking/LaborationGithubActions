using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Y2015D01.Tests
{
    public class SantaFloorTests
    {
  
        [Theory]
        [InlineData("(())", 0)]
        [InlineData("", 0)]
        [InlineData(")*))(  )7", -3)]
        [InlineData(")(a)()b", -1)]
        public void CountFloorLevels_ReturnsThree(string floors, int excpected)
        {
            //arrange

            //act
            var sut = new FloorCalculator();
            int result = sut.CountFloors(floors);

            //assert
            Assert.Equal(excpected, result);
        }

    }
}
