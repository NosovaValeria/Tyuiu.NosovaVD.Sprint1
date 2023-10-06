using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint1.Task3.V13.Lib;
namespace Tyuiu.NosovaVD.Sprint1.Task3.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 324;
            double res = ds.MultiplyOfDigits(x);
            Assert.AreEqual(24, res);
        }
    }
}
