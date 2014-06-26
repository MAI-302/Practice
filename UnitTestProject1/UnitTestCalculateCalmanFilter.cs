using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Practice
{
    /// <summary>
    /// Класс, содержащий методы проверки правильности работы фильтрации фильтра Калмана.
    /// </summary>
    [TestClass]
    public class UnitTestCalculateCalmanFilter
    {
        /// <summary>
        /// Метод проверки Правильности работы фильтрации фильтра Калмана.
        /// </summary>
        [TestMethod]
        public void CalculateCalmanFilter()
        {
            double s1, s2, s3, s4, s5;
            //Объявление параметров, для которых будет проверяться работа метода фильтра Калмана.
            double tau = 0.01;
            double teta = 0.286;
            double sigma = 3.464;
            double fi = 4.414;
            double ksi = 11.427;
            double Sv = 0;
            int RowsCount = 3;
            int ColumnsCount = 5000;
            //Создаём нулевые массивы, в которые будем записывать аналитично посчитанные значения процесса после прохождения фильтрации.
            double[] analyticallycalculateY1 = { 0, 0, 0, 0 };
            double[] analyticallycalculateY2 = { 0, 0, 0, 0 };
            
            //Создаём матрицу ковариаций(необходима для работы фильтра).
            Practice.Filter.Covariance CM;
            CM = new Practice.Filter.Covariance(3, 5000, 1.621, 0.542, 1.732, 2.903, 1.973, 0.01, 11.427, 3.464, 0.286, 4.414);
            
            //Создаём случайный процесс и генерируем его.
            Practice.Signal.NormalDistributionSignal InitialSignal = new Practice.Signal.NormalDistributionSignal(0, Math.PI * 2 * Sv / tau);
            InitialSignal.GenerateSignal();
            //Создаём формирующий фильтр и фильтруем сигнал(сигнал содержится в экземпляре фильтра).
            Practice.Filter.FormingFilter FF = new Practice.Filter.FormingFilter(RowsCount, ColumnsCount, tau, ksi, sigma, teta, fi);
            FF.Filter();
            //Создаём фильтр калмана и фильтруем сигнал полученный в ходе работы формируюшего фильтра.
            Practice.Filter.KalmanFilter KF = new Practice.Filter.KalmanFilter(RowsCount, ColumnsCount, FF.OutputSignal, CM);
            KF.Filter();
            
            //Точность значений.
            int accuracy=4;
            //Проверяем 3 первых значения сигнала после фильтрации фильтром Калмана.
            for (int i = 0; i < 3; i++)
            {
                //Считаем значения по разностным формулам.
                analyticallycalculateY1[i + 1] = analyticallycalculateY1[i] + KF.CovMatr.tau * 
                    (
                        analyticallycalculateY2[i] + KF.CovMatr.CovarianceMatrix[0][0, i] * 
                        (
                            (FF.OutputSignal[0, i] + KF.Noize.SignalArray[i] - analyticallycalculateY1[i]) /
                            (2 * Math.PI * KF.CovMatr.factor[0] * KF.CovMatr.Sw)
                        )
                    );
                //Считаем значения по разностным формулам. 
                analyticallycalculateY2[i + 1] = analyticallycalculateY2[i] + KF.CovMatr.tau *
                    (
                        KF.CovMatr.CovarianceMatrix[2][0, i] * 
                        (FF.OutputSignal[0, i] + KF.Noize.SignalArray[i] - analyticallycalculateY1[i]) / 
                        (2 * Math.PI * KF.CovMatr.factor[0] * KF.CovMatr.Sw) - KF.CovMatr.ksi * analyticallycalculateY1[i] - 
                        KF.CovMatr.sigma * analyticallycalculateY2[i]
                    );
                
                //Если значения не совпали с подсчитанными вручную, то тест не пройден.
                s1 = Math.Round(KF.OutputSignal[0, i + 1], accuracy);
                s2 = Math.Round(analyticallycalculateY1[i + 1], accuracy);
                s3 = Math.Round(KF.Y2[0, i + 1], accuracy);
                s4 = Math.Round(analyticallycalculateY2[i + 1], accuracy);
                s5 = 5;
                Assert.IsFalse
                (
                    Math.Round(KF.OutputSignal[0, i + 1], accuracy) != Math.Round(analyticallycalculateY1[i + 1], accuracy) ||
                    Math.Round(KF.Y2[0, i + 1], accuracy) != Math.Round(analyticallycalculateY2[i + 1], accuracy)
                );
            }
        }
    }
}
