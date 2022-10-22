using ListDemo;
using Xunit; 

namespace ListDemo_test
{
    public class UnitTest1
    {
        [Fact]
        public void TestRemoveLargest()
        {
            List<int> values = new List<int>() { 5, 20, 6, 3};
            List<int> actual = MyLists.RemoveLargestNumber(values);

            List<int> expected = new List<int>() { 5, 6, 3 };
            Assert.Equal(expected, actual);

        }d

        //What to taste? 
        //A basic one {5, 20, 6, 3} -> { 5, 6, 3 }
        //Double greates {5, 20, 6, 20, 3} -> { 5, 6, 20, 3}
        //Empty list { } -> { }
        //All the same numbers {5, 5, 5, 5} -> {5, 5, 5}
        //Only One: { 5} -> { }

        [Theory]
        [InlineData(new int[] {5,20,6,3},     new int[] {5,6,3})]
        [InlineData(new int[] {5,20,6,20,3},  new int[] {5,20,6,3})]
        [InlineData(new int[] { },            new int[] { })]
        [InlineData(new int[] {5,5,5,5},      new int[] {5,5,5})]
        [InlineData(new int[] {5},            new int[] { })]
        
        public void TestRemoveLargest1(int[] valuesArray, int[] expectedArray)
        {
            List<int> values = new List<int>(valuesArray);
            List<int> expected = new List<int>(expectedArray);

            List<int> actual = MyLists.RemoveLargestNumber(values);
            Assert.Equal(actual, expected);
        }

        // Just for demonstration purposes, let's try out Assert.Contains 

        [Fact]
        public void ContainsDemo()
        {
            List<int> myList = new List<int>() { 5, 20, 6, 3};
            List<int> result = MyLists.RemoveLargestNumber(myList);

            //Don't do the commented code below 
            //Let's make sure that 3 is still in the list 
            //bool actual = result.Contains(3);
            Assert.Contains<int>(3, result);    
        }
    }
}