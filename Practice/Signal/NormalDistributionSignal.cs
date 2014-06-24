namespace Practice.Signal
{
    [System.Serializable]
    internal sealed class NormalDistributionSignal : BaseSignal
    {
        protected double Me;
        protected double Sigma;
        public override void GenerateSignal()
        {
            SignalArray = new double[SignalArrayLength];
            Troschuetz.Random.NormalDistribution NormRand = new Troschuetz.Random.NormalDistribution();
            NormRand.Mu = Me;
            NormRand.Sigma = Sigma;
            for (int i = 0; i < SignalArray.Length - 1; i++)
                SignalArray[i] = NormRand.NextDouble();
        }
        public NormalDistributionSignal(double Me, double Sigma)
        {
            this.Me = Me;
            this.Sigma = Sigma;
        }
    }
}