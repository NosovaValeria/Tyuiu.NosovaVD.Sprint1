using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.NosovaVD.Sprint1.Task6.V12.Lib;
namespace Tyuiu.NosovaVD.Sprint1.Task6.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpresiion()
        {
            DataService ds = new DataService();
            string text = "привет мир! крутой мир";
            bool res = ds.CheckLastWordRepetiton(text);
            Assert.AreEqual(true, res);
        }
    }
}
