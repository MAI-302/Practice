using Practice.Filter;
using System;

namespace Practice
{
    [Serializable]
    public class Controller
    {
        public FormingFilter FF;
        public KalmanFilter KF;
        public Covariance CM;
        public Controller()
        {
            FF = new FormingFilter(3, 5000, 0.01, 11.427, 3.464, 0.286, 4.414);
            CM = new Covariance(3, 5000, 1.621, 0.542, 1.732, 2.903, 1.973, 0.01, 11.427, 3.464, 0.286, 4.414);
            KF = new KalmanFilter(3, 5000, FF.OutputSignal, CM);
        }
    }
}