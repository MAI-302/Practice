using System;

namespace Practice
{
    public class ArrayData
    {
        public double[,] DeX;
        public double[,] DeH;
        public double[,] KeXH;
        public double[,] a_tt;
        public double[,] A_tt;
        public double[,] X;
        public double[,] H;
        public double[,] Y1;
        public double[,] Y2;
        public double[,] E;
        public double[] NormalArray;
        public double[] NormalArray2;
        public void ArrayInitialization(TextInput TxT)
        {
            DeX = new double[TxT.m, TxT.n];
            DeH = new double[TxT.m, TxT.n];
            KeXH = new double[TxT.m, TxT.n];
            a_tt = new double[TxT.m, TxT.n];
            A_tt = new double[TxT.m, TxT.n];
            X = new double[TxT.m, TxT.n];
            H = new double[TxT.m, TxT.n]; //invisible
            Y1 = new double[TxT.m, TxT.n];
            Y2 = new double[TxT.m, TxT.n];//invisible
            E = new double[TxT.m, TxT.n];
            NormalArray = new double[TxT.n];
            NormalArray2 = new double[TxT.n];
        }
        public void CovarianceMatrix (TextInput TxT)
        {
            double teta = 0;
            double fi = 0;
            double sigma = 0;
            double ksi = 0;
            double Sw = 0;

            ksi = Math.Pow(TxT.alpha, 2) + Math.Pow(TxT.beta, 2);
            sigma = 2 * TxT.alpha;
            fi = Math.Sqrt((TxT.A / Math.PI) * ksi * (TxT.alpha + TxT.a * TxT.beta));
            teta = Math.Sqrt((TxT.A / Math.PI) * (TxT.alpha - TxT.a * TxT.beta));

            Sw = 2 * TxT.tau * Math.Pow((Math.PI * 2 * TxT.Sv / 0.01), 2) * Math.PI;
            //Sw = 2 * TxT.tau * Math.Pow(242554675767134, 2) * Math.PI;

            for (int j = 0; j < TxT.m; j++)
            {
                DeX[j, 0] = TxT.A;
                DeH[j, 0] = TxT.A * (Math.Pow(TxT.beta, 2) + 3 * Math.Pow(TxT.alpha, 2) - 2 * TxT.alpha * TxT.a * TxT.beta - 2 * Math.Sqrt((TxT.alpha - TxT.a * TxT.beta) * (TxT.a * Math.Pow(TxT.beta, 3) + Math.Pow(TxT.beta, 2) * TxT.alpha + TxT.a * TxT.beta * Math.Pow(TxT.alpha, 2) + Math.Pow(TxT.alpha, 3))));
                KeXH[j, 0] = TxT.A * TxT.a * TxT.beta - TxT.A * TxT.alpha;
                X[j, 0] = 0;
                H[j, 0] = 0;
                Y1[j, 0] = 0;
                Y2[j, 0] = 0;
                E[j, 0] = 0;
            }
            for (int j = 0; j < TxT.m; j++)
            {
                for (int i = 0; i < TxT.n - 1; i++)
                {
                    DeX[j, i + 1] = DeX[j, i] + TxT.tau * (2 * KeXH[j, i] + 2 * Math.PI * Math.Pow(teta, 2) - Math.Pow(DeX[j, i], 2) / (2 * Math.PI * (TxT.factor[j] * Sw)));

                    DeH[j, i + 1] = DeH[j, i] + TxT.tau * (2 * Math.PI * Math.Pow((fi - teta * sigma), 2) - 2 * DeH[j, i] * sigma - 2 * KeXH[j, i] * ksi - Math.Pow(KeXH[j, i], 2) / (2 * Math.PI * (TxT.factor[j] * Sw)));

                    KeXH[j, i + 1] = KeXH[j, i] + TxT.tau * (DeH[j, i] - ksi * DeX[j, i] - sigma * KeXH[j, i] + 2 * Math.PI * teta * (fi - teta * sigma) - DeX[j, i] * KeXH[j, i] / (2 * Math.PI * (TxT.factor[j] * Sw)));

                    a_tt[j, i + 1] = DeX[j, i] / (2 * Math.PI * TxT.factor[j] * Sw);

                    A_tt[j, i + 1] = KeXH[j, i] / (2 * Math.PI * TxT.factor[j] * Sw);

                    X[j, i + 1] = X[j, i] + TxT.tau * (H[j, i] + teta * NormalArray[i]);

                    H[j, i + 1] = H[j, i] + TxT.tau * ((fi - sigma * teta) * NormalArray[i] - sigma * H[j, i] - ksi * X[j, i]);

                    Y1[j, i + 1] = Y1[j, i] + TxT.tau * (Y2[j, i] + DeX[j, i] * (X[j, i] + NormalArray2[i] - Y1[j, i]) / (2 * Math.PI * TxT.factor[j] * Sw));

                    Y2[j, i + 1] = Y2[j, i] + TxT.tau * (KeXH[j, i] * (X[j, i] + NormalArray2[i] - Y1[j, i]) / (2 * Math.PI * TxT.factor[j] * Sw) - ksi * Y1[j, i] - sigma * Y2[j, i]);

                    E[j, i + 1] = Y1[j, i] - X[j, i];
                }
            }
        }
        public void NormalDistribution(TextInput TxT)
        {
            Troschuetz.Random.NormalDistribution randd = new Troschuetz.Random.NormalDistribution();
            randd.Mu = 0;
            randd.Sigma = 25.066;
            for (int i = 0; i < NormalArray.Length - 1; i++)
                NormalArray[i] = randd.NextDouble();
            Troschuetz.Random.NormalDistribution randd2 = new Troschuetz.Random.NormalDistribution();
            randd2.Mu = 0;
            //randd2.Sigma = 242554675767134;
            randd2.Sigma = Math.PI * 2 * TxT.Sv/0.01;
            for (int i = 0; i < NormalArray2.Length - 1; i++)
                NormalArray2[i] = randd2.NextDouble();
        }
        public ArrayData()
        { }
    }
}
