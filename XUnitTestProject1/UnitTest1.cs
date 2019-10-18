using ClassLibrary1;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var test = new Class1
            {
                Name = "test"
            };

            Assert.True(test.Name.Equals("test"));
        }
    }
}
