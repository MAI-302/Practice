using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice
{
    /// <summary>
    /// Класс, содержащий методы проверки правильного подсчета дисперсии.
    /// </summary>
    [TestClass]
    public class UnitTestDispersion
    {
        /// <summary>
        /// Метод проверки знака дисперсии.
        /// </summary>
        [TestMethod]
        public void IsDispersionLargerThanZero()
        {
            //Объявление параметров, которые поступают на вход маетодам экземплярам классов, которые проходят проверку.
            int Rows = 3;
            int Columns = 5000;
            double A = 1.621;
            double a = 0.542;
            double alpha = 1.732;
            double beta = 2.903;
            double Sw = 1.973;
            double tau = 0.01;
            double ksi = 11.427;
            double sigma = 3.464;
            double teta = 0.286;
            double fi = 4.414;
            //Объявление экземпляра матрицы коваиаций.
            Practice.Filter.Covariance TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);
            TestMatrix.CalculateCovarianceMatrix();
            //Объявление экземпляра формирующего фильтра и фильтрация.
            Practice.Filter.FormingFilter TestFormingFilter = new Practice.Filter.FormingFilter(Rows, Columns, tau, ksi, sigma, teta, fi);
            TestFormingFilter.Filter();
            //Объявление экземпляра фильтра калмана и фильтрация.
            Practice.Filter.KalmanFilter TestKalmanFilter = new Practice.Filter.KalmanFilter(Rows, Columns, TestFormingFilter.OutputSignal, TestMatrix);
            TestKalmanFilter.Filter();

            //Коэфициенты для которых считается дисперсия.
            double[] factor = new double[3] { 0.2, 0.5, 0.8 };
            for (int i = 0; i < 3; i++)
            {
                //Если дисперсия при всех коэффициентах положительна, то тест пройден.

                //Дисперсия для формирующего фильтра.
                Assert.IsFalse(Practice.StatisticalCharacteristics.Variance((byte)factor[i], TestFormingFilter.OutputSignal) < 0);

                //Дисперсия для  фильтра калмана. 
                Assert.IsFalse(Practice.StatisticalCharacteristics.Variance((byte)factor[i], TestKalmanFilter.E) < 0);
            }
        }
    }
}
