using System;

namespace Practice
{
    [Serializable]
    public static class StatisticalCharacteristics
    {
        public static double SupportExpactationValue;
        public static double ExpectationValue(int FactorChosen, double[,] ArrayForExpValue)
        {
            double ExpectValue = 0;
            for (int i = 300; i < ArrayForExpValue.GetLength(1) - 1; i++)
                ExpectValue = ExpectValue + ArrayForExpValue[FactorChosen, i];
            SupportExpactationValue = ExpectValue / (ArrayForExpValue.GetLength(1) - 301);
            return SupportExpactationValue;
        }
        public static double Variance(int FactorChosen, double[,] ArrayForExpValue)
        {
            double Dispersion = 0;
            for (int i = 300; i < ArrayForExpValue.GetLength(1) - 1; i++)
                Dispersion = Dispersion + Math.Pow((ArrayForExpValue[FactorChosen, i] - SupportExpactationValue), 2);
            return Dispersion / (ArrayForExpValue.GetLength(1) - 301);
        }
    }
}
