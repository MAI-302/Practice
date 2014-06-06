using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CovarianceMatrix
{
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]
        public void TestMethod3()
        {
            bool ItsOK = false;
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

            Practice.Filter.Covariance TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);

            TestMatrix.CalculateCovarianceMatrix();

            for (int j = 0; j < Rows; j++)
                for (int i = 0; i < Columns - 1; i++)
                    if (
                         TestMatrix.CovarianceMatrix[0][0, 1].ToString().Remove(3) == Convert.ToString(1.610).Remove(3) &&
                         TestMatrix.CovarianceMatrix[1][0, 1].ToString().Remove(3) == Convert.ToString(11.479).Remove(3) &&
                         TestMatrix.CovarianceMatrix[2][0, 1].ToString().Remove(3) == Convert.ToString(-0.2553).Remove(3) &&
                         TestMatrix.CovarianceMatrix[3][0, 1].ToString().Remove(3) == Convert.ToString(-0.2553).Remove(3)
                       )

                    {
                        ItsOK = true;
                    }
            Assert.IsTrue(ItsOK);
        }
    }
}
