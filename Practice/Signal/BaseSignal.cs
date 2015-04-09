namespace Practice.Signal
{
    [System.Serializable]
    internal abstract class BaseSignal
    {
        /// <summary>
        /// Вектор значений сигнала.
        /// </summary>
        public double[] SignalArray;
        /// <summary>
        /// Длина вектора.
        /// </summary>
        public int SignalArrayLength { get; set; }
        /// <summary>
        /// Метод, генерируещий сигнал.
        /// </summary>
        public abstract void GenerateSignal();
    }
}
