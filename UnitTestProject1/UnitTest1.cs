using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp3;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int chislo = 2;
            int expect = 4;

            Umnojeniena2 account = new Umnojeniena2(chislo);

            account.Umnojenie(chislo);

            int actual = account.Vivod;

            Assert.IsTrue(expect == actual);
        }
    }
}
