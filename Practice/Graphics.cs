using System;
using System.Drawing;
using ZedGraph;

namespace Practice
{
    class Graphics
    {
        private ZedGraphControl zedGraph;
        public void DrawGraph(double[,] ArrayArray)
        {
            int i = 0;
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();
            PointPairList PairList = new PointPairList();
            PointPairList PairList_2 = new PointPairList();
            PointPairList PairList_3 = new PointPairList();
            double xmin = 0;
            double xmax = 3;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList.Add(x, ArrayArray[0, Convert.ToInt32(100 * x)]);
                PairList_2.Add(x, ArrayArray[1, Convert.ToInt32(100 * x)]);
                PairList_3.Add(x, ArrayArray[2, Convert.ToInt32(100 * x)]);
            }
            i++;
            LineItem myCurve = Pane.AddCurve("Factor = 0.2", PairList, Color.Black, SymbolType.None);
            LineItem myCurve_2 = Pane.AddCurve("Factor = 0.5", PairList_2, Color.Blue, SymbolType.None);
            LineItem myCurve_3 = Pane.AddCurve("Factor = 0.8", PairList_3, Color.Red, SymbolType.None);
            zedGraph.AxisChange();
            zedGraph.Refresh();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ArrayArray"></param>
        /// <param name="ArrayArray2"></param>
        /// <param name="isAxisAdded"></param>
        public void DrawGraph(double[] ArrayArray, double[] ArrayArray2, bool isAxisAdded)
        {
            int i = 0;
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();
            int axis2;
            axis2 = Pane.AddYAxis("Ось графика Х");
            PointPairList PairList1 = new PointPairList();
            PointPairList PairList2 = new PointPairList();
            double xmin = 0;
            double xmax = 3;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList1.Add(x, ArrayArray[Convert.ToInt32(100 * x)]);
                PairList2.Add(x, ArrayArray2[Convert.ToInt32(100 * x)]);
            }
            i++;
            LineItem myCurve = Pane.AddCurve("Factor = 0.2", PairList1, Color.Black, SymbolType.None);
            LineItem myCurve_2 = Pane.AddCurve("Factor = 0.5", PairList2, Color.Blue, SymbolType.None);
            if (!isAxisAdded)
                Pane.YAxisList[axis2].IsVisible = true;
            else
                Pane.YAxisList[axis2].IsVisible = false;
            zedGraph.AxisChange();
            zedGraph.Refresh();
        }
        public void DrawGraph(double[,] ArrayArray1, double[,] ArrayArray2, int LineNumber, bool isAxisAdded)
        {
            int i = 0;
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();
            int axis2;
            axis2 = Pane.AddYAxis("Ось графика Х");
            PointPairList PairList = new PointPairList();
            PointPairList PairList_2 = new PointPairList();
            double xmin = 0;
            double xmax = 49;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList.Add(x, ArrayArray1[LineNumber, Convert.ToInt32(100 * x)]);
                PairList_2.Add(x, ArrayArray2[LineNumber, Convert.ToInt32(100 * x)]);
            }
            i++;
            LineItem myCurve = Pane.AddCurve("Y1", PairList, Color.Black, SymbolType.None);
            LineItem myCurve_2 = Pane.AddCurve("X", PairList_2, Color.Blue, SymbolType.None);
            myCurve_2.YAxisIndex = axis2;
            Pane.YAxis.IsVisible = false;
            Pane.YAxisList[axis2].Title.FontSpec.FontColor = Color.Blue;
            if (!isAxisAdded)
                Pane.YAxisList[axis2].IsVisible = true;
            else
                Pane.YAxisList[axis2].IsVisible = false;
            zedGraph.AxisChange();
            zedGraph.Refresh();
        }
        public Graphics(ref ZedGraphControl zdgrph) 
        {
            zedGraph = zdgrph;
        }
    }
}
