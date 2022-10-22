using Diamond; 
namespace Diamond_test
{
    public class UnitTest1
    {
        
            [Fact]

            public void TestDraw1()
            {

            // Diamon letter 3, Row letter: c 
            // Expected to get back a string "  C  C  "
            string actual = DrawDiamond.OneLine('e', 'c');
            string expected = " c  c ";
            Assert.Equal(expected, actual); 

            }
        [Theory]
        [InlineData('e', 'a', "    a    ")]
        [InlineData('e', 'b', "   b b   ")]
        [InlineData('e', 'c', "  c   c  ")]
        [InlineData('e', 'd', " d     d ")]
        [InlineData('e', 'e', "e       e")]
        [InlineData('c', 'a', "  a  ")]
        [InlineData('c', 'b', " b b ")]
        [InlineData('c', 'c', "c   c")]
        public void TestDraw(char dletter, char rletter, string expected)
        {
            string actual = DrawDiamond.OneLine(dletter, rletter);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TestPadding1()
        {
            int actual = DrawDiamond.CalcPadding('e', 'c');
            int expected = 2;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData('e', 'a', 4)]
        [InlineData('e', 'b', 3)]
        [InlineData('e', 'c', 2)]
        [InlineData('e', 'd', 1)]
        [InlineData('e', 'e', 0)]
        [InlineData('c', 'a', 2)]
        [InlineData('c', 'b', 1)]
        [InlineData('c', 'c', 0)]
        public void TestPadding(char dletter, char rletter, int expected)
        {
            int actual = DrawDiamond.CalcPadding(dletter, rletter);
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void TestSpacing()
        {
            int actual = DrawDiamond.CalcSpacing('c');
            Assert.Equal(3, actual); 
        }

        [Theory]
        [InlineData('c', 3)]
        [InlineData('b', 1)]
        [InlineData('a', 0)]
        [InlineData('d', 5)]
        [InlineData('e', 7)]
        [InlineData('z', 49)]

        public void TestSpacing2(char rletter, int expected)
        {
            int actual = DrawDiamond.CalcSpacing(rletter); 
            Assert.Equal(expected, actual); 
        }

        //Create a single [fact] to test "MakeSpaces" 
        [Fact]
        public void MakeSpaces()
        {
            string actual = DrawDiamond.MakeSpace(2);
            string expected = "  ";
            Assert.Equal(expected, actual);

        }

        //Create a [theory] with three [inline data] lines 
        [Theory]
        [InlineData(2, "  ")]
        [InlineData(5, "     ")]
        [InlineData(0, "")]
        public void MakeSpaces1(int num, string expected)
        {
            string actual = DrawDiamond.MakeSpace(num);
            Assert.Equal(expected, actual);
        }
    }
}