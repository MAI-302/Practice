using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice
{
    /// <summary>
    /// Класс, содержащий методы проверки правильности работы фильтрации формирующего фильтра.
    /// </summary>
    [TestClass]
    public class UnitTestCalculateFormingFilter
    {
        /// <summary>
        /// Метод проверки Правильности работы фильтрации формирующего фильтра.
        /// </summary>
        [TestMethod]
        public void CalculateFormingFilter()
        {
            //Объявление параметров, для которых будет проверяться работа метода фильтрации формирующего фильтра.
            double tau = 0.01;
            double teta = 0.286;
            double sigma = 3.464;
            double fi = 4.414;
            double ksi = 11.427;
            double Sv = 0;
            int RowsCount = 3;
            int ColumnsCount = 5000;
            //Создаём нулевые массивы, в которые будем записывать аналитично посчитанные значения процесса после прохождения фильтрации.
            double[] analyticallycalculateX = { 0, 0, 0, 0 };
            double[] analyticallycalculateH = { 0, 0, 0, 0 };
         
            //Создаём случайный процесс и генерируем его.
            Practice.Signal.NormalDistributionSignal InitialSignal = new Practice.Signal.NormalDistributionSignal(0, Math.PI * 2 * Sv / tau);
            InitialSignal.GenerateSignal();
            //Создаём формирующий фильтр и фильтруем сигнал(сигнал содержится в экземпляре фильтра).
            Practice.Filter.FormingFilter FF = new Practice.Filter.FormingFilter(RowsCount, ColumnsCount, tau, ksi, sigma, teta, fi);
            FF.Filter();
            
            //Точность округления значений.
            int accuracy = 4;
            
            //Проверяем 3 первых значения сигнала после фильтрации формирующим фильтром, они должны совпадать с аналитически посчитанными значениями.
            for (int i = 0; i < 3; i++)
            {
                //Считаем значения по разностным формулам.
                analyticallycalculateX[i + 1] = analyticallycalculateX[i] + tau * 
                    (
                        analyticallycalculateH[i] + teta * FF.InitialSignal.SignalArray[i]
                    );

                //Считаем значения по разностным формулам.
                analyticallycalculateH[i + 1] = analyticallycalculateH[i] + tau * 
                    (
                        (fi - sigma * teta) * FF.InitialSignal.SignalArray[i] - 
                        sigma * analyticallycalculateH[i] - ksi * analyticallycalculateX[i]
                    );

                //Если значения не совпали с подсчитанными вручную, то тест не пройден.
                Assert.IsFalse
                (
                    Math.Round(FF.OutputSignal[0, i + 1],accuracy) != Math.Round(analyticallycalculateX[i + 1],accuracy) ||
                    Math.Round(FF.H[0, i + 1],accuracy) != Math.Round(analyticallycalculateH[i + 1],accuracy)
                );
            }
        }
    }
}
