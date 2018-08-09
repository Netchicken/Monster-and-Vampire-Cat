using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StuffUNeedToKnow;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GameCode myGameCode = new GameCode();

            //Expected
            //Actual
            //Assert

            int actual = myGameCode.RNDGenerator();

            Assert.IsTrue(actual > 0 && actual < 7);
            
        }
    }
}
