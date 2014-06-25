using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice
{
    /// <summary>
    /// Класс, содержащий методы проверки правильности расчёта матрицы ковариаций.
    /// </summary>
    [TestClass]
    public class UnitTestCalculateCovarianceMatrix
    {
        /// <summary>
        /// Объявление матрицы ковариаций.
        /// </summary>
        public double[][,] CovarianceMatrix = new double[4][,];
        //Входные параметры.
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

        /// <summary>
        /// Метод проверки расчёта начальных значений.
        /// </summary>
        [TestMethod]
        public void UnitTestCalculateInitialConditions()
        {
            //Посчитанные вручную значения.
            double analyticallycalculate1 = 1.621;
            double analyticallycalculate2 = 11.479575;
            double analyticallycalculate3 = -0.25704;

            //Создание экземпляра матрицы и расчёт её значений(начальных).
            Practice.Filter.Covariance TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);
            TestMatrix.CalculateCovarianceMatrix();

            //Если значения не совпали с подсчитанными вручную, то тест не пройден.
            for (int j = 0; j < Rows; j++)
            {
                Assert.IsFalse
                (
                    TestMatrix.CovarianceMatrix[0][j, 0] != analyticallycalculate1 &&
                    TestMatrix.CovarianceMatrix[1][j, 0] != analyticallycalculate2 &&
                    TestMatrix.CovarianceMatrix[2][j, 0] != analyticallycalculate3 &&
                    TestMatrix.CovarianceMatrix[3][j, 0] != analyticallycalculate3
                );
            }
        }

        /// <summary>
        /// Метод проверки расчёта следующих после начальных значений.
        /// </summary>
        [TestMethod]
        public void UnitTestCalculateNextValues()
        {
            //Посчитанные вручную значения.
            double analyticallycalculate1 = 1.621;
            double analyticallycalculate2 = 11.479;
            double analyticallycalculate3 = -0.2553;

            //Создание экземпляра матрицы и расчёт её значений(первых).
            Practice.Filter.Covariance TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);
            TestMatrix.CalculateCovarianceMatrix();

            //Если значения не совпали с подсчитанными вручную, то тест не пройден.
            Assert.IsFalse
            (
                TestMatrix.CovarianceMatrix[0][0, 1].ToString().Remove(3) != Convert.ToString(analyticallycalculate1).Remove(3) &&
                TestMatrix.CovarianceMatrix[1][0, 1].ToString().Remove(3) != Convert.ToString(analyticallycalculate2).Remove(3) &&
                TestMatrix.CovarianceMatrix[2][0, 1].ToString().Remove(3) != Convert.ToString(analyticallycalculate3).Remove(3) &&
                TestMatrix.CovarianceMatrix[3][0, 1].ToString().Remove(3) != Convert.ToString(analyticallycalculate3).Remove(3)
            );
        }
    }
}
