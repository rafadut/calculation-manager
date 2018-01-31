using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public class CalculationManager
    {
        public double Add(object initNumber, object additional)
        {
            double baseNumber = Convert.ToDouble(initNumber);
            double addingNumber = Convert.ToDouble(additional);
            return baseNumber + addingNumber;
        }
    }

    public interface ICalculator
    {
        double Add(double firstNumber, double lastNumber);
    }

    public class Mathematics
    {
        private ICalculator calculator;
        public Mathematics(ICalculator calc)
        {
            calculator = calc;
        }
        public double AddNumbers()
        {
            return calculator.Add(1, 1);
        }
    }
}
