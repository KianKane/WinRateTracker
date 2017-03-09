using System;

namespace WinRateTracker.Calculation
{
    public class Statistics
    {
        public static double CalculateWinRate(int wins, int losses)
        {
            if (wins < 0 || losses < 0)
                throw new ArgumentOutOfRangeException();
            return (double)wins / (losses > 0 ? losses : 1);
        }
    }
}
