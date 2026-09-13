using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.BerezkinDA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.BerezkinDA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public sealed class DataSerivceTest
    {
        [TestMethod]
        public void CheckedAdditionValid()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }

        public void CheckedSubtractionValid()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }

        public void CheckedMultiplicationValid()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }

        public void CheckedDivisionValid()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
    }
}
