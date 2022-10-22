using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcAPp
{
    public class Calculator
    {

        public int Number { get; set; }

        public Calculator(int number)
        {
            Number = number;
        }   

        public int FindFactorial()
        {
            int result = Number; 
            for(int i = Number - 1; i >= 1; i--)
            {
                result = result * i;
            } 
            return result;
        }

        public List<int> FindFactors()
        {
            List<int> result = new List<int>();
            for(int num = 1; num <= Number / 2; num++)
            {
                if (Number % num == 0)
                {
                    result.Add(num);
                }
            }
            result.Add(Number);
            return result; 
        }
    }
}
