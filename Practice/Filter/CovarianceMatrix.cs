using System;

namespace Practice.Filter
{
    [Serializable]
    public sealed class Covariance
    {
        public double[][,] CovarianceMatrix = new double[4][,];
        internal int RowsCount;
        internal int ColumnsCount;
        internal double A;
        internal double a;
        internal double alpha;
        internal double beta;
        internal double Sw;
        internal double[] factor;
        internal double tau;
        internal double ksi;
        internal double sigma;
        internal double teta;
        internal double fi;
        public void CalculateCovarianceMatrix()
        {
            for (int i = 0; i < CovarianceMatrix.Length; i++)
                CovarianceMatrix[i] = new double[RowsCount, ColumnsCount];
            for (int j = 0; j < RowsCount; j++)
            {
                CovarianceMatrix[0][j, 0] = A;
                CovarianceMatrix[1][j, 0] = A * (Math.Pow(beta, 2) + 3 * Math.Pow(alpha, 2) - 2 * alpha * a * beta - 2 * Math.Sqrt((alpha - a * beta) * (a * Math.Pow(beta, 3) + Math.Pow(beta, 2) * alpha + a * beta * Math.Pow(alpha, 2) + Math.Pow(alpha, 3))));
                CovarianceMatrix[2][j, 0] = A * (a * beta - alpha);
                CovarianceMatrix[3][j, 0] = A * (a * beta - alpha);
            }
            for (int j = 0; j < RowsCount; j++)
                for (int i = 0; i < ColumnsCount - 1; i++)
                {
                    CovarianceMatrix[0][j, i + 1] = CovarianceMatrix[0][j, i] + tau * (2 * CovarianceMatrix[2][j, i] + 2 * Math.PI * Math.Pow(teta, 2) - Math.Pow(CovarianceMatrix[0][j, i], 2) / (2 * Math.PI * (factor[j] * Sw)));
                    CovarianceMatrix[1][j, i + 1] = CovarianceMatrix[1][j, i] + tau * (2 * Math.PI * Math.Pow((fi - teta * sigma), 2) - 2 * CovarianceMatrix[1][j, i] * sigma - 2 * CovarianceMatrix[2][j, i] * ksi - Math.Pow(CovarianceMatrix[2][j, i], 2) / (2 * Math.PI * (factor[j] * Sw)));
                    CovarianceMatrix[2][j, i + 1] = CovarianceMatrix[2][j, i] + tau * (CovarianceMatrix[1][j, i] - ksi * CovarianceMatrix[0][j, i] - sigma * CovarianceMatrix[2][j, i] + 2 * Math.PI * teta * (fi - teta * sigma) - CovarianceMatrix[0][j, i] * CovarianceMatrix[2][j, i] / (2 * Math.PI * (factor[j] * Sw)));
                    CovarianceMatrix[3][j, i + 1] = CovarianceMatrix[3][j, i] + tau * (CovarianceMatrix[1][j, i] - ksi * CovarianceMatrix[0][j, i] - sigma * CovarianceMatrix[3][j, i] + 2 * Math.PI * teta * (fi - teta * sigma) - CovarianceMatrix[0][j, i] * CovarianceMatrix[3][j, i] / (2 * Math.PI * (factor[j] * Sw)));
                }
        }
        public Covariance(int Rows, int Columns, double A, double a, double alpha, double beta, double Sw, double tau, double ksi, double sigma, double teta, double fi)
        {
            this.RowsCount = Rows;
            this.ColumnsCount = Columns;
            this.CovarianceMatrix[0] = new double[RowsCount, ColumnsCount];
            this.CovarianceMatrix[1] = new double[RowsCount, ColumnsCount];
            this.CovarianceMatrix[2] = new double[RowsCount, ColumnsCount];
            this.CovarianceMatrix[3] = new double[RowsCount, ColumnsCount];
            this.A = A;
            this.a = a;
            this.alpha = alpha;
            this.beta = beta;
            this.Sw = Sw;
            this.tau = tau;
            this.ksi = ksi;
            this.sigma = sigma;
            this.teta = teta;
            this.fi = fi;
            factor = new double[3] {0.2, 0.5, 0.8};
            CalculateCovarianceMatrix();
        }
    }
}
