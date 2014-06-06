using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CovarianceMatrix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            bool ItsOK = true;
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

            ///////////////////////////////////////////////////
            Practice.Filter.FormingFilter TestFormingFilter = null;
            ///////////////////////////////////////////////////

            try
            {
                TestFormingFilter = new Practice.Filter.FormingFilter(Rows, Columns, tau, ksi, sigma, teta, fi);
                TestFormingFilter.Filter();
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            ///////////////////////////////////////////////////
            Practice.Filter.Covariance TestMatrix = null;
            ///////////////////////////////////////////////////
            try
            {

                TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);
                TestMatrix.CalculateCovarianceMatrix();
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }

            ///////////////////////////////////////////////////
            try
            {
                Practice.Filter.KalmanFilter TestKalmanFilter = new Practice.Filter.KalmanFilter(Rows, Columns, TestFormingFilter.X, TestMatrix);
                TestKalmanFilter.Filter();
            }
            catch (System.Exception e)
            {
                ItsOK = false;
            }
            ///////////////////////////////////////////////////

            Assert.IsTrue(ItsOK);
        }
    }
}
