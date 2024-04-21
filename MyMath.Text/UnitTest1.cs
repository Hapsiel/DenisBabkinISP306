using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LibTest;
namespace MyMath.Text
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Method_20and10_300return()
        {
            //arrange
            int x = 20;
            int y = 10;
            int expecterd = 300;
            //act
            Sum c = new Sum();
            int actual = c.Method(x, y);
            //Assert
            Assert.AreEqual(expecterd, actual);
        }
    }
}
