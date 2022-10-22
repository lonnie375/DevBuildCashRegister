using PigLattin;

namespace PigLatin_Test
{
    public class UnitTest1
    {

        //// Here we'll test five individual letters separately 

        //[Fact]
        //public void TestIsVowela()
        //{
        //    bool actual = Translator.IsVowel('a'); 
        //    Assert.True(actual);
        //}

        //[Fact]
        //public void TestIsVowele()
        //{
        //    bool actual = Translator.IsVowel('e');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVoweli()
        //{
        //    bool actual = Translator.IsVowel('i');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVowelo()
        //{
        //    bool actual = Translator.IsVowel('o');
        //    Assert.True(actual);
        //}
        //[Fact]
        //public void TestIsVowelu()
        //{
        //    bool actual = Translator.IsVowel('u');
        //    Assert.True(actual);
        //}
        //Let's right one that tests all of the above that we commented out 

        [Theory]

        [InlineData('a')]
        [InlineData('e')]
        [InlineData('i')]
        [InlineData('o')]
        [InlineData('u')]

        public  void TestIsVowel(char value)
        {
            bool actual = Translator.IsVowel(value);
            Assert.True(actual);
        }

        [Theory]
        [InlineData('s')]
        [InlineData('z')]
        [InlineData('y')]

        public void TestIsVowelCons(char value)
        {
            bool actual = Translator.IsVowel(value);
            Assert.False(actual);

        }

        //[Fact]
        //public void TestIsVowels()
        //{
        //    bool actual = Translator.IsVowel('s');
        //    Assert.False(actual);
        //}

        //[Fact]
        //public void TestIsVowelz()
        //{
        //    bool actual = Translator.IsVowel('z');
        //    Assert.False(actual);
        //}



        [Fact]

        public void StartsWithVowel()
        {
            bool actual = Translator.StartsWIthVowel("apple"); 
            Assert.True(actual);
        }

        //Added additional test for if it's not a vowel. 
        //We wouldn't get an output which is what we want. 
        //THe method will not return the result or true. 

        [Theory]
        [InlineData("fruit")]
        [InlineData("banana")]
        [InlineData("pear")]
        public void TestStartsWithVowel(string str)
        {
            bool actual = Translator.StartsWIthVowel(str);
            Assert.False(actual); 
        }

        [Fact]

        public void StartsWithVowelCons()
        {
            bool actual = Translator.StartsWIthVowel("school");
            Assert.False(actual);
        }

        [Theory]
        [InlineData("banana", 1)]
        [InlineData("shout", 2)]
        [InlineData("school", 3)]
        [InlineData("rhythm", 6)]


         public void TestNumCons(string value, int expected)
        {
            int actual = Translator.NumberOfCons(value);
            Assert.Equal(expected, actual);
        }



        //[Fact]

        //public void TestNumConsBanana()
        //{
        //    int actual = Translator.NumberOfCons("banana");
        //    Assert.Equal(1, actual);
        //}


        //[Fact]

        //public void TestNumConsShout()
        //{
        //    int actual = Translator.NumberOfCons("shout");
        //    Assert.Equal(2, actual);
        //}



        //[Fact]

        //public void TestNumConsSchool()
        //{
        //    int actual = Translator.NumberOfCons("school");
        //    Assert.Equal(3, actual);
        //}


        [Theory]
        [InlineData("apple", "appleyay")]
        [InlineData("every", "everyyay")]
        [InlineData("open", "openyay")]
        

        public void TestPLVowels(string word, string expected)
        {
            string actual = Translator.PigLatinVowels(word);
            Assert.Equal(expected, actual);
        }

        //[Fact]

        //public void TestPLVowel1()
        //{
        //    string actual = Translator.PigLatinVowels("apple");
        //    Assert.Equal("appleyay", actual);
        //}


        //[Fact]

        //public void TestPLVowel2()
        //{
        //    string actual = Translator.PigLatinVowels("every");
        //    Assert.Equal("everyyay", actual);
        //}


        [Theory]
        [InlineData("school", "oolschay")]
        [InlineData("something", "omethingsay")]
        [InlineData("rhythm", "rhythmay")]
        
        public void TestPLCons(string value, string expected)
        {
            string actual = Translator.PigLatinCons(value);
            Assert.Equal(expected, actual);
        }

        //[Fact]

        //public void TestPLCons1()
        //{
        //    string actual = Translator.PigLatinCons("school");
        //    Assert.Equal("oolschay", actual);
        //}

        //[Fact]

        //public void TestPLCons2()
        //{
        //    string actual = Translator.PigLatinCons("something");
        //    Assert.Equal("omethingsay", actual);
        //}

        //[Fact]
        //public void TestPlCons3()
        //{
        //    string actual = Translator.PigLatinCons("rhythm");
        //    Assert.Equal("rhythmay", actual);
        //}

        [Fact]
        public void TestCons4()
        {
            int actual = Translator.NumberOfCons("rhythm");
            Assert.Equal(6, actual);    
        }


        [Theory]
        [InlineData("eat", "eatyay")]
        [InlineData("banana", "ananabay")]
     

        public void TestPigLatin(string word, string expected)
        {
            string actual = Translator.PigLatinize(word);
            Assert.Equal(expected, actual); 
        }
        //[Fact]

        //public void TestPigLatin1()
        //{
        //    string actual = Translator.PigLatinize("eat");
        //    Assert.Equal("eatyay", actual);
        //}

        //[Fact]

        //public void TestPigLatin2()
        //{
        //    string actual = Translator.PigLatinize("banana");
        //    Assert.Equal("ananabay", actual);
        //}


    }
}