using NUnit.Framework;
using AutomationDemo;
using DataModels;

namespace DemoTest
{
    public class Tests
    {
           [Test]
            public void IsParseable_ZeroLengthInput_ReturnsFalse()
            {
            // arrange
            string input = " ";
                bool expected = false;

                // act
                Parser ps = new Parser();
                bool actual = ps.IsParseable(input);

                // assert
                Assert.AreEqual(expected, actual);

            }

        [Test]
        public void IsParseable_OneLengthInput_ReturnsTrue()
        {
            // arrange
            string input = "a";
            bool expected = true;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsParseable(input);

            // assert
            Assert.AreEqual(expected, actual);

        }


        [Test]
        public void IsParseable_OneSpaceInput_ReturnsFalse()
        {
            // arrange
            string input = " ";
            bool expected = false;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsParseable(input);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void IsAffirmative_NotAffirmative_ReturnsFalse()
        {
            // arrange
            string input = "Hello";
            bool expected = false;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase("Yes")]
        [TestCase("YES")]
        [TestCase("yes")]
        [TestCase("yes ")]
        public void IsAffirmative_YesValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

       
        [TestCase("Y")]
        [TestCase("y")]
        [TestCase("y ")]
        public void IsAffirmative_YValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsAffirmative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        
        [Test]
        public void IsNegative_NotNegative_ReturnsFalse()
        {
            // arrange
            string input = "Hello";
            bool expected = false;

            // act
           Parser sut = new Parser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);

        }

        [TestCase("No")]
        [TestCase("NO")]
        [TestCase("no")]
        [TestCase("no ")]
        public void IsNegative_NoValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

        
        [TestCase("N")]
        [TestCase("n")]
        [TestCase("n ")]
        public void IsNegative_NValue_ReturnsTrue(string input)
        {
            // arrange
            bool expected = true;

            // act
            Parser sut = new Parser();
            bool actual = sut.IsNegative(input);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
    }
