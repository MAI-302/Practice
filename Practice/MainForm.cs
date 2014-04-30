using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ZedGraph;

namespace Practice
{
    public partial class MainForm : Form
    {
        public static TextInput TxT;
        public static ArrayData ArrDat = new ArrayData();
        Help help = new Help();
        private bool isAxisAdded = false;
        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            TxT = ReadInputData();
            ArrDat.ArrayInitialization(TxT);
            ArrDat.NormalDistribution();
            ArrDat.CovarianceMatrix(TxT);
        }
        private static TextInput ReadInputData()
        {
            TextInput TxT = new TextInput();
            string path = "InputSd.txt";
            int LinesCount = File.ReadAllLines(path).Length;
            string[] SupportStringArray = new string[LinesCount-1];
            using (StreamReader Reader = new StreamReader(path, Encoding.Default))
            {
                while (!Reader.EndOfStream)
                {
                    for (int i = 0; i < LinesCount; i++)
                    {
                        string MassiveLine = Reader.ReadLine();
                        if (MassiveLine.Contains(" "))
                        {
                            string[] SplitLine = MassiveLine.Split(new Char[] { ' ', '\t' });
                            for (int j = 0; j < SplitLine.Length; j++)
                                TxT.factor[j] = Double.Parse(SplitLine[j]);
                        }
                        else
                        {
                            SupportStringArray[i] = MassiveLine;
                        }
                    }
                }
                Reader.Close();
            }
            
            TxT.tau = Double.Parse(SupportStringArray[0]);
            TxT.A = Double.Parse(SupportStringArray[1]);
            TxT.a = Double.Parse(SupportStringArray[2]);
            TxT.alpha = Double.Parse(SupportStringArray[3]);
            TxT.beta = Double.Parse(SupportStringArray[4]);
            TxT.Sv = Double.Parse(SupportStringArray[5]);
            TxT.m = Int32.Parse(SupportStringArray[6]);
            TxT.n = Int32.Parse(SupportStringArray[7]);
            return TxT;
        }
        private double y_1(double x)
        {
            return -21 / (1 * (x - 9.425)) - 9;
        }
        private double y_4(double x)
        {
            return -21 / (1 * (x - 9.425)) + 9;
        }
        private double y_5(double x)
        {
            return Math.Pow((x-9.425),2) * 10 - 30.8;
        }
        private double y_2(double x)
        {
            return Math.Sqrt(x + 5*Math.Pow(x, 2));
        }
        private double y_3 (double x)
        {
            return 4.2 * Math.Sin(3*x);
        }
        private void DrawGraph()
        {
            int i = 0;
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();
            PointPairList PairList = new PointPairList();
            double xmin = 0;
            double xmax = 20;
            double Raznost = xmax - xmin;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList.Add(x, y_5(x));
            }
            i++;
            LineItem myCurve = Pane.AddCurve("", PairList, Color.Blue, SymbolType.None);
            zedGraph.AxisChange();
            zedGraph.Refresh();
        }
        private void DrawGraph1()
        {
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();
            PointPairList PairList = new PointPairList();
            PointPairList PairList2 = new PointPairList();
            PointPairList PairList3 = new PointPairList();
            PointPairList PairList4 = new PointPairList();
            PointPairList PairList5 = new PointPairList();
            PointPairList PairList6 = new PointPairList();
            PointPairList PairList7 = new PointPairList();
            PointPairList PairList8 = new PointPairList();
            double xmin = 7.33;
            double xmax = 7.85;
            double Raznost = xmax - xmin;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList.Add(x, y_3(x));
                PairList2.Add(x, -y_3(x));
            }
            xmin = 7.85;
            xmax = 8.85;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList5.Add(x, y_1(x));
            }
            xmin = 8.85;
            xmax = 10;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList7.Add(x, -y_5(x));
            }
            xmin = 10;
            xmax = 11;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList6.Add(x, -y_4(x));
            }
            xmin = 11;
            xmax = 11.52;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList3.Add(x, y_3(x));
                PairList4.Add(x, - y_3(x));
            }
            xmin = 7.85;
            xmax = 11;
            for (double x = xmin; x <= xmax; x += 0.01)
            {
                PairList8.Add(x, -4.201);
            }
            LineItem myCurve = Pane.AddCurve("", PairList, Color.Blue, SymbolType.None);
            LineItem myCurve2 = Pane.AddCurve("", PairList2, Color.Blue, SymbolType.None);
            LineItem myCurve3 = Pane.AddCurve("", PairList3, Color.Blue, SymbolType.None);
            LineItem myCurve4 = Pane.AddCurve("", PairList4, Color.Blue, SymbolType.None);
            LineItem myCurve5 = Pane.AddCurve("", PairList5, Color.Blue, SymbolType.None);
            LineItem myCurve6 = Pane.AddCurve("", PairList6, Color.Blue, SymbolType.None);
            LineItem myCurve7 = Pane.AddCurve("", PairList7, Color.Blue, SymbolType.None);
            LineItem myCurve8 = Pane.AddCurve("", PairList8, Color.Blue, SymbolType.None);
            zedGraph.AxisChange();
            zedGraph.Refresh();
        }
        private void DrawGraph(double[] ArrayArray)
        {
            int i = 0;
            GraphPane Pane = zedGraph.GraphPane;
            Pane.CurveList.Clear();
            PointPairList PairList = new PointPairList();
            double xmin = 0;
            double xmax = 49;
            for (double x = xmin; x <= xmax; x += 0.01)
                PairList.Add(x, ArrayArray[Convert.ToInt32(100 * x)]);
            i++;
            LineItem myCurve = Pane.AddCurve("White noise", PairList, Color.Blue, SymbolType.None);
            zedGraph.AxisChange();
            zedGraph.Refresh();
        }
        private void DrawGraph(double[,] ArrayArray)
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
        private void DrawGraph(double[,] ArrayArray1, double[,] ArrayArray2, int LineNumber) 
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
            LineItem myCurve = Pane.AddCurve("X", PairList, Color.Black, SymbolType.None);
            LineItem myCurve_2 = Pane.AddCurve("Y1", PairList_2, Color.Blue, SymbolType.None);
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
        private void DeX_Plot_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.DeX);
        }
        private void DeH_Plot_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.DeH);
        }
        private void KeXH_Plot_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.KeXH);
        }
        private void Help_Button_Click(object sender, EventArgs e)
        {
            help.ShowDialog();
        }
        private void Time2_Plot_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.a_tt);
        }
        private void Time1_Plot_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.A_tt);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            DrawGraph1();
        }
        private void SimulateTheFilter_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.Y1, ArrDat.X, 0);
            isAxisAdded = true;
            label2.Text = "M[E] = " + ArrDat.ExpectationValue(TxT, 0, ArrDat.E).ToString();
            
            label3.Text = "D[E] = " + ArrDat.Variance(TxT, 0, 0, ArrDat.E).ToString();
            
            label4.Text = "M[X] = " + ArrDat.ExpectationValue(TxT, 0, ArrDat.X).ToString();

            label5.Text = "D[X] = " + ArrDat.Variance(TxT, 0, TxT.factor[1], ArrDat.X).ToString();
        }
        private void SimulateTheFilter2_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.Y1, ArrDat.X, 1);
            isAxisAdded = true;
            label2.Text = "M[E] = " + ArrDat.ExpectationValue(TxT, 1, ArrDat.E).ToString();
            
            label3.Text = "D[E] = " + ArrDat.Variance(TxT, 1, 0, ArrDat.E).ToString();
            
            label4.Text = "M[X] = " + ArrDat.ExpectationValue(TxT, 1, ArrDat.X).ToString();
            
            label5.Text = "D[X] = " + ArrDat.Variance(TxT, 1, 0, ArrDat.X).ToString();
        }
        private void SimulateTheFilter3_Click(object sender, EventArgs e)
        {
            DrawGraph(ArrDat.Y1, ArrDat.X, 2);
            isAxisAdded = true;
            label2.Text = "M[E] = " + ArrDat.ExpectationValue(TxT, 2, ArrDat.E).ToString();
            
            label3.Text = "D[E] = " + ArrDat.Variance(TxT, 2, 0, ArrDat.E).ToString();
            
            label4.Text = "M[X] = " + ArrDat.ExpectationValue(TxT, 2, ArrDat.X).ToString();
            
            label5.Text = "D[X] = " + ArrDat.Variance(TxT, 2, 0, ArrDat.X).ToString();
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DrawGraph();
        }
    }
}
