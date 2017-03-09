using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WinRateTracker.Calculation;

namespace WinRateTrackerTests
{
    [TestClass]
    public class StatisticsTests
    {
        [TestMethod]
        public void CalculateWinRate_Typical()
        {
            int wins = 25;
            int losses = 50;
            double expected = 0.50;
            double actual = Statistics.CalculateWinRate(wins, losses);
            Assert.AreEqual(expected, actual, 0.004);
        }

        [TestMethod]
        public void CalculateWinRate_NonTerminating()
        {
            int wins = 1;
            int losses = 3;
            double expected = 0.333;
            double actual = Statistics.CalculateWinRate(wins, losses);
            Assert.AreEqual(expected, actual, 0.004);
        }

        [TestMethod]
        public void CalculateWinRate_LargeNumbers()
        {
            int wins = 513215;
            int losses = 541242;
            double expected = 0.948;
            double actual = Statistics.CalculateWinRate(wins, losses);
            Assert.AreEqual(expected, actual, 0.004);
        }

        [TestMethod]
        public void CalculateWinRate_ZeroWins()
        {
            int wins = 0;
            int losses = 35;
            double expected = 0.00;
            double actual = Statistics.CalculateWinRate(wins, losses);
            Assert.AreEqual(expected, actual, 0.004);
        }

        [TestMethod]
        public void CalculateWinRate_ZeroLosses()
        {
            int wins = 35;
            int losses = 0;
            double expected = 35.00;
            double actual = Statistics.CalculateWinRate(wins, losses);
            Assert.AreEqual(expected, actual, 0.004);
        }

        [TestMethod]
        public void CalculateWinRate_ZeroWinsAndLosses()
        {
            int wins = 0;
            int losses = 0;
            double expected = 0.00;
            double actual = Statistics.CalculateWinRate(wins, losses);
            Assert.AreEqual(expected, actual, 0.004);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateWinRate_NegativeWins()
        {
            int wins = -25;
            int losses = 50;
            double actual = Statistics.CalculateWinRate(wins, losses);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateWinRate_NegativeLosses()
        {
            int wins = 50;
            int losses = -25;
            double actual = Statistics.CalculateWinRate(wins, losses);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CalculateWinRate_NegativeWinsAndLosses()
        {
            int wins = -25;
            int losses = -25;
            double actual = Statistics.CalculateWinRate(wins, losses);
        }
    }
}
