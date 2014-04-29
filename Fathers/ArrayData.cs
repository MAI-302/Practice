using System;

namespace Practice
{
    public class ArrayData
    {
        public double[,] DeX;
        public double[,] DeH;
        public double[,] KeXH;
        public double[,] a_tt;
        public double[,] A_tt;
        public double[,] X;
        public double[,] H;
        public double[,] Y1;
        public double[,] Y2;
        public double[,] E;
        public double[] NormalArray;
        
        public void ArrayInitialization(TextInput TxT)
        {
            DeX = new double[TxT.m, TxT.n];
            DeH = new double[TxT.m, TxT.n];
            KeXH = new double[TxT.m, TxT.n];
            a_tt = new double[TxT.m, TxT.n];
            A_tt = new double[TxT.m, TxT.n];
            X = new double[TxT.m, TxT.n];
            H = new double[TxT.m, TxT.n]; //invisible
            Y1 = new double[TxT.m, TxT.n];
            Y2 = new double[TxT.m, TxT.n];//invisible
            E = new double[TxT.m, TxT.n];
            NormalArray = new double[TxT.n];
        }
        public ArrayData()
        { }
    }
}
