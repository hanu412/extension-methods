using Xunit;

namespace ExtensionMethods.Tests
{
    // [TestClass]
    public class String_XUnitTests
    {
        
        [Theory]
        [InlineData(" ",false)]
        [InlineData("",false)]
        [InlineData(null,false)]
        
        public void Should_Fail_For_Null(string input,bool expected)
        {
          bool result =  input.IsInteger();
            Assert.Equal(expected, result);
        }
    }
}
