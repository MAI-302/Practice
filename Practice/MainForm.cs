using System;
using System.Drawing;
using System.Globalization;
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
            FirstFactor,
            SecondFactor,
            ThirdFactor
        }
        public MainForm()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Gr = new Graphics(ref zedGraph);
        }

        private void Calc()
        {
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

        private void bLoad_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                if (ID.Load(openFileDialog.FileName))
                {
                    mTBTau.Text = ID.tau.ToString(CultureInfo.InvariantCulture);
                    mTBA.Text = ID.A.ToString(CultureInfo.InvariantCulture);
                    mTBSmalla.Text = ID.a.ToString(CultureInfo.InvariantCulture);
                    mTBAlpha.Text = ID.alpha.ToString(CultureInfo.InvariantCulture);
                    mTBBeta.Text = ID.beta.ToString(CultureInfo.InvariantCulture);
                    mTBSv.Text = ID.Sv.ToString(CultureInfo.InvariantCulture);
                    mTBm.Text = ID.m.ToString(CultureInfo.InvariantCulture);
                    mTBn.Text = ID.n.ToString(CultureInfo.InvariantCulture);

                    mTBFactor1.Text = ID.factor[0].ToString(CultureInfo.InvariantCulture);
                    mTBFactor2.Text = ID.factor[1].ToString(CultureInfo.InvariantCulture);
                    mTBFactor3.Text = ID.factor[2].ToString(CultureInfo.InvariantCulture);

                    this.Text = this.Text.Split('-')[0] + "- " + openFileDialog.FileName;
                    Calc();
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ID.Save(saveFileDialog.FileName);
            }
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            try
            {
                ID.tau = double.Parse(mTBTau.Text);
                ID.A = double.Parse(mTBA.Text);
                ID.a = double.Parse(mTBSmalla.Text);
                ID.alpha = double.Parse(mTBAlpha.Text);
                ID.beta = double.Parse(mTBBeta.Text);
                ID.Sv = double.Parse(mTBSv.Text);
                ID.m = int.Parse(mTBm.Text);
                ID.n = int.Parse(mTBn.Text);

                ID.factor[0] = double.Parse(mTBFactor1.Text);
                ID.factor[1] = double.Parse(mTBFactor2.Text);
                ID.factor[2] = double.Parse(mTBFactor3.Text);

                Calc();
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка задания значений параметров.", Application.ProductName);
            }
        }
    }
}
