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
        private TextInput TxT = new TextInput();
        private ArrayData ArrDat = new ArrayData();
        private StatisticalCharacteristics StatChars;
        private Graphics Gr;
        Help help = new Help();
        private static bool isAxisAdded = false;
        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Gr = new Graphics(ref zedGraph);
            TxT.ReadInputData();
            ArrDat.ArrayInitialization(TxT);
            ArrDat.NormalDistribution(TxT);
            ArrDat.CovarianceMatrix(TxT);
            StatChars = new StatisticalCharacteristics(ref ArrDat, ref TxT);
        }
        private void Help_Button_Click(object sender, EventArgs e)
        {
            help.ShowDialog();
        }
        private void DeX_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.DeX);
        }
        private void DeH_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.DeH);
        }
        private void KeXH_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.KeXH);
        }
        private void Time2_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.a_tt);
        }
        private void Time1_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.A_tt);
        }
        private void SimulateTheFilter_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.Y1, ArrDat.X, 0, isAxisAdded);
            isAxisAdded = true;
            label2.Text = "M[E] = " + StatChars.ExpectationValue(0, false).ToString();

            label3.Text = "D[E] = " + StatChars.Variance(0, StatChars.ExpectationValue(0, false), false).ToString();

            label4.Text = "M[X] = " + StatChars.ExpectationValue(0, true).ToString();

            label5.Text = "D[X] = " + StatChars.Variance(0, StatChars.ExpectationValue(0, true), true).ToString();
        }
        private void SimulateTheFilter2_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.Y1, ArrDat.X, 1, isAxisAdded);
            isAxisAdded = true;
            label2.Text = "M[E] = " + StatChars.ExpectationValue(1, false).ToString();

            label3.Text = "D[E] = " + StatChars.Variance(1, StatChars.ExpectationValue(1, false), false).ToString();

            label4.Text = "M[X] = " + StatChars.ExpectationValue(1, true).ToString();

            label5.Text = "D[X] = " + StatChars.Variance(1, StatChars.ExpectationValue(1, true), true).ToString();
        }
        private void SimulateTheFilter3_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ArrDat.Y1, ArrDat.X, 2, isAxisAdded);
            isAxisAdded = true;
            label2.Text = "M[E] = " + StatChars.ExpectationValue(2, false).ToString();

            label3.Text = "D[E] = " + StatChars.Variance(2, StatChars.ExpectationValue(2, false), false).ToString();

            label4.Text = "M[X] = " + StatChars.ExpectationValue(2, true).ToString();

            label5.Text = "D[X] = " + StatChars.Variance(2, StatChars.ExpectationValue(2, true), true).ToString();
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
