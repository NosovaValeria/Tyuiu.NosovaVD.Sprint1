using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint1.Task7.V16.Lib;
namespace Tyuiu.NosovaVD.Sprint1.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(1.022, res);
        }
    }
}
