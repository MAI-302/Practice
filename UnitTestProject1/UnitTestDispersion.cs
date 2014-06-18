﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MainForm
{
    [TestClass]
    public class UnitTestDispersion
    {
        [TestMethod]
        public void IsDispersionLargerThanZero()
        {
            //Переменная, в которой отмечается, пройден ли тест.
            bool ItsOK = true;
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
            Practice.Filter.KalmanFilter TestKalmanFilter = new Practice.Filter.KalmanFilter(Rows, Columns, TestFormingFilter.X, TestMatrix);
            TestKalmanFilter.Filter();
            
            //Коэфициенты для которых считается дисперсия.
            double[] factor = new double[3] { 0.2, 0.5, 0.8 };
            try
            {
                for (int i = 0; i < 3; i++)
                {
                    //Если при подсчете дисперсия для формирующего фильтра  - отрицательна, то создаём ошибку с соответсвующим сообщением.
                    if (Practice.StatisticalCharacteristics.Variance((byte)factor[i], TestFormingFilter.X) < 0 )
                    {
                        throw new System.Exception("Дисперсия формирующего фильтра < 0, при коэффициенте="+factor.ToString());
                    }
                    //Если при подсчете дисперсия для  фильтра калмана дисперсия - отрицательна, то создаём ошибку с соответсвующим сообщением.
                    if (Practice.StatisticalCharacteristics.Variance((byte)factor[i], TestKalmanFilter.E) < 0)
                    {
                        throw new System.Exception("Дисперсия фильтра калмана < 0, при коэффициенте="+factor.ToString());
                    }
                }
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }
            //Если дисперсия при всех коэффициентах положительна, то тест пройден.
            Assert.IsTrue(ItsOK);
        }
    }
}