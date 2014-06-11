using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestCalculateCalmanFilter
    {
        [TestMethod]
        public void CalculateCalmanFilter()
        {
            bool ItsOK = false;
            Practice.Filter.Covariance CM;
            double tau = 0.01;
            double teta = 0.286;
            double sigma = 3.464;
            double fi = 4.414;
            double ksi = 11.427;
            double Sv = 0;
            int RowsCount = 3;
            int ColumnsCount = 5000;
            double[] analyticallycalculateY1 = { 0, 0, 0, 0 };
            double[] analyticallycalculateY2 = { 0, 0, 0, 0 };
            CM = new Practice.Filter.Covariance(3, 5000, 1.621, 0.542, 1.732, 2.903, 1.973, 0.01, 11.427, 3.464, 0.286, 4.414);

            Practice.Signal.NormalDistributionSignal InitialSignal = new Practice.Signal.NormalDistributionSignal(0, Math.PI * 2 * Sv / tau);
            InitialSignal.GenerateSignal();
            Practice.Filter.FormingFilter FF = new Practice.Filter.FormingFilter(RowsCount, ColumnsCount, tau, ksi, sigma, teta, fi);
            Practice.Filter.KalmanFilter KF = new Practice.Filter.KalmanFilter(RowsCount, ColumnsCount, FF.X, CM);
            FF.Filter();
            KF.Filter();

            for (int i = 0; i < 3; i++)
            {
                analyticallycalculateY1[i + 1] = analyticallycalculateY1[i] + KF.CovMatr.tau * (analyticallycalculateY2[i] + KF.CovMatr.CovarianceMatrix[0][0, i] * (FF.X[0, i] + KF.Noize.SignalArray[i] - analyticallycalculateY1[i]) / (2 * Math.PI * KF.CovMatr.factor[0] * KF.CovMatr.Sw));
                analyticallycalculateY2[i + 1] = analyticallycalculateY2[i] + KF.CovMatr.tau * (KF.CovMatr.CovarianceMatrix[2][0, i] * (FF.X[0, i] + KF.Noize.SignalArray[i] - analyticallycalculateY1[i]) / (2 * Math.PI * KF.CovMatr.factor[0] * KF.CovMatr.Sw) - KF.CovMatr.ksi * analyticallycalculateY1[i] - KF.CovMatr.sigma * analyticallycalculateY2[i]);
                if (
                KF.Y1[0, i + 1].ToString().Remove(4) == analyticallycalculateY1[i + 1].ToString().Remove(4) &&
                KF.Y2[0, i + 1].ToString().Remove(4) == analyticallycalculateY2[i + 1].ToString().Remove(4)
                )
                {
                    ItsOK = true;
                }

            }
        }
    }
}
