
namespace Practice.Filter
{
    [System.Serializable]
    public abstract class BaseFilter
    {
        protected int Rows;
        protected int Columns;

        /// <summary>
        /// Входной сигнал системы, преставленный в формате двумерного массива типа double.
        /// </summary>
        public double[,] InputSignal;
        /// <summary>
        /// Выходной сигнал системы, преставленный в формате двумерного массива типа double.
        /// </summary>
        public double[,] OutputSignal;
        /// <summary>
        /// Колличество строк в выходном и входном массиве.
        /// </summary>
        public int RowsCount { get { return Rows; } set { Rows = value; } }
        /// <summary>
        /// Количество столбцов в выходном и входном массиве.
        /// </summary>
        public int ColumnsCount { get { return Columns; } set { Columns = value; } }
        /// <summary>
        /// Метод, используемый для преобразования входного сигнала в выходной с учетом особенностей фильтра.
        /// </summary>
        public abstract void Filter();
    }
}
