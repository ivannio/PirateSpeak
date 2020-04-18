using System;
using System.Collections.Generic;
using Xunit;
using PirateSpeak;


namespace PirateSpeakTest
{
    public class UnitTest1
    {
        
        [Fact]
        public void Test1()
        {
            var translator = new Translator();

            // Arrange
            var jumbledLetters = "ortsp";
            var possibleWords = new List<string>() { "sport", "parrot", "ports", "matey" };
            var expectedResult = new List<string>() { "sport", "ports" };

            // Act
            var actualResult = translator.Translate(jumbledLetters, possibleWords);

            // Assert
            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        public void Test2()
        {
            var translator = new Translator();

            // Arrange
            var jumbledLetters = "otp";
            var possibleWords = new List<string>() { "spot", "top", "pots", "pot" };
            var expectedResult = new List<string>() { "top", "pot" };

            // Act
            var actualResult = translator.Translate(jumbledLetters, possibleWords);

            // Assert
            Assert.Equal(actualResult, expectedResult);
        }

        [Fact]
        public void Test3()
        {
            var translator = new Translator();

            // Arrange
            var jumbledLetters = "mrat";
            var possibleWords = new List<string>() { "mart", "mark", "tram", "mattress" };
            var expectedResult = new List<string>() { "mart", "tram" };

            // Act
            var actualResult = translator.Translate(jumbledLetters, possibleWords);

            // Assert
            Assert.Equal(actualResult, expectedResult);
        }
    }
}
