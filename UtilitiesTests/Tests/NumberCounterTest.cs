﻿using NUnit.Framework;
using Utilities;
using Utilities.Interfaces;

namespace InterviewTests
{
    [TestFixture]
    public class NumberCounterTest
    {
        [TestCase("1", 1)]
        [TestCase("1x", 1)]
        [TestCase("999x", 3)]
        [TestCase("abc1234x", 4)]
        [TestCase(" / * 4 ttt 8|", 2)]
        public void CountNumbers(string input, int expectedCount)
        {
            
        }
    }
}