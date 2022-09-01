using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Register
{
    public class CashRegister
    {
        // One function: takes a list of products 
        // and calculates the grand total price. 
        public static decimal GrandTotal(List<Product> price)
        {
            decimal total = 0; 
            foreach (Product product in price)
            {
                total += product.Price;
            }
            return total;
        }
        // Second function: takes a list of products 
        // and calculates the sales tax. (Say 6% or 
        //whatever you like.) 

        public static decimal CalculateTax(List<Product> price)
        {
            // You'll need to take GrandTotal and apply the tax to it 
            // then calculate the tax. 
            // So for example if we have a list like this: 
            //   milk 2.00
            //  bread 2.50 
            //  CokeZero 2.50 
            // Return 0.42.
            decimal salesTax = 0.06m; 

            return GrandTotal(price) * salesTax; 
        }
    }
}
