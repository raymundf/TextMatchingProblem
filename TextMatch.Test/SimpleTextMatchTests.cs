using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TextMatch.Implementations;

namespace TextMatch.Test
{
    public class SimpleTextMatchTests
    {
        [TestFixture]
        public class FindMatchedPositionsTests
        {
            [Test]
            public void when_no_matches_should_return_empty_list()
            {
                var text = "The quick brown fox";
                var subText = "NOT FOUND";
                var textMatch = new SimpleTextMatch();

                var result = textMatch.FindMatchedPositions(text, subText);

                Assert.NotNull(result, "Result should not be null");
                Assert.True(result.Length == 0, "Result should be empty list");
            }

            [Test] 
            public void when_match_found_should_return_start_position()
            {
                var text = "The quick brown fox";
                var subText = "brown";
                var expectedResult = text.IndexOf("brown") + 1;
                var textMatch = new SimpleTextMatch();

                var result = textMatch.FindMatchedPositions(text, subText);

                //Assert.AreEqual(expectedResult, result.First(), "Result should return the position of sub text");
            }

            [Test]
            public void allows_multiple_matches()
            {
                var text = "The quick brown fox jumps over the lazy dog.";
                var subText = "The";
                var expectedResult = 2;
                var textMatch = new SimpleTextMatch();

                var result = textMatch.FindMatchedPositions(text, subText);

                Assert.True(result.Length == expectedResult, "Should return list of position matched");
            }
        }

    }
}
