using Xunit.Abstractions;

namespace RestSharpXUnit
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper testOutputHelper;

        public UnitTest1(ITestOutputHelper testOutputHelper)
        {
            this.testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            testOutputHelper.WriteLine("Executing 1st test");
        }
    }
}