
namespace EmployeeManagement.Tests
{
    public class TestTemplate
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }

        [Theory]
        [InlineData(1,1,1)]
        public void Test2(int i, int l, int k)
        {
            Assert.Equal(3, i + l + k);
        }
    }
}