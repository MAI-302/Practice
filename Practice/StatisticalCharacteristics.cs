using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public static class StatisticalCharacteristics
    {
        public static double SupportExpactationValue;
        /// <summary>
        /// Метод, считающий М.О. для выбранного вектора с учетом выбранного фактора.
        /// </summary>
        /// <param name="FactorChosen"></param>
        /// <param name="ArrayForExpValue">Вектор, для которого считается М.О.</param>
        /// <returns>Возвращает М.О.</returns>
        public static double ExpectationValue(int FactorChosen, double[,] ArrayForExpValue)
        {
            double ExpectValue = 0;
            for (int i = 300; i < ArrayForExpValue.GetLength(1) - 1; i++)
                ExpectValue = ExpectValue + ArrayForExpValue[FactorChosen, i];
            SupportExpactationValue = ExpectValue / (ArrayForExpValue.GetLength(1) - 301);
            return SupportExpactationValue;
        }
        /// <summary>
        /// Метод, считающий Дисперсию для выбранного вектора с учетом выбранного фактора.
        /// </summary>
        /// <param name="FactorChosen"></param>
        /// <param name="ArrayForExpValue">Вектор, для которого считается Дисперсия.</param>
        /// <returns>Возвращает Дисперсию.</returns>
        public static double Variance(int FactorChosen, double[,] ArrayForExpValue)
        {
            double Dispersion = 0;
            for (int i = 300; i < ArrayForExpValue.GetLength(1) - 1; i++)
                Dispersion = Dispersion + Math.Pow((ArrayForExpValue[FactorChosen, i] - SupportExpactationValue), 2);
            return Dispersion / (ArrayForExpValue.GetLength(1) - 301);
        }
    }
}
