using Practice.Signal;
using System;

namespace Practice.Filter
{
    [Serializable]
    public sealed class KalmanFilter : BaseFilter
    {
        public double[,] a_tt;
        public double[,] A_tt;
        private double[,] Y2;
        public double[,] E;
        //public double[,] X;
        private double Sv;
        Covariance CovMatr;
        NormalDistributionSignal Noize;
        public override void Filter()
        {
            for (int j = 0; j < RowsCount; j++)
            {
                a_tt[j, 0] = 0;
                A_tt[j, 0] = 0;
                OutputSignal[j, 0] = 0; //Y1
                Y2[j, 0] = 0;
                E[j, 0] = 0;
            }
            for (int j = 0; j < RowsCount; j++)
                for (int i = 0; i < ColumnsCount - 1; i++)
                {
                    a_tt[j, i + 1] = CovMatr.CovarianceMatrix[0][j, i] / (2 * Math.PI * CovMatr.factor[j] * CovMatr.Sw);
                    A_tt[j, i + 1] = CovMatr.CovarianceMatrix[2][j, i] / (2 * Math.PI * CovMatr.factor[j] * CovMatr.Sw);
                    OutputSignal[j, i + 1] = OutputSignal[j, i] + CovMatr.tau * (Y2[j, i] + CovMatr.CovarianceMatrix[0][j, i] * (InputSignal[j, i] + Noize.SignalArray[i] - OutputSignal[j, i]) / (2 * Math.PI * CovMatr.factor[j] * CovMatr.Sw));
                    Y2[j, i + 1] = Y2[j, i] + CovMatr.tau * (CovMatr.CovarianceMatrix[2][j, i] * (InputSignal[j, i] + Noize.SignalArray[i] - OutputSignal[j, i]) / (2 * Math.PI * CovMatr.factor[j] * CovMatr.Sw) - CovMatr.ksi * OutputSignal[j, i] - CovMatr.sigma * Y2[j, i]);
                    E[j, i + 1] = OutputSignal[j, i] - InputSignal[j, i];
                }
        }
        public KalmanFilter(int Rows, int Columns, double[,] x, Covariance CM)
        {
            this.Sv = 1;
            this.RowsCount = Rows;
            this.ColumnsCount = Columns;
            this.a_tt = new double[RowsCount, ColumnsCount];
            this.A_tt = new double[RowsCount, ColumnsCount];
            this.OutputSignal = new double[RowsCount, ColumnsCount];
            this.Y2 = new double[RowsCount, ColumnsCount];
            this.E = new double[RowsCount, ColumnsCount];
            this.InputSignal = x;
            CovMatr = CM;
            Noize = new NormalDistributionSignal(0, Math.Sqrt(Math.PI * 2 * Sv / CovMatr.tau));
            Noize.SignalArrayLength = ColumnsCount;
            Noize.GenerateSignal();
        }
    }
}
