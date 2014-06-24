namespace Practice.Signal
{
    [System.Serializable]
    internal abstract class BaseSignal
    {
        public double[] SignalArray;
        public int SignalArrayLength { get; set; }
        public abstract void GenerateSignal();
    }
}
