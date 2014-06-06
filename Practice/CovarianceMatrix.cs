using System;
namespace Practice
{
    class CovarianceMatrix : ArraysForCalculations
    {
        public double[,] DeX;
        public double[,] DeH;
        public double[,] KeXH;
        private void CalculateCovarianceMatrix()
        {
            for (int j = 0; j < LocalID.m; j++)
            {
                DeX[j, 0] = LocalID.A;
                DeH[j, 0] = LocalID.A * (Math.Pow(LocalID.beta, 2) + 3 * Math.Pow(LocalID.alpha, 2) - 2 * LocalID.alpha * LocalID.a * LocalID.beta - 2 * Math.Sqrt((LocalID.alpha - LocalID.a * LocalID.beta) * (LocalID.a * Math.Pow(LocalID.beta, 3) + Math.Pow(LocalID.beta, 2) * LocalID.alpha + LocalID.a * LocalID.beta * Math.Pow(LocalID.alpha, 2) + Math.Pow(LocalID.alpha, 3))));
                KeXH[j, 0] = LocalID.A * (LocalID.a * LocalID.beta - LocalID.alpha);
            }
            for (int j = 0; j < LocalID.m; j++)
                for (int i = 0; i < LocalID.n - 1; i++)
                {
                    DeX[j, i + 1] = DeX[j, i] + LocalID.tau * (2 * KeXH[j, i] + 2 * Math.PI * Math.Pow(teta, 2) - Math.Pow(DeX[j, i], 2) / (2 * Math.PI * (LocalID.factor[j] * Sw)));
                    DeH[j, i + 1] = DeH[j, i] + LocalID.tau * (2 * Math.PI * Math.Pow((fi - teta * sigma), 2) - 2 * DeH[j, i] * sigma - 2 * KeXH[j, i] * ksi - Math.Pow(KeXH[j, i], 2) / (2 * Math.PI * (LocalID.factor[j] * Sw)));
                    KeXH[j, i + 1] = KeXH[j, i] + LocalID.tau * (DeH[j, i] - ksi * DeX[j, i] - sigma * KeXH[j, i] + 2 * Math.PI * teta * (fi - teta * sigma) - DeX[j, i] * KeXH[j, i] / (2 * Math.PI * (LocalID.factor[j] * Sw)));
                }
        }
        public CovarianceMatrix(ref InitialData LocalID) : base (ref LocalID)
        {
            DeX = new double[LocalID.m, LocalID.n];
            DeH = new double[LocalID.m, LocalID.n];
            KeXH = new double[LocalID.m, LocalID.n];
            CalculateCovarianceMatrix();
        }
    }
    class FormingFilter : ArraysForCalculations, IDistribution
    {
        public double[,] X;
        private double[,] H;
        private double[] NormalArray;
        private void CalculateFormingFilter()
        {
            for (int j = 0; j < LocalID.m; j++)
            {
                X[j, 0] = 0;
                H[j, 0] = 0;
            }
            for (int j = 0; j < LocalID.m; j++)
                for (int i = 0; i < LocalID.n - 1; i++)
                {
                    X[j, i + 1] = X[j, i] + LocalID.tau * (H[j, i] + teta * NormalArray[i]);
                    H[j, i + 1] = H[j, i] + LocalID.tau * ((fi - sigma * teta) * NormalArray[i] - sigma * H[j, i] - ksi * X[j, i]);
                }
        }
        public void NormalDistribution()
        {
            Troschuetz.Random.NormalDistribution NormRand = new Troschuetz.Random.NormalDistribution();
            NormRand.Mu = 0;
            NormRand.Sigma = Math.PI * 2 * 0.039 / 0.01;
            for (int i = 0; i < NormalArray.Length - 1; i++)
                NormalArray[i] = NormRand.NextDouble();
        }
        public FormingFilter(ref InitialData LocalID) : base(ref LocalID)
        {
            X = new double[LocalID.m, LocalID.n];
            H = new double[LocalID.m, LocalID.n];
            NormalArray = new double[LocalID.n];
            NormalDistribution();
            CalculateFormingFilter();
        }
    }
    class KalmanFilter : CovarianceMatrix, IDistribution
    {
        public double[,] a_tt;
        public double[,] A_tt;
        public double[,] Y1;
        private double[,] Y2;
        public double[,] E;
        private double[] NormalArray;
        private void CalculateKalmanFilter(double[,] X)
        {
            for (int j = 0; j < LocalID.m; j++)
            {
                a_tt[j, 0] = 0;
                A_tt[j, 0] = 0;
                Y1[j, 0] = 0;
                Y2[j, 0] = 0;
                E[j, 0] = 0;
            }
            for (int j = 0; j < LocalID.m; j++)
                for (int i = 0; i < LocalID.n - 1; i++)
                {
                    a_tt[j, i + 1] = DeX[j, i] / (2 * Math.PI * LocalID.factor[j] * Sw);
                    A_tt[j, i + 1] = KeXH[j, i] / (2 * Math.PI * LocalID.factor[j] * Sw);
                    Y1[j, i + 1] = Y1[j, i] + LocalID.tau * (Y2[j, i] + DeX[j, i] * (X[j, i] + NormalArray[i] - Y1[j, i]) / (2 * Math.PI * LocalID.factor[j] * Sw));
                    Y2[j, i + 1] = Y2[j, i] + LocalID.tau * (KeXH[j, i] * (X[j, i] + NormalArray[i] - Y1[j, i]) / (2 * Math.PI * LocalID.factor[j] * Sw) - ksi * Y1[j, i] - sigma * Y2[j, i]);
                    E[j, i + 1] = Y1[j, i] - X[j, i];
                }
        }
        public void NormalDistribution()
        {
            Troschuetz.Random.NormalDistribution NormRand = new Troschuetz.Random.NormalDistribution();
            NormRand.Mu = 0;
            NormRand.Sigma = Math.Sqrt(Math.PI * 2 * 1 / 0.01);
            for (int i = 0; i < NormalArray.Length - 1; i++)
                NormalArray[i] = NormRand.NextDouble();
        }
        public KalmanFilter (ref InitialData LocalID, ref FormingFilter FF) : base (ref LocalID)
        {
            a_tt = new double[LocalID.m, LocalID.n];
            A_tt = new double[LocalID.m, LocalID.n];
            Y1 = new double[LocalID.m, LocalID.n];
            Y2 = new double[LocalID.m, LocalID.n];
            E = new double[LocalID.m, LocalID.n];
            NormalArray = new double[LocalID.n];
            NormalDistribution();
            CalculateKalmanFilter(FF.X);
        }
    }
}
