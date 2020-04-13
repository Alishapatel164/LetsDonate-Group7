using NUnit.Framework;
using AutomationDemo;

namespace DemoTest
{
    class IntegrationTest
    {
        [Test]
        public void ParseAnswer_UnparseableAnswer_InvalidResponse()
        {
            // arrange
            string answer = "    ";
            Parser.Response expected =Parser.Response.Invalid;

            // act
            Parser sut = new Parser();
            Parser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseAnswer_InvalidAnswer_InvalidResponse()
        {
            // arrange
            string answer = "Hello";
           Parser.Response expected = Parser.Response.Invalid;

            // act
            Parser sut = new Parser();
            Parser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseAnswer_YesAnswer_AffirmativeResponse()
        {
            // arrange
            string answer = "Yes";
            Parser.Response expected = Parser.Response.Affirmative;

            // act
            Parser sut = new Parser();
            Parser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void ParseAnswer_NoAnswer_NegativeResponse()
        {
            // arrange
            string answer = "No";
            Parser.Response expected = Parser.Response.Negative;

            // act
            Parser sut = new Parser();
            Parser.Response actual = sut.ParseAnswer(answer);

            // assert
            Assert.AreEqual(expected, actual);
        }

    }
}

