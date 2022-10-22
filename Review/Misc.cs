using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review
{
    public class Misc
    {

        public static bool CheckRange(int x)
        {
            //Checks if number is in between 10 - 20 inclusive 
            //Tests: 9,10, 15, 20, 21 
            if (x >= 10 && x <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Lets write a method that takes an integer and returns: 
        //   -1 if the integer is negative 
        //   0 if the integer is 0 
        // 1 if the integer is positive 
        //What should we test? 
        //        -2, 0, 2

        public static int PosNeg(int x)
        {
            if ( x < 0)
            {
                return -1;
            } 
            else if (x > 0)
            {
                return 1; 
            }
            else
            {
                return 0; 
            }
        }
    }
}
