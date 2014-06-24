using System;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
namespace Practice
{
    public partial class MainForm : Form
    {
        private Graphics Gr;
        Controller ctrl = new Controller();

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
            ctrl.FF.Filter();
            ctrl.KF.Filter();
        }
        private void Help_Button_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.ShowDialog();
            help.Dispose();
        }
        private void DeX_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ctrl.CM.CovarianceMatrix[0]);
        }
        private void DeH_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ctrl.CM.CovarianceMatrix[1]);
        }
        private void KeXH_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ctrl.CM.CovarianceMatrix[2]);
        }
        private void Time2_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ctrl.KF.a_tt);
        }
        private void Time1_Plot_Click(object sender, EventArgs e)
        {
            Gr.DrawGraph(ctrl.KF.A_tt);
        }
        private void OutputFilterGraphicAndStats(MatrixFactor mf)
        {
            Gr.DrawGraph(ctrl.KF.OutputSignal, ctrl.FF.OutputSignal, (byte)mf, isAxisAdded);
            isAxisAdded = true;
            label2.Text = "M[E] = " + StatisticalCharacteristics.ExpectationValue((byte)mf, ctrl.KF.E).ToString();

            label3.Text = "D[E] = " + StatisticalCharacteristics.Variance((byte)mf, ctrl.KF.E).ToString();

            label4.Text = "M[X] = " + StatisticalCharacteristics.ExpectationValue((byte)mf, ctrl.FF.OutputSignal).ToString();

            label5.Text = "D[X] = " + StatisticalCharacteristics.Variance((byte)mf, ctrl.FF.OutputSignal).ToString();
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
