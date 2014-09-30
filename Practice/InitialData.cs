using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Practice
{
    public class InitialData //может быть изменена пользователем
    {
        public double tau
        {
            get;
            set;
        }
        public double A
        {
            get;
            set;
        }
        public double a
        {
            get;
            set;
        }
        public double alpha
        {
            get;
            set;
        }
        public double beta
        {
            get;
            set;
        }
        public double Sv
        {
            get;
            set;
        }
        public double[] factor = new double[3];
        public int m
        {
            get;
            set;
        }
        public int n
        {
            get;
            set;
        }
        public bool Load(string fileName)
        {
            bool res = false; // Флаг

            if (File.Exists(fileName)) // Файл существует?
            {
                using (Stream fStream = File.OpenRead(fileName)) // Открыть файл
                {
                    try
                    {
                        InitialData ID = ((InitialData)(new XmlSerializer(typeof(InitialData))).Deserialize(fStream)); // Сериализация fStream
                        tau = ID.tau;
                        A = ID.A;
                        a = ID.a;
                        alpha = ID.alpha;
                        beta = ID.beta;
                        Sv = ID.Sv;
                        factor = ID.factor;
                        m = ID.m;
                        n = ID.n;

                        res = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ошибка загрузки параметров.", Application.ProductName); // Вывести на экран сообщение об ошибке
                    }
                }
            }

            return res;
        }

        public void Save(string fileName)
        {
            using (Stream fStream = File.Create(fileName)) // Создать файл
            {
                (new XmlSerializer(typeof(InitialData))).Serialize(fStream, this); // Сериализация fStream
            }
        }
    }
}