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
