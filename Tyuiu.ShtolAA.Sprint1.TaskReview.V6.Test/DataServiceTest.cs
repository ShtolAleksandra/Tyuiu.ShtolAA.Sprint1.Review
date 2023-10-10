using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShtolAA.Sprint1.TaskReview.V6.Lib;

namespace Tyuiu.ShtolAA.Sprint1.TaskReview.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalc()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = -22;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
