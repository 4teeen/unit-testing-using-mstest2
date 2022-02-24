using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySuperBestProject1;

namespace MySuperBestProject.Tests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestNums()
        {
            double x1 = 5;
            double N1 = 3;
            //private readonly MySuperBestProject1 mjpb;
            double t1 = Poww.Powy(x1, N1);
            Poww.Powy(x1, N1);
            double x2 = 4;
            double N2 = 4;
            double t2 = Poww.Powy(x2, N2);
            Assert.AreEqual(125, t1);
            Assert.AreNotEqual(0, t1);
            Assert.AreEqual(256, t2);
            Assert.AreNotEqual(t1, t2);
            Assert.IsNotNull(t1);
        }
        [TestMethod]
        public void TestLetts()
        {
            char y = 'y';
            char z = 'z';
            double y1 = Poww.Powy(y, 999);
            double yz = Poww.Powy(y, z);
            Assert.AreEqual(1, y1);
            Assert.AreEqual(123, yz);
        }
    }
}
