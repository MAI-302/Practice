using System;
using System.IO;
using System.Text;

namespace Practice
{
    public class InitialData //может быть изменена пользователем
    {
        public double tau { get; set; }
        public double A { get; set; }
        public double a { get; set; }
        public double alpha { get; set; }
        public double beta { get; set; }
        public double Sv { get; set; }
        public double[] factor = new double[3];
        public int m { get; set; }
        public int n { get; set; }
        public void ReadInputData()
        {
            string path = "InputSd.txt";
            int LinesCount = File.ReadAllLines(path).Length;
            string[] SupportStringArray = new string[LinesCount - 1];
            using (StreamReader Reader = new StreamReader(path, Encoding.Default))
            {
                while (!Reader.EndOfStream)
                    for (int i = 0; i < LinesCount; i++)
                    {
                        string MassiveLine = Reader.ReadLine();
                        if (MassiveLine.Contains(" "))
                        {
                            string[] SplitLine = MassiveLine.Split(new Char[] { ' ', '\t' });
                            for (int j = 0; j < SplitLine.Length; j++)
                                factor[j] = Double.Parse(SplitLine[j]);
                        }
                        else
                            SupportStringArray[i] = MassiveLine;
                    }
                Reader.Close();
            }
            tau = Double.Parse(SupportStringArray[0]);
            A = Double.Parse(SupportStringArray[1]);
            a = Double.Parse(SupportStringArray[2]);
            alpha = Double.Parse(SupportStringArray[3]);
            beta = Double.Parse(SupportStringArray[4]);
            Sv = Double.Parse(SupportStringArray[5]);
            m = Int32.Parse(SupportStringArray[6]);
            n = Int32.Parse(SupportStringArray[7]);
        } 
    }
}