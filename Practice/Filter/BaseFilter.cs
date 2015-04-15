
namespace Practice.Filter
{
    [System.Serializable]
    public abstract class BaseFilter
    {
        protected int Rows;
        protected int Columns;

        public double[,] InputSignal;
        public double[,] OutputSignal;
        public int RowsCount { get { return Rows; } set { Rows = value; } }
        public int ColumnsCount { get { return Columns; } set { Columns = value; } }
        public abstract void Filter();
    }
}
