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
        private InitialData ID = new InitialData();
        private Graphics Gr;

        private CovarianceMatrix CM;
        private FormingFilter FF;
        private KalmanFilter KF;

        private static bool isAxisAdded = false;
        //Коэффициенты, с которыми вычисляется значение входного/выходного сигнала, ошибки или другого значения, необходимого для работы фильтра Калмана
        private enum MatrixFactor : byte 
        {
            FirstFactor, SecondFactor, ThirdFactor
        }
        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Gr = new Graphics(ref zedGraph);
            ID.ReadInputData();
            CM = new CovarianceMatrix(ref ID);
            FF = new FormingFilter(ref ID);
            KF = new KalmanFilter(ref ID, ref FF);
        }
        private void Help_Button_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
            help.Dispose();
        }
        private void DeX_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(CM.DeX);
        }
        private void DeH_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(CM.DeH);
        }
        private void KeXH_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(CM.KeXH);
        }
        private void Time2_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(KF.a_tt);
        }
        private void Time1_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(KF.A_tt);
        }
        private void OutputFilterGraphicAndStats(MatrixFactor mf)
        {
            Gr.DrawGraph(KF.Y1, FF.X, (byte)mf, isAxisAdded);
            isAxisAdded = true;
            label2.Text = "M[E] = " + StatisticalCharacteristics.ExpectationValue((byte)mf, KF.E).ToString();

            label3.Text = "D[E] = " + StatisticalCharacteristics.Variance((byte)mf, KF.E).ToString();

            label4.Text = "M[X] = " + StatisticalCharacteristics.ExpectationValue((byte)mf, FF.X).ToString();

            label5.Text = "D[X] = " + StatisticalCharacteristics.Variance((byte)mf, FF.X).ToString();
        }
        private void SimulateTheFilter_Click(object sender, EventArgs e)
        {
            OutputFilterGraphicAndStats(MatrixFactor.FirstFactor);
        }
        private void SimulateTheFilter2_Click(object sender, EventArgs e)
        {
            OutputFilterGraphicAndStats(MatrixFactor.SecondFactor);
        }
        private void SimulateTheFilter3_Click(object sender, EventArgs e)
        {
            OutputFilterGraphicAndStats(MatrixFactor.ThirdFactor);
        }
        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
