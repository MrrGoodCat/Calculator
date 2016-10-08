using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Model
    {
        public double DoMultiplication(int first, int second)
        {
            return first * second;
        }

        public double DoDivision(int first, int second)
        {
            return first / second;
        }

        public double DoSubtraction(int first, int second)
        {
            return first - second;
        }

        public double DoAddition(int first, int second)
        {
            return first + second;
        }
    }
}
