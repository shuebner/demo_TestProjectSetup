using Project1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            // let build fail if project set-up is incomplete
            new Class1();
            new TestUtil.Class1();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}