﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CovarianceMatrix
{
    /// <summary>
    /// Тест проверки работы конструкторов и основных методов классов при определенных параметрах.
    /// </summary>
    [TestClass]
    public class UnitTestWrongInputData
    {
        /// <summary>
        /// Метод проверки с непригодными парасетрами.
        /// </summary>
        [TestMethod]
        public void TestWrongInputData()
        {
            //Переменная, в которой отмечается, пройден ли тест.
            //Тест содержит такие параметры, при которых программа упадет.
            bool ItsOK = true;
            //Объявление параметров, которые поступают на вход маетодам экземплярам классов, которые проходят проверку.
            int Rows = -1;
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

            //Объявление экземпляра формирующего фильтра.
            Practice.Filter.FormingFilter TestFormingFilter = null;

            //Попытка инициализации этого экземплряра и запуск метода с данными параметрами.
            try
            {
                TestFormingFilter = new Practice.Filter.FormingFilter(Rows, Columns, tau, ksi, sigma, teta, fi);
                TestFormingFilter.Filter();
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            //Объявление экземпляра матрицы коваиаций.
            Practice.Filter.Covariance TestMatrix = null;

            //Попытка инициализации этого экземплряра и запуск метода с данными параметрами.
            try
            {

                TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);
                TestMatrix.CalculateCovarianceMatrix();
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            //Объявление экземпляра фильтра калмана.
            Practice.Filter.KalmanFilter TestKalmanFilter = null;

            //Попытка инициализации этого экземплряра и запуск метода с данными параметрами.
            try
            {
                TestKalmanFilter = new Practice.Filter.KalmanFilter(Rows, Columns, TestFormingFilter.OutputSignal, TestMatrix);
                TestKalmanFilter.Filter();
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            //Если при данных параметрах во время создания экземпляра или в ходе работы метода будет ошибка, то тест будет пройден.
            Assert.IsFalse(ItsOK);
        }
    }
}
