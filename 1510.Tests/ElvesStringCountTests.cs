using _1510.Calculation;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace _1510.Tests
{
    public class ElvesStringCountTests
    {
        [Fact]
        public void CountNumbersInSentence_ElvesSay_TwoOnes_Returns_ATwoAndAOne()
        {
            //A
            string inputSequence = "11";
            string expected = "21";

            //Act
            var sut = new WordCounter();
            string actual = sut.CountNumberSequence(inputSequence);

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData("111221", "312211")]
        [InlineData("1211", "111221")]
        [InlineData("555", "35")]
        [InlineData("555z22", "3522")]
        [InlineData("12     11", "111221")]
        [InlineData("", "")]
        [InlineData("KORV1244122", "1112241122")]
        [InlineData("BANANANANANNANANANANNANA", "")]
        [InlineData("*12*0002", "11123012")]


        public void CountRepeatingNumbers_InSequence_ReturnStringInPairs_InElfSpeech(string sequence, string expected)
        {

            var sut = new WordCounter();
            string actual = sut.CountNumberSequence(sequence);

            Assert.Equal(expected, actual);

        }

        
    }
}
