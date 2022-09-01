using Register; 

namespace Register_test
{
    public class UnitTest1
    {
        // DOn't try to use [Theory]
        // Just make individual tests with [Fact}
        // Inside each test, create a list of products 
        // and call the function and compare actual to expected 
        // You will only need to use arrays when using Theory, since we're not we should be 
        // okay with using List for actual and expectations. 
        [Fact]
        public void TestGrandTotal()
        {
            List<Product> products = new List<Product>();
            
            Product firstList = new Product("Apple", 5.00m);
            Product secondItem = new Product("Pears", 6.00m);
           products.Add(firstList);
            products.Add(secondItem);

            decimal actual = CashRegister.GrandTotal(products);
            decimal expected = 11.00m; 
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void TestGrandTotal2()
        {
            List<Product>products = new List<Product>();
            

            decimal actual = CashRegister.GrandTotal(products);
            decimal expected = 0.00m;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalcTax()
        {
            List<Product> products = new List<Product>();
            Product firstList = new Product("Apple", 5.00m);
            Product secondItem = new Product("Pears", 6.00m);
            products.Add(firstList);
            products.Add(secondItem);

            decimal actual = CashRegister.CalculateTax(products);
            decimal expected = 0.66m;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestCalcTax2()
        {
            List<Product> products = new List<Product>();

            decimal actual = CashRegister.CalculateTax(products);
            decimal expected = 0.00m;
            Assert.Equal(expected, actual);
        }
    }
}