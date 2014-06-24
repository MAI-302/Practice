using Practice.Signal;
using System;

namespace Practice.Filter
{
    [Serializable]
    public sealed class FormingFilter : BaseFilter
    {
        //OutputSignal[,] X
        private double[,] H;
        public double tau;
        public double teta;
        public double sigma;
        public double fi;
        public double ksi;
        public double Sv;
        NormalDistributionSignal InitialSignal; //inputputsignal
        public override void Filter()
        {
            for (int j = 0; j < RowsCount; j++)
            {
                OutputSignal[j, 0] = 0;
                H[j, 0] = 0;
            }
            for (int j = 0; j < RowsCount; j++)
                for (int i = 0; i < ColumnsCount - 1; i++)
                {
                    OutputSignal[j, i + 1] = OutputSignal[j, i] + tau * (H[j, i] + teta * InputSignal[0, i]);
                    H[j, i + 1] = H[j, i] + tau * ((fi - sigma * teta) * InputSignal[0, i] - sigma * H[j, i] - ksi * OutputSignal[j, i]);
                }
        }
        public FormingFilter(int Rows, int Columns, double tau, double ksi, double sigma, double teta, double fi)
        {
            this.tau = tau;
            this.Sv = 1;
            this.ColumnsCount = Columns;
            this.RowsCount = Rows;
            this.OutputSignal = new double[RowsCount, ColumnsCount];
            this.H = new double[RowsCount, ColumnsCount];
            this.teta = teta;
            this.sigma = sigma;
            this.ksi = ksi;
            this.fi = fi;
            InitialSignal = new NormalDistributionSignal(0, Math.Sqrt(Math.PI * 2 * Sv / tau));
            InitialSignal.SignalArrayLength = ColumnsCount;
            InitialSignal.GenerateSignal();
            this.InputSignal = new double[1, ColumnsCount];
            for (int i = 0; i < InitialSignal.SignalArrayLength; i++)
                this.InputSignal[0, i] = InitialSignal.SignalArray[i];
        }
    }
}
