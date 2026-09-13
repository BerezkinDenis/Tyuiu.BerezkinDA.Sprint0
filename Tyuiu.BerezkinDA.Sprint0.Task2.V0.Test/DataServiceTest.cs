using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.BerezkinDA.Sprint0.Task2.V0.Lib;

namespace Tyuiu.BerezkinDA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Денис";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Денис", res);
        }
    }
}
