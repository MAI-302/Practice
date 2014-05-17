using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Данная программа служит для построения графиков Фильтра Калмана.";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Файл с исходными данными расположен в одной папке с приложением - InputSd.txt.";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Исходные данные изменяются в указанном файле. Порядок перечисления данных: ";
            textBox1.Text += Environment.NewLine;
            textBox1.Text += "Тау, А, а, альфа, бета, св, коэффициенты.";
            textBox1.Text += Environment.NewLine;
        }
    }
}
