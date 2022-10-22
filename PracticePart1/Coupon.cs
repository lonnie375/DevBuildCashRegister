using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePart1
{
    public class Coupon
    {
        public static int GetSign(int num)
        {
            if (num < 0)
            {
                return -1;
            }
            else if (num > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
            
        }

        public static bool IsRangeVersion1(int num)
        {
            return false;
        }

        public static bool IsRangeVersion2(int num)
        {
            return false;
        }

        public static decimal CalculateCoupon(decimal purchase)
        {
            if (purchase < 10)
            {
                return 0.0m; 
            }
            else if (purchase <= 19.99m)
            {
                return 2.0m;
            }
            else
            {
                return 3.0m; 
            }
           
        }
    }
}
