using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice.Signal
{
    [TestClass]
    public class UnitTestCalculateFormingFilter
    {
        [TestMethod]
        public void CalculateFormingFilter()
        {
            bool ItsOK = false;
            double tau = 0.01;
            double teta = 0.286;
            double sigma = 3.464;
            double fi = 4.414;
            double ksi = 11.427;
            double Sv = 0;
            int RowsCount = 3;
            int ColumnsCount = 5000;
            double[] analyticallycalculateX = { 0, 0, 0, 0 };
            double[] analyticallycalculateH = { 0, 0, 0, 0 };



            Practice.Signal.NormalDistributionSignal InitialSignal = new Practice.Signal.NormalDistributionSignal(0, Math.PI * 2 * Sv / tau);
            InitialSignal.GenerateSignal();
            Practice.Filter.FormingFilter FF = new Practice.Filter.FormingFilter(RowsCount, ColumnsCount, tau, ksi, sigma, teta, fi);
            FF.Filter();

            for (int i = 0; i < 3; i++)
            {
                analyticallycalculateX[i + 1] = analyticallycalculateX[i] + tau * (analyticallycalculateH[i] + teta * FF.InitialSignal.SignalArray[i]);
                analyticallycalculateH[i + 1] = analyticallycalculateH[i] + tau * ((fi - sigma * teta) * FF.InitialSignal.SignalArray[i] - sigma * analyticallycalculateH[i] - ksi * analyticallycalculateX[i]);
                if (
                FF.X[0, i + 1].ToString().Remove(4) == analyticallycalculateX[i + 1].ToString().Remove(4) &&
                FF.H[0, i + 1].ToString().Remove(4) == analyticallycalculateH[i + 1].ToString().Remove(4)
                )
                {
                    ItsOK = true;
                }
            }
            Assert.IsTrue(ItsOK);
        }
    }
}
