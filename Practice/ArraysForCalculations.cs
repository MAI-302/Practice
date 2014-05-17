using System;

namespace Practice
{
    class ArraysForCalculations
    {
        protected double teta, sigma, ksi, fi, Sw;
        protected InitialData LocalID;
        private void SetStartValues()
        {
            teta = Math.Sqrt((LocalID.A / Math.PI) * (LocalID.alpha - LocalID.a * LocalID.beta));
            sigma = 2 * LocalID.alpha;
            ksi = Math.Pow(LocalID.alpha, 2) + Math.Pow(LocalID.beta, 2);
            fi = Math.Sqrt((LocalID.A / Math.PI) * ksi * (LocalID.alpha + LocalID.a * LocalID.beta));
            Sw = 2 * LocalID.tau * Math.Pow((Math.PI * 2 * LocalID.Sv / 0.01), 2) * Math.PI;
        }
        protected ArraysForCalculations(ref InitialData ID)
        {
            LocalID = ID;
            SetStartValues();
        }
    }
}
