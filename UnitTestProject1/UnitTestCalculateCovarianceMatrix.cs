using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CovarianceMatrix
{
    [TestClass]
    public class UnitTestCalculateCovarianceMatrix
    {
     public double[][,] CovarianceMatrix = new double[4][,];
        [TestMethod]
        public void UnitTestCalculateInitialConditions()
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
            double analyticallycalculate1 = 1.621;
            double analyticallycalculate2 = 11.479575;
            double analyticallycalculate3 = -0.25704;

            
            Practice.Filter.Covariance TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);

            TestMatrix.CalculateCovarianceMatrix();
            
            for (int i = 0; i < CovarianceMatrix.Length; i++)
                CovarianceMatrix[i] = new double[Rows, Columns];
            for (int j = 0; j < Rows; j++)
            {

                if (TestMatrix.CovarianceMatrix[0][j, 0] == analyticallycalculate1 && TestMatrix.CovarianceMatrix[1][j, 0] != analyticallycalculate2 && TestMatrix.CovarianceMatrix[2][j, 0] != analyticallycalculate3 && TestMatrix.CovarianceMatrix[3][j, 0] != analyticallycalculate3)
                {
                    ItsOK = true;
                }
            }
            Assert.IsTrue(ItsOK);
        }

        [TestMethod]
        public void UnitTestCalculateNextValues()
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
            double analyticallycalculate1 = 1.621;
            double analyticallycalculate2 = 11.479;
            double analyticallycalculate3 = -0.2553;

            Practice.Filter.Covariance TestMatrix = new Practice.Filter.Covariance(Rows, Columns, A, a, alpha, beta, Sw, tau, ksi, sigma, teta, fi);

            TestMatrix.CalculateCovarianceMatrix();

            for (int j = 0; j < Rows; j++)
                for (int i = 0; i < Columns - 1; i++)
                    if (
                         TestMatrix.CovarianceMatrix[0][0, 1].ToString().Remove(3) == Convert.ToString(analyticallycalculate1).Remove(3) &&
                         TestMatrix.CovarianceMatrix[1][0, 1].ToString().Remove(3) == Convert.ToString(analyticallycalculate2).Remove(3) &&
                         TestMatrix.CovarianceMatrix[2][0, 1].ToString().Remove(3) == Convert.ToString(analyticallycalculate3).Remove(3) &&
                         TestMatrix.CovarianceMatrix[3][0, 1].ToString().Remove(3) == Convert.ToString(analyticallycalculate3).Remove(3)
                       )
                    {
                        ItsOK = true;
                    }
            Assert.IsTrue(ItsOK);
        }
    }
}
