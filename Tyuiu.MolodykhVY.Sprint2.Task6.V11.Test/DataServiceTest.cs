using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MolodykhVY.Sprint2.Task6.V11.Lib;

namespace Tyuiu.MolodykhVY.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int g = 2013;
            int m = 11;
            int n = 17;
            string wait = (18 + "." + 11 + "." + 2013);
            string res = ds.FindDateOfNextDay(g, m, n);
            Assert.AreEqual(res, wait);
        }
    }
}
