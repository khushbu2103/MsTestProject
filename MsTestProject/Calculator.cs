using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestProject
{
    public class Calculator
    {
        public int AddtwoNumbers(int first, int second)
        {
            return first + second;
            Console.ReadLine();
        }
        public int DifferenceOftwoNumbers(int first, int second)
        {
            return Math.Abs(first - second);
            Console.ReadLine();
        }

    }
}
