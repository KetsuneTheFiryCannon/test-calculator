using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Calc
    {
        public int Sum(int firstNum, int secondNum)
        {
            return firstNum + secondNum;
        }

        public int Min(int firstNum, int secondNum)
        {
            return firstNum - secondNum;
        }

        public int Umn(int firstNum, int secondNum)
        {
            return firstNum * secondNum;
        }

        public int Del(int firstNum, int secondNum)
        {
            return firstNum / secondNum;
        }
    }
}
