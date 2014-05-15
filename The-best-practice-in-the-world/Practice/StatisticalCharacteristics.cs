using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StatisticalCharacteristics
    {
        private double[,] E_Array, X_Array;
        private int ArraySize;
        public double ExpectationValue(int FactorChosen, bool ArrChosen)
        {
            double ExpectValue = 0;
            if (ArrChosen)
                for (int i = 300; i < ArraySize - 1; i++)
                    ExpectValue = ExpectValue + X_Array[FactorChosen, i];
            else
                for (int i = 300; i < ArraySize - 1; i++)
                    ExpectValue = ExpectValue + E_Array[FactorChosen, i];
            return ExpectValue / (ArraySize - 301);
        }
        public double Variance(int FactorChosen, double Me, bool ArrChosen)
        {
            double Dispersion = 0;
            if (ArrChosen)
                for (int i = 300; i < ArraySize - 1; i++)
                    Dispersion = Dispersion + Math.Pow((X_Array[FactorChosen, i] - Me), 2);
            else
                for (int i = 300; i < ArraySize - 1; i++)
                    Dispersion = Dispersion + Math.Pow((E_Array[FactorChosen, i] - Me), 2);
            return Dispersion / (ArraySize - 301);
        }
        public StatisticalCharacteristics(ref ArrayData ArrDat, ref TextInput TxT) 
        {
            E_Array = ArrDat.E;
            X_Array = ArrDat.X;
            ArraySize = TxT.n;
        }
    }
}
